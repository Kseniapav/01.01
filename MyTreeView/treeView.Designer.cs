namespace MyTreeView
{
    partial class treeView
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
            this.MyTreeView = new System.Windows.Forms.TreeView();
            this.richTextBoxDishInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MyTreeView
            // 
            this.MyTreeView.Location = new System.Drawing.Point(12, 12);
            this.MyTreeView.Name = "MyTreeView";
            this.MyTreeView.Size = new System.Drawing.Size(272, 251);
            this.MyTreeView.TabIndex = 0;
            this.MyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // richTextBoxDishInfo
            // 
            this.richTextBoxDishInfo.Location = new System.Drawing.Point(304, 22);
            this.richTextBoxDishInfo.Name = "richTextBoxDishInfo";
            this.richTextBoxDishInfo.Size = new System.Drawing.Size(381, 128);
            this.richTextBoxDishInfo.TabIndex = 1;
            this.richTextBoxDishInfo.Text = "";
            // 
            // treeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 290);
            this.Controls.Add(this.richTextBoxDishInfo);
            this.Controls.Add(this.MyTreeView);
            this.Name = "treeView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.treeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView MyTreeView;
        private System.Windows.Forms.RichTextBox richTextBoxDishInfo;
    }
}