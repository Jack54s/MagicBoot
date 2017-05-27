using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandStartProgram
{
    public partial class Set : Form
    {
        private bool Ctrl = false;
        private bool Shift = false;
        private bool Alt = false;
        private String keyCode = "";
        LoadConfig config;

        public Set()
        {
            InitializeComponent();
            config = new LoadConfig(Application.StartupPath + @"\command.ini");
            InitComponent();
        }

        /// <summary>
        /// 初始化设置参数
        /// </summary>
        public void InitComponent()
        {
            String checkBoxStatus = config.ReadIni("Set", "run");
            String k = config.ReadIni("Set", "KeyCode");
            if (checkBoxStatus == "True")
            {
                startWithBoot.Checked = true;
            }
            else
            {
                startWithBoot.Checked = false;
            }
            String hotKey = "";
            if (config.ReadIni("Set", "Ctrl") == "True")
            {
                hotKey += "Ctrl+";
            }
            if (config.ReadIni("Set", "Alt") == "True")
            {
                hotKey += "Alt+";
            }
            if (config.ReadIni("Set", "Shift") == "True")
            {
                hotKey += "Shift+";
            }
            if (k != "")
            {
                hotKey += k;
            }
            HotKeyText.Text = hotKey;
        }
        /// <summary>
        /// 添加命令按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCommand_Click(object sender, EventArgs e)
        {
            addCommand ac = new addCommand();
            ac.Show();
        }

        /// <summary>
        /// 确定按钮关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Apply_Click(sender, e);
            this.Close();
        }

        private void HotKeyText_KeyDown(object sender, KeyEventArgs e)
        {
            String hotKey = "";
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                    Ctrl = true;
                    break;
                case Keys.ShiftKey:
                    Shift = true;
                    break;
                case Keys.Menu:
                    Alt = true;
                    break;
                default:
                    keyCode = e.KeyCode.ToString();
                    break;
            }
            hotKey += Ctrl ? "Ctrl+" : "";
            hotKey += Shift ? "Shift+" : "";
            hotKey += Alt ? "Alt+" : "";
            hotKey += keyCode;
            if(keyCode == "")
            {
                hotKey = "";
            }
            if(e.KeyCode == Keys.Back)
            {
                hotKey = "";
                keyCode = "";
            }
            HotKeyText.Text = hotKey;
        }

        private void HotKeyText_KeyUp(object sender, KeyEventArgs e)
        {
            Ctrl = false;
            Shift = false;
            Alt = false;
            keyCode = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            config.IniWriteValue("Set", "run", startWithBoot.Checked.ToString());
            String hotKey = HotKeyText.Text;
            if (hotKey.Contains("Ctrl"))
            {
                config.IniWriteValue("Set", "Ctrl", "True");
            }
            else
            {
                config.IniWriteValue("Set", "Ctrl", "False");
            }
            if (hotKey.Contains("Shift"))
            {
                config.IniWriteValue("Set", "Shift", "True");
            }
            else
            {
                config.IniWriteValue("Set", "Shift", "False");
            }
            if (hotKey.Contains("Alt"))
            {
                config.IniWriteValue("Set", "Alt", "True");
            }
            else
            {
                config.IniWriteValue("Set", "Alt", "False");
            }
            if ((keyCode = config.ReadIni("Set", "KeyCode")) == "" || !(hotKey.Substring(hotKey.LastIndexOf('+'))).Equals(keyCode))
            {
                try
                {
                    String key = hotKey.Substring(hotKey.LastIndexOf('+') + 1);
                    key = ((Keys)Enum.Parse(typeof(Keys), key)).ToString();
                    config.IniWriteValue("Set", "KeyCode", key);
                }
                catch (ArgumentException excp)
                {
                    MessageBox.Show(excp.Message);
                }
            }
            InitComponent();
        }
    }
}

