namespace course_project
{
    partial class AquariumForm
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
            this.Aquarium = new System.Windows.Forms.PictureBox();
            this.add_carp_button = new System.Windows.Forms.Button();
            this.add_pike_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Aquarium)).BeginInit();
            this.SuspendLayout();
            // 
            // aquarium_picturebox
            // 
            this.Aquarium.Location = new System.Drawing.Point(12, 12);
            this.Aquarium.Name = "aquarium_picturebox";
            this.Aquarium.Size = new System.Drawing.Size(776, 398);
            this.Aquarium.TabIndex = 0;
            this.Aquarium.TabStop = false;
            // 
            // add_carp_button
            // 
            this.add_carp_button.Location = new System.Drawing.Point(562, 415);
            this.add_carp_button.Name = "add_carp_button";
            this.add_carp_button.Size = new System.Drawing.Size(110, 23);
            this.add_carp_button.TabIndex = 1;
            this.add_carp_button.Text = "Добавить карпа";
            this.add_carp_button.UseVisualStyleBackColor = true;
            this.add_carp_button.Click += new System.EventHandler(this.Add_carp_button_Click);
            // 
            // add_pike_button
            // 
            this.add_pike_button.Location = new System.Drawing.Point(678, 416);
            this.add_pike_button.Name = "add_pike_button";
            this.add_pike_button.Size = new System.Drawing.Size(110, 23);
            this.add_pike_button.TabIndex = 2;
            this.add_pike_button.Text = "Добавить щуку";
            this.add_pike_button.UseVisualStyleBackColor = true;
            this.add_pike_button.Click += new System.EventHandler(this.Add_pike_button_Click);
            // 
            // AquariumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_pike_button);
            this.Controls.Add(this.add_carp_button);
            this.Controls.Add(this.Aquarium);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AquariumForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аквариум - Кузяев Виталий (ИТЗ-0900021у)";
            this.Load += new System.EventHandler(this.AquariumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Aquarium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_carp_button;
        private System.Windows.Forms.Button add_pike_button;
    }
}

