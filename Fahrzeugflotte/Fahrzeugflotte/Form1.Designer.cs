namespace Fahrzeugflotte
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
            this.fahrzeugeDataGrid = new System.Windows.Forms.DataGridView();
            this.Kennzeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jahr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neuesFahrzeug = new System.Windows.Forms.Label();
            this.kennzeichenLabel = new System.Windows.Forms.Label();
            this.herstellerLabel = new System.Windows.Forms.Label();
            this.modellLabel = new System.Windows.Forms.Label();
            this.jahrLabel = new System.Windows.Forms.Label();
            this.leistungLabel = new System.Windows.Forms.Label();
            this.löschenButton = new System.Windows.Forms.Button();
            this.anlegenButton = new System.Windows.Forms.Button();
            this.kennzeichenTextbox = new System.Windows.Forms.TextBox();
            this.modellTextbox = new System.Windows.Forms.TextBox();
            this.jahrNumeric = new System.Windows.Forms.NumericUpDown();
            this.leistungNumeric = new System.Windows.Forms.NumericUpDown();
            this.herstellerCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jahrNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leistungNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // fahrzeugeDataGrid
            // 
            this.fahrzeugeDataGrid.AllowUserToAddRows = false;
            this.fahrzeugeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fahrzeugeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fahrzeugeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kennzeichen,
            this.Hersteller,
            this.Modell,
            this.Jahr,
            this.kW});
            this.fahrzeugeDataGrid.Location = new System.Drawing.Point(12, 12);
            this.fahrzeugeDataGrid.Name = "fahrzeugeDataGrid";
            this.fahrzeugeDataGrid.RowHeadersWidth = 51;
            this.fahrzeugeDataGrid.RowTemplate.Height = 24;
            this.fahrzeugeDataGrid.Size = new System.Drawing.Size(635, 258);
            this.fahrzeugeDataGrid.TabIndex = 0;
            // 
            // Kennzeichen
            // 
            this.Kennzeichen.HeaderText = "Kennzeichen";
            this.Kennzeichen.MinimumWidth = 6;
            this.Kennzeichen.Name = "Kennzeichen";
            this.Kennzeichen.Width = 112;
            // 
            // Hersteller
            // 
            this.Hersteller.HeaderText = "Hersteller";
            this.Hersteller.MinimumWidth = 6;
            this.Hersteller.Name = "Hersteller";
            this.Hersteller.Width = 94;
            // 
            // Modell
            // 
            this.Modell.HeaderText = "Modell";
            this.Modell.MinimumWidth = 6;
            this.Modell.Name = "Modell";
            this.Modell.Width = 77;
            // 
            // Jahr
            // 
            this.Jahr.HeaderText = "Jahr";
            this.Jahr.MinimumWidth = 6;
            this.Jahr.Name = "Jahr";
            this.Jahr.Width = 62;
            // 
            // kW
            // 
            this.kW.HeaderText = "kW";
            this.kW.MinimumWidth = 6;
            this.kW.Name = "kW";
            this.kW.Width = 56;
            // 
            // neuesFahrzeug
            // 
            this.neuesFahrzeug.AutoSize = true;
            this.neuesFahrzeug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuesFahrzeug.Location = new System.Drawing.Point(12, 319);
            this.neuesFahrzeug.Name = "neuesFahrzeug";
            this.neuesFahrzeug.Size = new System.Drawing.Size(178, 25);
            this.neuesFahrzeug.TabIndex = 1;
            this.neuesFahrzeug.Text = "Neues Fahrzeug:";
            // 
            // kennzeichenLabel
            // 
            this.kennzeichenLabel.AutoSize = true;
            this.kennzeichenLabel.Location = new System.Drawing.Point(20, 353);
            this.kennzeichenLabel.Name = "kennzeichenLabel";
            this.kennzeichenLabel.Size = new System.Drawing.Size(86, 16);
            this.kennzeichenLabel.TabIndex = 2;
            this.kennzeichenLabel.Text = "Kennzeichen:";
            // 
            // herstellerLabel
            // 
            this.herstellerLabel.AutoSize = true;
            this.herstellerLabel.Location = new System.Drawing.Point(20, 383);
            this.herstellerLabel.Name = "herstellerLabel";
            this.herstellerLabel.Size = new System.Drawing.Size(68, 16);
            this.herstellerLabel.TabIndex = 3;
            this.herstellerLabel.Text = "Hersteller:";
            // 
            // modellLabel
            // 
            this.modellLabel.AutoSize = true;
            this.modellLabel.Location = new System.Drawing.Point(20, 413);
            this.modellLabel.Name = "modellLabel";
            this.modellLabel.Size = new System.Drawing.Size(51, 16);
            this.modellLabel.TabIndex = 4;
            this.modellLabel.Text = "Modell:";
            // 
            // jahrLabel
            // 
            this.jahrLabel.AutoSize = true;
            this.jahrLabel.Location = new System.Drawing.Point(20, 443);
            this.jahrLabel.Name = "jahrLabel";
            this.jahrLabel.Size = new System.Drawing.Size(101, 16);
            this.jahrLabel.TabIndex = 5;
            this.jahrLabel.Text = "Zulassungsjahr:";
            // 
            // leistungLabel
            // 
            this.leistungLabel.AutoSize = true;
            this.leistungLabel.Location = new System.Drawing.Point(20, 473);
            this.leistungLabel.Name = "leistungLabel";
            this.leistungLabel.Size = new System.Drawing.Size(90, 16);
            this.leistungLabel.TabIndex = 6;
            this.leistungLabel.Text = "Motorleistung:";
            // 
            // löschenButton
            // 
            this.löschenButton.Location = new System.Drawing.Point(572, 276);
            this.löschenButton.Name = "löschenButton";
            this.löschenButton.Size = new System.Drawing.Size(75, 23);
            this.löschenButton.TabIndex = 7;
            this.löschenButton.Text = "Löschen";
            this.löschenButton.UseVisualStyleBackColor = true;
            this.löschenButton.Click += new System.EventHandler(this.löschenButton_Click);
            // 
            // anlegenButton
            // 
            this.anlegenButton.Location = new System.Drawing.Point(292, 473);
            this.anlegenButton.Name = "anlegenButton";
            this.anlegenButton.Size = new System.Drawing.Size(75, 23);
            this.anlegenButton.TabIndex = 8;
            this.anlegenButton.Text = "Anlegen";
            this.anlegenButton.UseVisualStyleBackColor = true;
            this.anlegenButton.Click += new System.EventHandler(this.anlegenButton_Click);
            // 
            // kennzeichenTextbox
            // 
            this.kennzeichenTextbox.Location = new System.Drawing.Point(140, 353);
            this.kennzeichenTextbox.Name = "kennzeichenTextbox";
            this.kennzeichenTextbox.Size = new System.Drawing.Size(121, 22);
            this.kennzeichenTextbox.TabIndex = 9;
            // 
            // modellTextbox
            // 
            this.modellTextbox.Location = new System.Drawing.Point(140, 413);
            this.modellTextbox.Name = "modellTextbox";
            this.modellTextbox.Size = new System.Drawing.Size(121, 22);
            this.modellTextbox.TabIndex = 10;
            // 
            // jahrNumeric
            // 
            this.jahrNumeric.Location = new System.Drawing.Point(140, 441);
            this.jahrNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.jahrNumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.jahrNumeric.Name = "jahrNumeric";
            this.jahrNumeric.Size = new System.Drawing.Size(64, 22);
            this.jahrNumeric.TabIndex = 11;
            this.jahrNumeric.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // leistungNumeric
            // 
            this.leistungNumeric.Location = new System.Drawing.Point(140, 471);
            this.leistungNumeric.Name = "leistungNumeric";
            this.leistungNumeric.Size = new System.Drawing.Size(64, 22);
            this.leistungNumeric.TabIndex = 12;
            // 
            // herstellerCombobox
            // 
            this.herstellerCombobox.FormattingEnabled = true;
            this.herstellerCombobox.Location = new System.Drawing.Point(140, 383);
            this.herstellerCombobox.Name = "herstellerCombobox";
            this.herstellerCombobox.Size = new System.Drawing.Size(121, 24);
            this.herstellerCombobox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 528);
            this.Controls.Add(this.herstellerCombobox);
            this.Controls.Add(this.leistungNumeric);
            this.Controls.Add(this.jahrNumeric);
            this.Controls.Add(this.modellTextbox);
            this.Controls.Add(this.kennzeichenTextbox);
            this.Controls.Add(this.anlegenButton);
            this.Controls.Add(this.löschenButton);
            this.Controls.Add(this.leistungLabel);
            this.Controls.Add(this.jahrLabel);
            this.Controls.Add(this.modellLabel);
            this.Controls.Add(this.herstellerLabel);
            this.Controls.Add(this.kennzeichenLabel);
            this.Controls.Add(this.neuesFahrzeug);
            this.Controls.Add(this.fahrzeugeDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fahrzeugeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jahrNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leistungNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fahrzeugeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kennzeichen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hersteller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jahr;
        private System.Windows.Forms.DataGridViewTextBoxColumn kW;
        private System.Windows.Forms.Label neuesFahrzeug;
        private System.Windows.Forms.Label kennzeichenLabel;
        private System.Windows.Forms.Label herstellerLabel;
        private System.Windows.Forms.Label modellLabel;
        private System.Windows.Forms.Label jahrLabel;
        private System.Windows.Forms.Label leistungLabel;
        private System.Windows.Forms.Button löschenButton;
        private System.Windows.Forms.Button anlegenButton;
        private System.Windows.Forms.TextBox kennzeichenTextbox;
        private System.Windows.Forms.TextBox modellTextbox;
        private System.Windows.Forms.NumericUpDown jahrNumeric;
        private System.Windows.Forms.NumericUpDown leistungNumeric;
        private System.Windows.Forms.ComboBox herstellerCombobox;
    }
}

