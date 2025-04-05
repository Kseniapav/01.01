namespace Functions
{
    partial class AddDishForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.NameDictionary = new System.Windows.Forms.Label();
            this.dishCard1 = new DishCard.DishCard();
            this.dishCard2 = new DishCard.DishCard();
            this.dishCard3 = new DishCard.DishCard();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Controls.Add(this.dishCard1);
            this.flowLayoutPanel1.Controls.Add(this.dishCard2);
            this.flowLayoutPanel1.Controls.Add(this.dishCard3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(321, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 593);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // NameDictionary
            // 
            this.NameDictionary.AutoSize = true;
            this.NameDictionary.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDictionary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameDictionary.Location = new System.Drawing.Point(12, 33);
            this.NameDictionary.Name = "NameDictionary";
            this.NameDictionary.Size = new System.Drawing.Size(296, 33);
            this.NameDictionary.TabIndex = 1;
            this.NameDictionary.Text = "Выберите категорию:";
            // 
            // dishCard1
            // 
            this.dishCard1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dishCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dishCard1.Location = new System.Drawing.Point(3, 3);
            this.dishCard1.Name = "dishCard1";
            this.dishCard1.Size = new System.Drawing.Size(227, 290);
            this.dishCard1.TabIndex = 0;
            // 
            // dishCard2
            // 
            this.dishCard2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dishCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dishCard2.Location = new System.Drawing.Point(236, 3);
            this.dishCard2.Name = "dishCard2";
            this.dishCard2.Size = new System.Drawing.Size(227, 290);
            this.dishCard2.TabIndex = 1;
            // 
            // dishCard3
            // 
            this.dishCard3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dishCard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dishCard3.Location = new System.Drawing.Point(469, 3);
            this.dishCard3.Name = "dishCard3";
            this.dishCard3.Size = new System.Drawing.Size(227, 290);
            this.dishCard3.TabIndex = 2;
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1023, 635);
            this.Controls.Add(this.NameDictionary);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddDishForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label NameDictionary;
        private DishCard.DishCard dishCard1;
        private DishCard.DishCard dishCard2;
        private DishCard.DishCard dishCard3;
    }
}

