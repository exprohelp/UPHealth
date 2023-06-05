namespace UPHealth
{
    partial class PeendingWork
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_patientcount = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_patientcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_patientcount.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_patientcount
            // 
            this.rgv_patientcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rgv_patientcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_patientcount.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_patientcount.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_patientcount.ForeColor = System.Drawing.Color.Black;
            this.rgv_patientcount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_patientcount.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.rgv_patientcount.MasterTemplate.AllowAddNewRow = false;
            this.rgv_patientcount.MasterTemplate.AllowDeleteRow = false;
            this.rgv_patientcount.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit_name";
            gridViewTextBoxColumn1.HeaderText = "Hospital";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "unit_name";
            gridViewTextBoxColumn1.Width = 213;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PatientCount";
            gridViewTextBoxColumn2.HeaderText = "Count";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Name = "PatientCount";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 130;
            this.rgv_patientcount.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.rgv_patientcount.MasterTemplate.EnableGrouping = false;
            this.rgv_patientcount.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_patientcount.Name = "rgv_patientcount";
            this.rgv_patientcount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_patientcount.Size = new System.Drawing.Size(385, 468);
            this.rgv_patientcount.TabIndex = 166;
            this.rgv_patientcount.Text = "radGridView1";
            // 
            // PeendingWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 474);
            this.Controls.Add(this.rgv_patientcount);
            this.Name = "PeendingWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeendingWork";
            this.Load += new System.EventHandler(this.PeendingWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_patientcount.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_patientcount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_patientcount;
    }
}