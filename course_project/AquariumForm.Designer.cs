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
            this.components = new System.ComponentModel.Container();
            this.add_carp_button = new System.Windows.Forms.Button();
            this.add_pike_button = new System.Windows.Forms.Button();
            this.aquarium_timer = new System.Windows.Forms.Timer(this.components);
            this.pike_speed_numericupdown = new System.Windows.Forms.NumericUpDown();
            this.aquarium_status = new System.Windows.Forms.StatusStrip();
            this.carp_count_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.pike_count_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.hunting_status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.hunting_checkbox = new System.Windows.Forms.CheckBox();
            this.carp_speed_numericupdown = new System.Windows.Forms.NumericUpDown();
            this.carp_speed_label = new System.Windows.Forms.Label();
            this.pike_speed_label = new System.Windows.Forms.Label();
            this.aquarium_clean_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pike_speed_numericupdown)).BeginInit();
            this.aquarium_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carp_speed_numericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // add_carp_button
            // 
            this.add_carp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_carp_button.Location = new System.Drawing.Point(678, 364);
            this.add_carp_button.Name = "add_carp_button";
            this.add_carp_button.Size = new System.Drawing.Size(110, 23);
            this.add_carp_button.TabIndex = 1;
            this.add_carp_button.Text = "Добавить карпа";
            this.add_carp_button.UseVisualStyleBackColor = true;
            this.add_carp_button.Click += new System.EventHandler(this.Add_Carp_Button_Click);
            // 
            // add_pike_button
            // 
            this.add_pike_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_pike_button.Location = new System.Drawing.Point(678, 393);
            this.add_pike_button.Name = "add_pike_button";
            this.add_pike_button.Size = new System.Drawing.Size(110, 23);
            this.add_pike_button.TabIndex = 2;
            this.add_pike_button.Text = "Добавить щуку";
            this.add_pike_button.UseVisualStyleBackColor = true;
            this.add_pike_button.Click += new System.EventHandler(this.Add_Pike_Button_Click);
            // 
            // aquarium_timer
            // 
            this.aquarium_timer.Tick += new System.EventHandler(this.Aquarium_timer_Tick);
            // 
            // pike_speed_numericupdown
            // 
            this.pike_speed_numericupdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pike_speed_numericupdown.Location = new System.Drawing.Point(582, 393);
            this.pike_speed_numericupdown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pike_speed_numericupdown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pike_speed_numericupdown.Name = "pike_speed_numericupdown";
            this.pike_speed_numericupdown.Size = new System.Drawing.Size(90, 20);
            this.pike_speed_numericupdown.TabIndex = 3;
            this.pike_speed_numericupdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pike_speed_numericupdown.ValueChanged += new System.EventHandler(this.Pike_Speed_NumericUpDown_ValueChanged);
            // 
            // aquarium_status
            // 
            this.aquarium_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carp_count_label,
            this.pike_count_label,
            this.hunting_status_label});
            this.aquarium_status.Location = new System.Drawing.Point(0, 428);
            this.aquarium_status.Name = "aquarium_status";
            this.aquarium_status.Size = new System.Drawing.Size(800, 22);
            this.aquarium_status.TabIndex = 4;
            this.aquarium_status.Text = "statusStrip1";
            // 
            // carp_count_label
            // 
            this.carp_count_label.Name = "carp_count_label";
            this.carp_count_label.Size = new System.Drawing.Size(55, 17);
            this.carp_count_label.Text = "Карпы: 0";
            // 
            // pike_count_label
            // 
            this.pike_count_label.Name = "pike_count_label";
            this.pike_count_label.Size = new System.Drawing.Size(50, 17);
            this.pike_count_label.Text = "Щуки: 0";
            // 
            // hunting_status_label
            // 
            this.hunting_status_label.Name = "hunting_status_label";
            this.hunting_status_label.Size = new System.Drawing.Size(67, 17);
            this.hunting_status_label.Text = "Охота: OFF";
            // 
            // hunting_checkbox
            // 
            this.hunting_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hunting_checkbox.AutoSize = true;
            this.hunting_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.hunting_checkbox.Enabled = false;
            this.hunting_checkbox.Location = new System.Drawing.Point(582, 339);
            this.hunting_checkbox.Name = "hunting_checkbox";
            this.hunting_checkbox.Size = new System.Drawing.Size(56, 17);
            this.hunting_checkbox.TabIndex = 5;
            this.hunting_checkbox.Text = "Охота";
            this.hunting_checkbox.UseVisualStyleBackColor = false;
            // 
            // carp_speed_numericupdown
            // 
            this.carp_speed_numericupdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.carp_speed_numericupdown.Location = new System.Drawing.Point(582, 367);
            this.carp_speed_numericupdown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.carp_speed_numericupdown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.carp_speed_numericupdown.Name = "carp_speed_numericupdown";
            this.carp_speed_numericupdown.Size = new System.Drawing.Size(90, 20);
            this.carp_speed_numericupdown.TabIndex = 6;
            this.carp_speed_numericupdown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.carp_speed_numericupdown.ValueChanged += new System.EventHandler(this.Carp_Speed_NumericUpDown_ValueChanged);
            // 
            // carp_speed_label
            // 
            this.carp_speed_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.carp_speed_label.AutoSize = true;
            this.carp_speed_label.BackColor = System.Drawing.Color.Transparent;
            this.carp_speed_label.Location = new System.Drawing.Point(518, 369);
            this.carp_speed_label.Name = "carp_speed_label";
            this.carp_speed_label.Size = new System.Drawing.Size(58, 13);
            this.carp_speed_label.TabIndex = 7;
            this.carp_speed_label.Text = "Скорость:";
            // 
            // pike_speed_label
            // 
            this.pike_speed_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pike_speed_label.AutoSize = true;
            this.pike_speed_label.BackColor = System.Drawing.Color.Transparent;
            this.pike_speed_label.Location = new System.Drawing.Point(518, 395);
            this.pike_speed_label.Name = "pike_speed_label";
            this.pike_speed_label.Size = new System.Drawing.Size(58, 13);
            this.pike_speed_label.TabIndex = 8;
            this.pike_speed_label.Text = "Скорость:";
            // 
            // aquarium_clean_button
            // 
            this.aquarium_clean_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aquarium_clean_button.Location = new System.Drawing.Point(678, 335);
            this.aquarium_clean_button.Name = "aquarium_clean_button";
            this.aquarium_clean_button.Size = new System.Drawing.Size(110, 23);
            this.aquarium_clean_button.TabIndex = 9;
            this.aquarium_clean_button.Text = "Очистить";
            this.aquarium_clean_button.UseVisualStyleBackColor = true;
            this.aquarium_clean_button.Click += new System.EventHandler(this.Aquarium_Clean_Button_Click);
            // 
            // AquariumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aquarium_clean_button);
            this.Controls.Add(this.pike_speed_label);
            this.Controls.Add(this.carp_speed_label);
            this.Controls.Add(this.carp_speed_numericupdown);
            this.Controls.Add(this.hunting_checkbox);
            this.Controls.Add(this.aquarium_status);
            this.Controls.Add(this.pike_speed_numericupdown);
            this.Controls.Add(this.add_pike_button);
            this.Controls.Add(this.add_carp_button);
            this.DoubleBuffered = true;
            this.Name = "AquariumForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аквариум - Кузяев Виталий (ИТЗ-0900021у)";
            ((System.ComponentModel.ISupportInitialize)(this.pike_speed_numericupdown)).EndInit();
            this.aquarium_status.ResumeLayout(false);
            this.aquarium_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carp_speed_numericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_carp_button;
        private System.Windows.Forms.Button add_pike_button;
        private System.Windows.Forms.Timer aquarium_timer;
        private System.Windows.Forms.NumericUpDown pike_speed_numericupdown;
        private System.Windows.Forms.StatusStrip aquarium_status;
        private System.Windows.Forms.ToolStripStatusLabel carp_count_label;
        private System.Windows.Forms.ToolStripStatusLabel pike_count_label;
        private System.Windows.Forms.ToolStripStatusLabel hunting_status_label;
        private System.Windows.Forms.CheckBox hunting_checkbox;
        private System.Windows.Forms.NumericUpDown carp_speed_numericupdown;
        private System.Windows.Forms.Label carp_speed_label;
        private System.Windows.Forms.Label pike_speed_label;
        private System.Windows.Forms.Button aquarium_clean_button;
    }
}

