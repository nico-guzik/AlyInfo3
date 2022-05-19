namespace Museum
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.DayLabel = new System.Windows.Forms.Label();
            this.Time10Label = new System.Windows.Forms.Label();
            this.Time12Label = new System.Windows.Forms.Label();
            this.Time18Label = new System.Windows.Forms.Label();
            this.Time15Label = new System.Windows.Forms.Label();
            this.Visitors18Label = new System.Windows.Forms.Label();
            this.Visitors15Label = new System.Windows.Forms.Label();
            this.Visitors12Label = new System.Windows.Forms.Label();
            this.Visitors10Label = new System.Windows.Forms.Label();
            this.DayNumeric = new System.Windows.Forms.NumericUpDown();
            this.Time10Numeric = new System.Windows.Forms.NumericUpDown();
            this.Time12Numeric = new System.Windows.Forms.NumericUpDown();
            this.Time18Numeric = new System.Windows.Forms.NumericUpDown();
            this.Time15Numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time10Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time12Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time18Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time15Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(24, 26);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(32, 16);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "Tag";
            // 
            // Time10Label
            // 
            this.Time10Label.AutoSize = true;
            this.Time10Label.Location = new System.Drawing.Point(24, 62);
            this.Time10Label.Name = "Time10Label";
            this.Time10Label.Size = new System.Drawing.Size(38, 16);
            this.Time10Label.TabIndex = 1;
            this.Time10Label.Text = "10:00";
            // 
            // Time12Label
            // 
            this.Time12Label.AutoSize = true;
            this.Time12Label.Location = new System.Drawing.Point(24, 90);
            this.Time12Label.Name = "Time12Label";
            this.Time12Label.Size = new System.Drawing.Size(38, 16);
            this.Time12Label.TabIndex = 2;
            this.Time12Label.Text = "12:00";
            // 
            // Time18Label
            // 
            this.Time18Label.AutoSize = true;
            this.Time18Label.Location = new System.Drawing.Point(24, 146);
            this.Time18Label.Name = "Time18Label";
            this.Time18Label.Size = new System.Drawing.Size(38, 16);
            this.Time18Label.TabIndex = 4;
            this.Time18Label.Text = "18:00";
            // 
            // Time15Label
            // 
            this.Time15Label.AutoSize = true;
            this.Time15Label.Location = new System.Drawing.Point(24, 118);
            this.Time15Label.Name = "Time15Label";
            this.Time15Label.Size = new System.Drawing.Size(38, 16);
            this.Time15Label.TabIndex = 3;
            this.Time15Label.Text = "15:00";
            // 
            // Visitors18Label
            // 
            this.Visitors18Label.AutoSize = true;
            this.Visitors18Label.Location = new System.Drawing.Point(163, 146);
            this.Visitors18Label.Name = "Visitors18Label";
            this.Visitors18Label.Size = new System.Drawing.Size(0, 16);
            this.Visitors18Label.TabIndex = 8;
            // 
            // Visitors15Label
            // 
            this.Visitors15Label.AutoSize = true;
            this.Visitors15Label.Location = new System.Drawing.Point(163, 118);
            this.Visitors15Label.Name = "Visitors15Label";
            this.Visitors15Label.Size = new System.Drawing.Size(0, 16);
            this.Visitors15Label.TabIndex = 7;
            // 
            // Visitors12Label
            // 
            this.Visitors12Label.AutoSize = true;
            this.Visitors12Label.Location = new System.Drawing.Point(163, 90);
            this.Visitors12Label.Name = "Visitors12Label";
            this.Visitors12Label.Size = new System.Drawing.Size(0, 16);
            this.Visitors12Label.TabIndex = 6;
            // 
            // Visitors10Label
            // 
            this.Visitors10Label.AutoSize = true;
            this.Visitors10Label.Location = new System.Drawing.Point(163, 62);
            this.Visitors10Label.Name = "Visitors10Label";
            this.Visitors10Label.Size = new System.Drawing.Size(0, 16);
            this.Visitors10Label.TabIndex = 5;
            // 
            // DayNumeric
            // 
            this.DayNumeric.Location = new System.Drawing.Point(89, 26);
            this.DayNumeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayNumeric.Name = "DayNumeric";
            this.DayNumeric.Size = new System.Drawing.Size(58, 22);
            this.DayNumeric.TabIndex = 9;
            this.DayNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayNumeric.ValueChanged += new System.EventHandler(this.OnDayChange);
            // 
            // Time10Numeric
            // 
            this.Time10Numeric.Location = new System.Drawing.Point(89, 60);
            this.Time10Numeric.Name = "Time10Numeric";
            this.Time10Numeric.Size = new System.Drawing.Size(58, 22);
            this.Time10Numeric.TabIndex = 10;
            // 
            // Time12Numeric
            // 
            this.Time12Numeric.Location = new System.Drawing.Point(89, 88);
            this.Time12Numeric.Name = "Time12Numeric";
            this.Time12Numeric.Size = new System.Drawing.Size(58, 22);
            this.Time12Numeric.TabIndex = 11;
            // 
            // Time18Numeric
            // 
            this.Time18Numeric.Location = new System.Drawing.Point(89, 144);
            this.Time18Numeric.Name = "Time18Numeric";
            this.Time18Numeric.Size = new System.Drawing.Size(58, 22);
            this.Time18Numeric.TabIndex = 13;
            // 
            // Time15Numeric
            // 
            this.Time15Numeric.Location = new System.Drawing.Point(89, 116);
            this.Time15Numeric.Name = "Time15Numeric";
            this.Time15Numeric.Size = new System.Drawing.Size(58, 22);
            this.Time15Numeric.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Time18Numeric);
            this.Controls.Add(this.Time15Numeric);
            this.Controls.Add(this.Time12Numeric);
            this.Controls.Add(this.Time10Numeric);
            this.Controls.Add(this.DayNumeric);
            this.Controls.Add(this.Visitors18Label);
            this.Controls.Add(this.Visitors15Label);
            this.Controls.Add(this.Visitors12Label);
            this.Controls.Add(this.Visitors10Label);
            this.Controls.Add(this.Time18Label);
            this.Controls.Add(this.Time15Label);
            this.Controls.Add(this.Time12Label);
            this.Controls.Add(this.Time10Label);
            this.Controls.Add(this.DayLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time10Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time12Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time18Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time15Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label Time10Label;
        private System.Windows.Forms.Label Time12Label;
        private System.Windows.Forms.Label Time18Label;
        private System.Windows.Forms.Label Time15Label;
        private System.Windows.Forms.Label Visitors18Label;
        private System.Windows.Forms.Label Visitors15Label;
        private System.Windows.Forms.Label Visitors12Label;
        private System.Windows.Forms.Label Visitors10Label;
        private System.Windows.Forms.NumericUpDown DayNumeric;
        private System.Windows.Forms.NumericUpDown Time10Numeric;
        private System.Windows.Forms.NumericUpDown Time12Numeric;
        private System.Windows.Forms.NumericUpDown Time18Numeric;
        private System.Windows.Forms.NumericUpDown Time15Numeric;
    }
}

