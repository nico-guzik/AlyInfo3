namespace Endoskope
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
            this.endoskopeDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bezeichnungTextbox = new System.Windows.Forms.TextBox();
            this.ortTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.durchmesserNumeric = new System.Windows.Forms.NumericUpDown();
            this.laengeNumeric = new System.Windows.Forms.NumericUpDown();
            this.kanaeleNumeric = new System.Windows.Forms.NumericUpDown();
            this.herstellerCombobox = new System.Windows.Forms.ComboBox();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durchmesser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kanaele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endoAnlegenButton = new System.Windows.Forms.Button();
            this.herstellerAnlegenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.endoskopeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durchmesserNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laengeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanaeleNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // endoskopeDataGrid
            // 
            this.endoskopeDataGrid.AllowUserToAddRows = false;
            this.endoskopeDataGrid.AllowUserToDeleteRows = false;
            this.endoskopeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.endoskopeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bezeichnung,
            this.Durchmesser,
            this.Laenge,
            this.Kanaele,
            this.Hersteller});
            this.endoskopeDataGrid.Location = new System.Drawing.Point(13, 13);
            this.endoskopeDataGrid.Name = "endoskopeDataGrid";
            this.endoskopeDataGrid.ReadOnly = true;
            this.endoskopeDataGrid.RowHeadersVisible = false;
            this.endoskopeDataGrid.RowHeadersWidth = 51;
            this.endoskopeDataGrid.RowTemplate.Height = 24;
            this.endoskopeDataGrid.Size = new System.Drawing.Size(680, 150);
            this.endoskopeDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neues Endoskop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neuer Hersteller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ort:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bezeichnung:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Durchmesser:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Länge:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kanäle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hersteller";
            // 
            // bezeichnungTextbox
            // 
            this.bezeichnungTextbox.Location = new System.Drawing.Point(127, 212);
            this.bezeichnungTextbox.Name = "bezeichnungTextbox";
            this.bezeichnungTextbox.Size = new System.Drawing.Size(100, 22);
            this.bezeichnungTextbox.TabIndex = 10;
            // 
            // ortTextbox
            // 
            this.ortTextbox.Location = new System.Drawing.Point(549, 247);
            this.ortTextbox.Name = "ortTextbox";
            this.ortTextbox.Size = new System.Drawing.Size(100, 22);
            this.ortTextbox.TabIndex = 11;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(549, 212);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 22);
            this.nameTextbox.TabIndex = 12;
            // 
            // durchmesserNumeric
            // 
            this.durchmesserNumeric.DecimalPlaces = 1;
            this.durchmesserNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.durchmesserNumeric.Location = new System.Drawing.Point(127, 247);
            this.durchmesserNumeric.Name = "durchmesserNumeric";
            this.durchmesserNumeric.Size = new System.Drawing.Size(120, 22);
            this.durchmesserNumeric.TabIndex = 13;
            // 
            // laengeNumeric
            // 
            this.laengeNumeric.Location = new System.Drawing.Point(127, 280);
            this.laengeNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.laengeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.laengeNumeric.Name = "laengeNumeric";
            this.laengeNumeric.Size = new System.Drawing.Size(120, 22);
            this.laengeNumeric.TabIndex = 14;
            this.laengeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kanaeleNumeric
            // 
            this.kanaeleNumeric.Location = new System.Drawing.Point(127, 311);
            this.kanaeleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kanaeleNumeric.Name = "kanaeleNumeric";
            this.kanaeleNumeric.Size = new System.Drawing.Size(120, 22);
            this.kanaeleNumeric.TabIndex = 15;
            this.kanaeleNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // herstellerCombobox
            // 
            this.herstellerCombobox.FormattingEnabled = true;
            this.herstellerCombobox.Location = new System.Drawing.Point(126, 344);
            this.herstellerCombobox.Name = "herstellerCombobox";
            this.herstellerCombobox.Size = new System.Drawing.Size(121, 24);
            this.herstellerCombobox.TabIndex = 16;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.HeaderText = "Bezeichnung";
            this.Bezeichnung.MinimumWidth = 6;
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.ReadOnly = true;
            this.Bezeichnung.Width = 125;
            // 
            // Durchmesser
            // 
            this.Durchmesser.HeaderText = "Durchmesser";
            this.Durchmesser.MinimumWidth = 6;
            this.Durchmesser.Name = "Durchmesser";
            this.Durchmesser.ReadOnly = true;
            this.Durchmesser.Width = 125;
            // 
            // Laenge
            // 
            this.Laenge.HeaderText = "Länge";
            this.Laenge.MinimumWidth = 6;
            this.Laenge.Name = "Laenge";
            this.Laenge.ReadOnly = true;
            this.Laenge.Width = 125;
            // 
            // Kanaele
            // 
            this.Kanaele.HeaderText = "Kanäle";
            this.Kanaele.MinimumWidth = 6;
            this.Kanaele.Name = "Kanaele";
            this.Kanaele.ReadOnly = true;
            this.Kanaele.Width = 125;
            // 
            // Hersteller
            // 
            this.Hersteller.HeaderText = "Hersteller";
            this.Hersteller.MinimumWidth = 6;
            this.Hersteller.Name = "Hersteller";
            this.Hersteller.ReadOnly = true;
            this.Hersteller.Width = 125;
            // 
            // endoAnlegenButton
            // 
            this.endoAnlegenButton.Location = new System.Drawing.Point(27, 394);
            this.endoAnlegenButton.Name = "endoAnlegenButton";
            this.endoAnlegenButton.Size = new System.Drawing.Size(186, 23);
            this.endoAnlegenButton.TabIndex = 17;
            this.endoAnlegenButton.Text = "Endoskop anlegen";
            this.endoAnlegenButton.UseVisualStyleBackColor = true;
            this.endoAnlegenButton.Click += new System.EventHandler(this.endoAnlegenButton_Click);
            // 
            // herstellerAnlegenButton
            // 
            this.herstellerAnlegenButton.Location = new System.Drawing.Point(460, 297);
            this.herstellerAnlegenButton.Name = "herstellerAnlegenButton";
            this.herstellerAnlegenButton.Size = new System.Drawing.Size(160, 23);
            this.herstellerAnlegenButton.TabIndex = 18;
            this.herstellerAnlegenButton.Text = "Hersteller anlegen";
            this.herstellerAnlegenButton.UseVisualStyleBackColor = true;
            this.herstellerAnlegenButton.Click += new System.EventHandler(this.herstellerAnlegenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.herstellerAnlegenButton);
            this.Controls.Add(this.endoAnlegenButton);
            this.Controls.Add(this.herstellerCombobox);
            this.Controls.Add(this.kanaeleNumeric);
            this.Controls.Add(this.laengeNumeric);
            this.Controls.Add(this.durchmesserNumeric);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.ortTextbox);
            this.Controls.Add(this.bezeichnungTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endoskopeDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.endoskopeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durchmesserNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laengeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanaeleNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView endoskopeDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bezeichnungTextbox;
        private System.Windows.Forms.TextBox ortTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.NumericUpDown durchmesserNumeric;
        private System.Windows.Forms.NumericUpDown laengeNumeric;
        private System.Windows.Forms.NumericUpDown kanaeleNumeric;
        private System.Windows.Forms.ComboBox herstellerCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durchmesser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kanaele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hersteller;
        private System.Windows.Forms.Button endoAnlegenButton;
        private System.Windows.Forms.Button herstellerAnlegenButton;
    }
}

