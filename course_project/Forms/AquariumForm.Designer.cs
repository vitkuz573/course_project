namespace CourseProject.Forms
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.addCarpButton = new System.Windows.Forms.Button();
            this.addPikeButton = new System.Windows.Forms.Button();
            this.aquariumTimer = new System.Windows.Forms.Timer(this.components);
            this.aquariumStatus = new System.Windows.Forms.StatusStrip();
            this.carpCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pikeCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.huntingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.huntingCheckBox = new System.Windows.Forms.CheckBox();
            this.aquariumCleanButton = new System.Windows.Forms.Button();
            this.huntingTimer = new System.Windows.Forms.Timer(this.components);
            this.aquariumStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCarpButton
            // 
            this.addCarpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCarpButton.FlatAppearance.BorderSize = 0;
            this.addCarpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarpButton.Location = new System.Drawing.Point(678, 364);
            this.addCarpButton.Name = "addCarpButton";
            this.addCarpButton.Size = new System.Drawing.Size(110, 23);
            this.addCarpButton.TabIndex = 1;
            this.addCarpButton.Text = "Добавить карпа";
            this.addCarpButton.UseVisualStyleBackColor = true;
            this.addCarpButton.Click += new System.EventHandler(this.Add_Carp_Button_Click);
            // 
            // addPikeButton
            // 
            this.addPikeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPikeButton.FlatAppearance.BorderSize = 0;
            this.addPikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPikeButton.Location = new System.Drawing.Point(678, 393);
            this.addPikeButton.Name = "addPikeButton";
            this.addPikeButton.Size = new System.Drawing.Size(110, 23);
            this.addPikeButton.TabIndex = 2;
            this.addPikeButton.Text = "Добавить щуку";
            this.addPikeButton.UseVisualStyleBackColor = true;
            this.addPikeButton.Click += new System.EventHandler(this.Add_Pike_Button_Click);
            // 
            // aquariumTimer
            // 
            this.aquariumTimer.Enabled = true;
            this.aquariumTimer.Tick += new System.EventHandler(this.Aquarium_Timer_Tick);
            // 
            // aquariumStatus
            // 
            this.aquariumStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carpCountLabel,
            this.pikeCountLabel,
            this.huntingStatusLabel});
            this.aquariumStatus.Location = new System.Drawing.Point(0, 428);
            this.aquariumStatus.Name = "aquariumStatus";
            this.aquariumStatus.Size = new System.Drawing.Size(800, 22);
            this.aquariumStatus.TabIndex = 4;
            this.aquariumStatus.Text = "statusStrip1";
            // 
            // carpCountLabel
            // 
            this.carpCountLabel.Name = "carpCountLabel";
            this.carpCountLabel.Size = new System.Drawing.Size(55, 17);
            this.carpCountLabel.Text = "Карпы: 0";
            // 
            // pikeCountLabel
            // 
            this.pikeCountLabel.Name = "pikeCountLabel";
            this.pikeCountLabel.Size = new System.Drawing.Size(50, 17);
            this.pikeCountLabel.Text = "Щуки: 0";
            // 
            // huntingStatusLabel
            // 
            this.huntingStatusLabel.Name = "huntingStatusLabel";
            this.huntingStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.huntingStatusLabel.Text = "Охота: OFF";
            // 
            // huntingCheckBox
            // 
            this.huntingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.huntingCheckBox.AutoSize = true;
            this.huntingCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.huntingCheckBox.Enabled = false;
            this.huntingCheckBox.FlatAppearance.BorderSize = 0;
            this.huntingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huntingCheckBox.Location = new System.Drawing.Point(681, 312);
            this.huntingCheckBox.Name = "huntingCheckBox";
            this.huntingCheckBox.Size = new System.Drawing.Size(53, 17);
            this.huntingCheckBox.TabIndex = 5;
            this.huntingCheckBox.Text = "Охота";
            this.huntingCheckBox.UseVisualStyleBackColor = false;
            this.huntingCheckBox.Visible = false;
            // 
            // aquariumCleanButton
            // 
            this.aquariumCleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aquariumCleanButton.Enabled = false;
            this.aquariumCleanButton.FlatAppearance.BorderSize = 0;
            this.aquariumCleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aquariumCleanButton.Location = new System.Drawing.Point(678, 335);
            this.aquariumCleanButton.Name = "aquariumCleanButton";
            this.aquariumCleanButton.Size = new System.Drawing.Size(110, 23);
            this.aquariumCleanButton.TabIndex = 9;
            this.aquariumCleanButton.Text = "Очистить";
            this.aquariumCleanButton.UseVisualStyleBackColor = true;
            this.aquariumCleanButton.Visible = false;
            this.aquariumCleanButton.Click += new System.EventHandler(this.Aquarium_Clean_Button_Click);
            // 
            // huntingTimer
            // 
            this.huntingTimer.Enabled = true;
            this.huntingTimer.Interval = 1000;
            this.huntingTimer.Tick += new System.EventHandler(this.Hunting_Timer_Tick);
            // 
            // AquariumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aquariumCleanButton);
            this.Controls.Add(this.huntingCheckBox);
            this.Controls.Add(this.aquariumStatus);
            this.Controls.Add(this.addPikeButton);
            this.Controls.Add(this.addCarpButton);
            this.DoubleBuffered = true;
            this.Name = "AquariumForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аквариум - Кузяев Виталий (ИТЗ-0900021у)";
            this.aquariumStatus.ResumeLayout(false);
            this.aquariumStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addCarpButton;
        private System.Windows.Forms.Button addPikeButton;
        private System.Windows.Forms.Timer aquariumTimer;
        private System.Windows.Forms.StatusStrip aquariumStatus;
        private System.Windows.Forms.ToolStripStatusLabel carpCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel pikeCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel huntingStatusLabel;
        private System.Windows.Forms.CheckBox huntingCheckBox;
        private System.Windows.Forms.Button aquariumCleanButton;
        private System.Windows.Forms.Timer huntingTimer;
    }
}

