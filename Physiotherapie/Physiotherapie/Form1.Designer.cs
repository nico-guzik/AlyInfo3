namespace Physiotherapie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tagesplanDataGrid = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tagesplanDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tagesplanDataGrid
            // 
            this.tagesplanDataGrid.AllowUserToAddRows = false;
            this.tagesplanDataGrid.AllowUserToDeleteRows = false;
            this.tagesplanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagesplanDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit});
            this.tagesplanDataGrid.Location = new System.Drawing.Point(12, 43);
            this.tagesplanDataGrid.Name = "tagesplanDataGrid";
            this.tagesplanDataGrid.ReadOnly = true;
            this.tagesplanDataGrid.RowHeadersWidth = 51;
            this.tagesplanDataGrid.RowTemplate.Height = 24;
            this.tagesplanDataGrid.Size = new System.Drawing.Size(240, 150);
            this.tagesplanDataGrid.TabIndex = 0;
            // 
            // Zeit
            // 
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.MinimumWidth = 6;
            this.Zeit.Name = "Zeit";
            this.Zeit.ReadOnly = true;
            this.Zeit.Width = 125;
            // 
            // datumDatePicker
            // 
            this.datumDatePicker.CustomFormat = "";
            this.datumDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDatePicker.Location = new System.Drawing.Point(67, 8);
            this.datumDatePicker.Name = "datumDatePicker";
            this.datumDatePicker.Size = new System.Drawing.Size(99, 22);
            this.datumDatePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumDatePicker);
            this.Controls.Add(this.tagesplanDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tagesplanDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tagesplanDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DateTimePicker datumDatePicker;
        private System.Windows.Forms.Label label1;
    }
}

