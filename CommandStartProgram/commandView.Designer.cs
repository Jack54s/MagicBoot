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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "vs", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "F:\\主机编号.txt", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "v", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "F:\\主机编号.txtsdssfafsdfdfsdfsdfsdfsasdfvavcxzvvcxzv", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))))}, -1);
            this.commandList = new System.Windows.Forms.ListView();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // commandList
            // 
            this.commandList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.commandList.CheckBoxes = true;
            this.commandList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.command,
            this.file});
            this.commandList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.commandList.FullRowSelect = true;
            this.commandList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.commandList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.commandList.Location = new System.Drawing.Point(12, 61);
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(458, 258);
            this.commandList.TabIndex = 0;
            this.commandList.UseCompatibleStateImageBehavior = false;
            this.commandList.View = System.Windows.Forms.View.Details;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(23, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(60, 27);
            this.Add.TabIndex = 1;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(111, 22);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(60, 27);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "删除";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // command
            // 
            this.command.Text = "  指令";
            this.command.Width = 120;
            // 
            // file
            // 
            this.file.Text = "  文件";
            this.file.Width = 220;
            // 
            // commandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 331);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.commandList);
            this.Name = "commandView";
            this.Text = "commandView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView commandList;
        private System.Windows.Forms.ColumnHeader command;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
    }
}