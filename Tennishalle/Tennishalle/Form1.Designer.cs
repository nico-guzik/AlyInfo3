namespace Tennishalle
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
            this.tagLabel = new System.Windows.Forms.Label();
            this.tagNumeric = new System.Windows.Forms.NumericUpDown();
            this.buchungLabel = new System.Windows.Forms.Label();
            this.reservierungenDataGrid = new System.Windows.Forms.DataGridView();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.eintragenButton = new System.Windows.Forms.Button();
            this.löschenButton = new System.Windows.Forms.Button();
            this.Stunde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platz1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platz2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platz3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tagNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(13, 13);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(35, 16);
            this.tagLabel.TabIndex = 0;
            this.tagLabel.Text = "Tag:";
            // 
            // tagNumeric
            // 
            this.tagNumeric.Location = new System.Drawing.Point(79, 11);
            this.tagNumeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tagNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tagNumeric.Name = "tagNumeric";
            this.tagNumeric.Size = new System.Drawing.Size(56, 22);
            this.tagNumeric.TabIndex = 1;
            this.tagNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tagNumeric.ValueChanged += new System.EventHandler(this.tagNumeric_ValueChanged);
            // 
            // buchungLabel
            // 
            this.buchungLabel.AutoSize = true;
            this.buchungLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchungLabel.Location = new System.Drawing.Point(633, 12);
            this.buchungLabel.Name = "buchungLabel";
            this.buchungLabel.Size = new System.Drawing.Size(68, 17);
            this.buchungLabel.TabIndex = 2;
            this.buchungLabel.Text = "Buchung:";
            // 
            // reservierungenDataGrid
            // 
            this.reservierungenDataGrid.AllowUserToAddRows = false;
            this.reservierungenDataGrid.AllowUserToDeleteRows = false;
            this.reservierungenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservierungenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stunde,
            this.Platz1,
            this.Platz2,
            this.Platz3});
            this.reservierungenDataGrid.Location = new System.Drawing.Point(13, 48);
            this.reservierungenDataGrid.Name = "reservierungenDataGrid";
            this.reservierungenDataGrid.ReadOnly = true;
            this.reservierungenDataGrid.RowHeadersVisible = false;
            this.reservierungenDataGrid.RowHeadersWidth = 51;
            this.reservierungenDataGrid.RowTemplate.Height = 24;
            this.reservierungenDataGrid.Size = new System.Drawing.Size(563, 523);
            this.reservierungenDataGrid.TabIndex = 3;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(636, 48);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 22);
            this.nameTextbox.TabIndex = 4;
            // 
            // eintragenButton
            // 
            this.eintragenButton.Location = new System.Drawing.Point(636, 93);
            this.eintragenButton.Name = "eintragenButton";
            this.eintragenButton.Size = new System.Drawing.Size(75, 23);
            this.eintragenButton.TabIndex = 5;
            this.eintragenButton.Text = "Eintragen";
            this.eintragenButton.UseVisualStyleBackColor = true;
            this.eintragenButton.Click += new System.EventHandler(this.eintragenButton_Click);
            // 
            // löschenButton
            // 
            this.löschenButton.Location = new System.Drawing.Point(636, 548);
            this.löschenButton.Name = "löschenButton";
            this.löschenButton.Size = new System.Drawing.Size(75, 23);
            this.löschenButton.TabIndex = 6;
            this.löschenButton.Text = "Löschen";
            this.löschenButton.UseVisualStyleBackColor = true;
            this.löschenButton.Click += new System.EventHandler(this.löschenButton_Click);
            // 
            // Stunde
            // 
            this.Stunde.HeaderText = "Std";
            this.Stunde.MinimumWidth = 6;
            this.Stunde.Name = "Stunde";
            this.Stunde.ReadOnly = true;
            this.Stunde.Width = 50;
            // 
            // Platz1
            // 
            this.Platz1.HeaderText = "Platz 1";
            this.Platz1.MinimumWidth = 6;
            this.Platz1.Name = "Platz1";
            this.Platz1.ReadOnly = true;
            this.Platz1.Width = 125;
            // 
            // Platz2
            // 
            this.Platz2.HeaderText = "Platz 2";
            this.Platz2.MinimumWidth = 6;
            this.Platz2.Name = "Platz2";
            this.Platz2.ReadOnly = true;
            this.Platz2.Width = 125;
            // 
            // Platz3
            // 
            this.Platz3.HeaderText = "Platz 3";
            this.Platz3.MinimumWidth = 6;
            this.Platz3.Name = "Platz3";
            this.Platz3.ReadOnly = true;
            this.Platz3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.löschenButton);
            this.Controls.Add(this.eintragenButton);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.reservierungenDataGrid);
            this.Controls.Add(this.buchungLabel);
            this.Controls.Add(this.tagNumeric);
            this.Controls.Add(this.tagLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tagNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungenDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.NumericUpDown tagNumeric;
        private System.Windows.Forms.Label buchungLabel;
        private System.Windows.Forms.DataGridView reservierungenDataGrid;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button eintragenButton;
        private System.Windows.Forms.Button löschenButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platz1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platz3;
    }
}

