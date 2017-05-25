using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace CommandStartProgram
{
    public partial class MainForm : Form
    {
        String appName = "MagicBoot";
        LoadConfig config;
        HintDialog hi;  //提示框

        public MainForm()
        {
            InitializeComponent();
            config = new LoadConfig(Application.StartupPath + @"\command.ini");
            hi = new HintDialog();
        }

        /// <summary>
        /// 菜单退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuExit(object sender, EventArgs e)
        {
            hi.Close();
            Application.Exit();
        }

        /// <summary>
        /// 托盘图标左击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Console_MouseDown(object sender, EventArgs e)
        {
            MouseEventArgs Mouse_e = (MouseEventArgs) e;
            if (Mouse_e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        /// <summary>
        /// 托盘图标显示按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Console_Display(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 改变窗口关闭按钮的行为
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        /// <summary>
        /// 托盘设置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Set_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            set.Show();
        }

        /// <summary>
        /// 主窗口textBox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void command_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String comtxt = command.Text;
                String fileName = config.ReadIni("Command List", comtxt);

                if (fileName != "")
                {
                    if (File.Exists(fileName))
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                    else
                    {
                        hi.setHint("文件“" + fileName + "”不存在！");
                        hi.Show();
                    }
                }
                else
                {
                    hi.setHint("记忆有误！");
                    hi.Show();
                }
            }
        }
    }
}
