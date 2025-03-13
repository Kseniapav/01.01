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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MyTreeView = new System.Windows.Forms.TreeView();
            this.dataGridViewDishInfo = new System.Windows.Forms.DataGridView();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortionWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // MyTreeView
            // 
            this.MyTreeView.Location = new System.Drawing.Point(12, 12);
            this.MyTreeView.Name = "MyTreeView";
            this.MyTreeView.Size = new System.Drawing.Size(221, 251);
            this.MyTreeView.TabIndex = 0;
            this.MyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridViewDishInfo
            // 
            this.dataGridViewDishInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDishInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDishInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DishName,
            this.Price,
            this.Description,
            this.Ingredients,
            this.PortionWeight});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDishInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDishInfo.Location = new System.Drawing.Point(250, 12);
            this.dataGridViewDishInfo.Name = "dataGridViewDishInfo";
            this.dataGridViewDishInfo.Size = new System.Drawing.Size(544, 351);
            this.dataGridViewDishInfo.TabIndex = 2;
            this.dataGridViewDishInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDishInfo_CellContentClick);
            // 
            // DishName
            // 
            this.DishName.HeaderText = "Блюда";
            this.DishName.Name = "DishName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // Ingredients
            // 
            this.Ingredients.HeaderText = "Состав";
            this.Ingredients.Name = "Ingredients";
            // 
            // PortionWeight
            // 
            this.PortionWeight.HeaderText = "Вес порции";
            this.PortionWeight.Name = "PortionWeight";
            // 
            // treeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 550);
            this.Controls.Add(this.dataGridViewDishInfo);
            this.Controls.Add(this.MyTreeView);
            this.Name = "treeView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.treeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView MyTreeView;
        private System.Windows.Forms.DataGridView dataGridViewDishInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortionWeight;
    }
}