namespace CommandStartProgram
{
    partial class addCommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCommand));
            this.Command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProgram = new System.Windows.Forms.Button();
            this.labelRunProgram = new System.Windows.Forms.Label();
            this.selectProgram = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Command.Location = new System.Drawing.Point(88, 6);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(269, 27);
            this.Command.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "启动指令:";
            // 
            // addProgram
            // 
            this.addProgram.Location = new System.Drawing.Point(140, 62);
            this.addProgram.Margin = new System.Windows.Forms.Padding(0);
            this.addProgram.Name = "addProgram";
            this.addProgram.Size = new System.Drawing.Size(65, 28);
            this.addProgram.TabIndex = 3;
            this.addProgram.Text = "添加";
            this.addProgram.UseVisualStyleBackColor = true;
            this.addProgram.Click += new System.EventHandler(this.addProgram_Click);
            // 
            // labelRunProgram
            // 
            this.labelRunProgram.AutoSize = true;
            this.labelRunProgram.Location = new System.Drawing.Point(12, 36);
            this.labelRunProgram.Name = "labelRunProgram";
            this.labelRunProgram.Size = new System.Drawing.Size(81, 20);
            this.labelRunProgram.TabIndex = 4;
            this.labelRunProgram.Text = "启动程序:  ";
            // 
            // selectProgram
            // 
            this.selectProgram.AutoSize = true;
            this.selectProgram.BackColor = System.Drawing.SystemColors.Control;
            this.selectProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectProgram.Location = new System.Drawing.Point(88, 36);
            this.selectProgram.Name = "selectProgram";
            this.selectProgram.Size = new System.Drawing.Size(71, 22);
            this.selectProgram.TabIndex = 5;
            this.selectProgram.Text = "选择程序";
            this.selectProgram.Click += new System.EventHandler(this.selectProgram_Click);
            // 
            // addCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 92);
            this.Controls.Add(this.selectProgram);
            this.Controls.Add(this.labelRunProgram);
            this.Controls.Add(this.addProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Command);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addCommand";
            this.Text = "真知奥秘，唯我知晓！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.Label labelRunProgram;
        private System.Windows.Forms.Label selectProgram;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}