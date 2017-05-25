using System;
using System.Windows.Forms;

namespace CommandStartProgram
{
    public partial class addCommand : Form
    {
        public addCommand()
        {
            InitializeComponent();
        }

        private void selectProgram_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String fileName = openFileDialog1.FileName;
            if (System.IO.File.Exists(fileName))
            {
                selectProgram.Text = fileName;
            }
            if (fileName != "")
            {
                selectProgram.BorderStyle = BorderStyle.None;
            }
        }

        private void addProgram_Click(object sender, EventArgs e)
        {
            String command = Command.Text;
            String fileName = openFileDialog1.FileName;
            if (command == "")
            {
                MessageBox.Show("请输入指令！");
                return;
            }
            if (fileName == "")
            {
                MessageBox.Show("请选择程序！");
                return;
            }
            LoadConfig writeConfig = new LoadConfig(Application.StartupPath + @"\command.ini");
            String[] commandArray = command.Split('|');
            foreach(String comm in commandArray)
            {
                if (writeConfig.ReadIni("Command List", comm) != "")
                {
                    DialogResult dr = MessageBox.Show("指令已存在，是否覆盖？", "咒语混淆了？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(dr == DialogResult.OK)
                    {
                        writeConfig.IniWriteValue("Command List", comm.Trim(), fileName);
                        this.Close();
                    }
                }
                else
                {
                    writeConfig.IniWriteValue("Command List", comm.Trim(), fileName);
                    this.Close();
                }
            }
        }
    }
}
