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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectProgram = new System.Windows.Forms.Button();
            this.addProgram = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 0;
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
            // selectProgram
            // 
            this.selectProgram.Location = new System.Drawing.Point(6, 32);
            this.selectProgram.Name = "selectProgram";
            this.selectProgram.Size = new System.Drawing.Size(79, 27);
            this.selectProgram.TabIndex = 2;
            this.selectProgram.Text = "启动程序";
            this.selectProgram.UseVisualStyleBackColor = true;
            this.selectProgram.Click += new System.EventHandler(this.selectProgram_Click);
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
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 27);
            this.textBox2.TabIndex = 4;
            // 
            // addCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 92);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.addProgram);
            this.Controls.Add(this.selectProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addCommand";
            this.Text = "创造咒语";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectProgram;
        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.TextBox textBox2;
    }
}