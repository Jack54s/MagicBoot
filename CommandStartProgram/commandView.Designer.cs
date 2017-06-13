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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.commandList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(27, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(56, 27);
            this.Add.TabIndex = 3;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(124, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(55, 27);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // commandList
            // 
            this.commandList.CheckBoxes = true;
            this.commandList.Location = new System.Drawing.Point(12, 45);
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(446, 274);
            this.commandList.TabIndex = 5;
            this.commandList.UseCompatibleStateImageBehavior = false;
            // 
            // commandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.commandList);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "commandView";
            this.Text = "commandView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListView commandList;
    }
}