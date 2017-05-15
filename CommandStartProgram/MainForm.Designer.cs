namespace CommandStartProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.command = new System.Windows.Forms.TextBox();
            this.addCommand = new System.Windows.Forms.Button();
            this.startWithBoot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(2, 4);
            this.command.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(290, 27);
            this.command.TabIndex = 0;
            // 
            // addCommand
            // 
            this.addCommand.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addCommand.Location = new System.Drawing.Point(35, 30);
            this.addCommand.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.addCommand.Name = "addCommand";
            this.addCommand.Size = new System.Drawing.Size(83, 25);
            this.addCommand.TabIndex = 1;
            this.addCommand.Text = "添加命令";
            this.addCommand.UseVisualStyleBackColor = true;
            // 
            // startWithBoot
            // 
            this.startWithBoot.AutoSize = true;
            this.startWithBoot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startWithBoot.Location = new System.Drawing.Point(171, 33);
            this.startWithBoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startWithBoot.Name = "startWithBoot";
            this.startWithBoot.Size = new System.Drawing.Size(91, 24);
            this.startWithBoot.TabIndex = 2;
            this.startWithBoot.Text = "开机启动";
            this.startWithBoot.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(293, 57);
            this.Controls.Add(this.startWithBoot);
            this.Controls.Add(this.addCommand);
            this.Controls.Add(this.command);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "魔法师咒语";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button addCommand;
        private System.Windows.Forms.CheckBox startWithBoot;
    }
}

