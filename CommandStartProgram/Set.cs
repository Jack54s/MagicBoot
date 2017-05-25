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
        public Set()
        {
            InitializeComponent();
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

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
