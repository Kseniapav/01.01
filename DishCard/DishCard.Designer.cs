namespace DishCard
{
    partial class DishCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureDish = new System.Windows.Forms.PictureBox();
            this.OpisDish = new System.Windows.Forms.Label();
            this.PriceDish = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDish)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureDish
            // 
            this.PictureDish.Location = new System.Drawing.Point(12, 17);
            this.PictureDish.Name = "PictureDish";
            this.PictureDish.Size = new System.Drawing.Size(208, 195);
            this.PictureDish.TabIndex = 0;
            this.PictureDish.TabStop = false;
            // 
            // OpisDish
            // 
            this.OpisDish.AutoSize = true;
            this.OpisDish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpisDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpisDish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpisDish.Location = new System.Drawing.Point(14, 226);
            this.OpisDish.Name = "OpisDish";
            this.OpisDish.Size = new System.Drawing.Size(109, 15);
            this.OpisDish.TabIndex = 1;
            this.OpisDish.Text = "Описание товара";
            // 
            // PriceDish
            // 
            this.PriceDish.AutoSize = true;
            this.PriceDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceDish.Location = new System.Drawing.Point(141, 258);
            this.PriceDish.Name = "PriceDish";
            this.PriceDish.Size = new System.Drawing.Size(77, 16);
            this.PriceDish.TabIndex = 2;
            this.PriceDish.Text = "Стоимость";
            // 
            // DishCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PriceDish);
            this.Controls.Add(this.OpisDish);
            this.Controls.Add(this.PictureDish);
            this.Name = "DishCard";
            this.Size = new System.Drawing.Size(227, 290);
            ((System.ComponentModel.ISupportInitialize)(this.PictureDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureDish;
        private System.Windows.Forms.Label OpisDish;
        private System.Windows.Forms.Label PriceDish;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
