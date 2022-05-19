namespace Citynames
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
            this.CitiesListbox = new System.Windows.Forms.ListBox();
            this.PopulationLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.FilterTextbox = new System.Windows.Forms.TextBox();
            this.OtherCitiesTextbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CitiesListbox
            // 
            this.CitiesListbox.FormattingEnabled = true;
            this.CitiesListbox.ItemHeight = 16;
            this.CitiesListbox.Location = new System.Drawing.Point(100, 100);
            this.CitiesListbox.Name = "CitiesListbox";
            this.CitiesListbox.Size = new System.Drawing.Size(180, 244);
            this.CitiesListbox.TabIndex = 0;
            this.CitiesListbox.SelectedIndexChanged += new System.EventHandler(this.OnCitySelect);
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.AutoSize = true;
            this.PopulationLabel.Location = new System.Drawing.Point(332, 140);
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(69, 16);
            this.PopulationLabel.TabIndex = 1;
            this.PopulationLabel.Text = "Einwohner";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(332, 167);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(37, 16);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Land";
            // 
            // FilterTextbox
            // 
            this.FilterTextbox.Location = new System.Drawing.Point(335, 100);
            this.FilterTextbox.Name = "FilterTextbox";
            this.FilterTextbox.Size = new System.Drawing.Size(153, 22);
            this.FilterTextbox.TabIndex = 3;
            this.FilterTextbox.TextChanged += new System.EventHandler(this.OnFilterChange);
            // 
            // OtherCitiesTextbox
            // 
            this.OtherCitiesTextbox.FormattingEnabled = true;
            this.OtherCitiesTextbox.ItemHeight = 16;
            this.OtherCitiesTextbox.Location = new System.Drawing.Point(335, 199);
            this.OtherCitiesTextbox.Name = "OtherCitiesTextbox";
            this.OtherCitiesTextbox.Size = new System.Drawing.Size(153, 148);
            this.OtherCitiesTextbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OtherCitiesTextbox);
            this.Controls.Add(this.FilterTextbox);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.PopulationLabel);
            this.Controls.Add(this.CitiesListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CitiesListbox;
        private System.Windows.Forms.Label PopulationLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox FilterTextbox;
        private System.Windows.Forms.ListBox OtherCitiesTextbox;
    }
}

