using System;
using System.Windows.Forms;

namespace MagicBoot
{
    public partial class commandView : Form
    {
        LoadConfig ini;
        public commandView()
        {
            InitializeComponent();
            ini = new LoadConfig(Application.StartupPath + @"\command.ini");
            InitList();
        }

        public void InitList()
        {
            String temp = ini.getAllKeyInIni("Command List");
            String[] keys = temp.Split('\0');
            ListViewItem[] commands = new ListViewItem[keys.Length];
            for(int i=0; i < keys.Length; i++)
            {
                String value = ini.ReadIni("Command List", keys[i]);
                commands[i] = new ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, keys[i], System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, value, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))))}, -1);
            }
            this.commandList.Items.AddRange(commands);
        }
    }
}
