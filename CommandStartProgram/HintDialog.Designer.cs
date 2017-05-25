namespace CommandStartProgram
{
    partial class HintDialog
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
            this.hint = new System.Windows.Forms.Label();
            this.closeHint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(86, 18);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(39, 15);
            this.hint.TabIndex = 0;
            this.hint.Text = "hint";
            // 
            // closeHint
            // 
            this.closeHint.Location = new System.Drawing.Point(69, 46);
            this.closeHint.Name = "closeHint";
            this.closeHint.Size = new System.Drawing.Size(75, 28);
            this.closeHint.TabIndex = 1;
            this.closeHint.Text = "关闭";
            this.closeHint.UseVisualStyleBackColor = true;
            this.closeHint.Click += new System.EventHandler(this.closeHint_Click);
            // 
            // HintDialog
            // 
            this.AcceptButton = this.closeHint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 79);
            this.ControlBox = false;
            this.Controls.Add(this.closeHint);
            this.Controls.Add(this.hint);
            this.Name = "HintDialog";
            this.Text = "Hint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button closeHint;
    }
}