using System;
using System.Windows.Forms;

namespace CommandStartProgram
{
    public partial class addCommand : Form
    {
        HintDialog hi;  //提示框

        public addCommand()
        {
            InitializeComponent();
            hi = new HintDialog();
        }

        /// <summary>
        /// 选择程序label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 添加命令按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProgram_Click(object sender, EventArgs e)
        {
            String command = Command.Text;
            String fileName = openFileDialog1.FileName;
            if (command.Trim() == "")
            {
                hi.setHint("请输入指令！");
                hi.Show();
                return;
            }
            if (fileName == "")
            {
                hi.setHint("请选择程序！");
                hi.Show();
                return;
            }
            LoadConfig writeConfig = new LoadConfig(Application.StartupPath + @"\command.ini");
            String[] commandArray = command.Split('|');
            foreach(String comm in commandArray)
            {
                if(comm.Trim() == "")
                {
                    break;
                }
                if (writeConfig.ReadIni("Command List", comm) != "")
                {
                    DialogResult dr = MessageBox.Show("指令已存在，是否覆盖？", "咒语记混了吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(dr == DialogResult.OK)
                    {
                        writeConfig.IniWriteValue("Command List", comm.Trim(), fileName);
                        hi.Close();
                        this.Close();
                    }
                }
                else
                {
                    writeConfig.IniWriteValue("Command List", comm.Trim(), fileName);
                    hi.Close();
                    this.Close();
                }
            }
        }
    }
}
