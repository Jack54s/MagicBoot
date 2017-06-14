namespace MagicBoot
{
    partial class commandView
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
            this.commandContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.allin = new System.Windows.Forms.CheckBox();
            this.command = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.commandContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandContainer
            // 
            this.commandContainer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.commandContainer.ColumnCount = 2;
            this.commandContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21834F));
            this.commandContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78166F));
            this.commandContainer.Controls.Add(this.label1, 1, 0);
            this.commandContainer.Controls.Add(this.splitContainer1, 0, 0);
            this.commandContainer.Controls.Add(this.checkedListBox1, 0, 1);
            this.commandContainer.Location = new System.Drawing.Point(12, 53);
            this.commandContainer.Name = "commandContainer";
            this.commandContainer.RowCount = 2;
            this.commandContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.03008F));
            this.commandContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.96992F));
            this.commandContainer.Size = new System.Drawing.Size(458, 266);
            this.commandContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.allin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.command);
            this.splitContainer1.Size = new System.Drawing.Size(204, 25);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 2;
            // 
            // allin
            // 
            this.allin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allin.AutoSize = true;
            this.allin.Location = new System.Drawing.Point(4, 3);
            this.allin.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.allin.Name = "allin";
            this.allin.Size = new System.Drawing.Size(59, 19);
            this.allin.TabIndex = 1;
            this.allin.Text = "全选";
            this.allin.UseVisualStyleBackColor = true;
            // 
            // command
            // 
            this.command.AutoSize = true;
            this.command.Location = new System.Drawing.Point(26, 5);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(37, 15);
            this.command.TabIndex = 0;
            this.command.Text = "指令";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            " v",
            " vs",
            " s"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 34);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(224, 224);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // commandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 331);
            this.Controls.Add(this.commandContainer);
            this.Name = "commandView";
            this.Text = "commandView";
            this.Load += new System.EventHandler(this.commandView_Load);
            this.commandContainer.ResumeLayout(false);
            this.commandContainer.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel commandContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox allin;
        private System.Windows.Forms.Label command;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}