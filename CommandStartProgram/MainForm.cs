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

namespace CommandStartProgram
{
    public partial class MainForm : Form
    {
        String appName = "MagicBoot";
        LoadConfig config;

        public MainForm()
        {
            InitializeComponent();
            config = new LoadConfig(Application.StartupPath + @"\command.ini");
        }

        /// <summary>
        /// 菜单退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuExit(object sender, EventArgs e)
        {
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

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void Set_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            set.Show();
        }

        private void command_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
