using System;
using System.Windows.Forms;

namespace MagicBoot
{
    public partial class commandView : Form
    {
        LoadConfig ini;
        private static commandView _instance = null;

        private commandView()
        {
            InitializeComponent();
            ini = new LoadConfig(Application.StartupPath + @"\command.ini");
            InitList();
        }

        public static commandView getInstance()
        {
            if(_instance == null || _instance.IsDisposed)
            {
                _instance = new commandView();
            }
            return _instance;
        }

        public void InitList()
        {
            String temp = ini.getAllKeyInIni("Command List");
            if(temp == "")
            {
                return;
            }
            String[] keys = temp.Split('\0');
            ListViewItem[] commands = new ListViewItem[keys.Length];
            for(int i=0; i < keys.Length; i++)
            {
                String value = ini.ReadIni("Command List", keys[i]);
                commands[i] = new ListViewItem(new ListViewItem.ListViewSubItem[] {
            new ListViewItem.ListViewSubItem(null, keys[i], System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new ListViewItem.ListViewSubItem(null, value, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))))}, -1);
                commands[i].ToolTipText = value;
            }
            this.commandList.Items.AddRange(commands);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            addCommand ac = addCommand.getInstance();
            ac.FormClosing += Ac_FormClosing;
            ac.Show();
        }

        private void Ac_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.commandList.Items.Clear();
                InitList();
            }
            catch(Exception ace)
            {
                MessageBox.Show(ace.Message);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            this.commandList.BeginUpdate();
            foreach(ListViewItem item in this.commandList.CheckedItems)
            {
                ini.IniWriteValue("Command List", item.Text, null);
                item.Remove();
            }
            this.commandList.EndUpdate();
        }

        private void commandView_Load(object sender, EventArgs e)
        {
            this.commandList.Columns[1].Width = this.commandList.ClientSize.Width - this.commandList.Columns[0].Width;
        }

        private void commandView_SizeChanged(object sender, EventArgs e)
        {
            this.commandList.Columns[1].Width = this.commandList.ClientSize.Width - this.commandList.Columns[0].Width;
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            this.commandList.BeginUpdate();
            foreach (ListViewItem item in this.commandList.SelectedItems)
            {
                ini.IniWriteValue("Command List", item.Text, null);
                item.Remove();
            }
            this.commandList.EndUpdate();
        }

        private void ReloadList(object sender, EventArgs e)
        {
            try
            {
                this.commandList.Items.Clear();
                InitList();
            }
            catch (Exception ace)
            {
                MessageBox.Show(ace.Message);
            }
        }
    }
}
