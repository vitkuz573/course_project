﻿namespace course_project
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
            this.components = new System.ComponentModel.Container();
            this.add_carp_button = new System.Windows.Forms.Button();
            this.add_pike_button = new System.Windows.Forms.Button();
            this.aquarium_timer = new System.Windows.Forms.Timer(this.components);
            this.speed_numericupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.speed_numericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // add_carp_button
            // 
            this.add_carp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.add_pike_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_pike_button.Location = new System.Drawing.Point(678, 416);
            this.add_pike_button.Name = "add_pike_button";
            this.add_pike_button.Size = new System.Drawing.Size(110, 23);
            this.add_pike_button.TabIndex = 2;
            this.add_pike_button.Text = "Добавить щуку";
            this.add_pike_button.UseVisualStyleBackColor = true;
            this.add_pike_button.Click += new System.EventHandler(this.Add_pike_button_Click);
            // 
            // aquarium_timer
            // 
            this.aquarium_timer.Tick += new System.EventHandler(this.aquarium_timer_Tick);
            // 
            // speed_numericupdown
            // 
            this.speed_numericupdown.Location = new System.Drawing.Point(466, 416);
            this.speed_numericupdown.Name = "speed_numericupdown";
            this.speed_numericupdown.Size = new System.Drawing.Size(90, 20);
            this.speed_numericupdown.TabIndex = 3;
            this.speed_numericupdown.ValueChanged += new System.EventHandler(this.speed_numericupdown_ValueChanged);
            // 
            // AquariumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speed_numericupdown);
            this.Controls.Add(this.add_pike_button);
            this.Controls.Add(this.add_carp_button);
            this.DoubleBuffered = true;
            this.Name = "AquariumForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аквариум - Кузяев Виталий (ИТЗ-0900021у)";
            ((System.ComponentModel.ISupportInitialize)(this.speed_numericupdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button add_carp_button;
        private System.Windows.Forms.Button add_pike_button;
        private System.Windows.Forms.Timer aquarium_timer;
        private System.Windows.Forms.NumericUpDown speed_numericupdown;
    }
}

