namespace UPHealth
{
    partial class TestList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgTestList = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTestList
            // 
            this.dgTestList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgTestList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgTestList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgTestList.ForeColor = System.Drawing.Color.Black;
            this.dgTestList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgTestList.Location = new System.Drawing.Point(0, 34);
            // 
            // 
            // 
            this.dgTestList.MasterTemplate.AllowAddNewRow = false;
            this.dgTestList.MasterTemplate.AllowDeleteRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "uph_testcode";
            gridViewTextBoxColumn1.HeaderText = "Code";
            gridViewTextBoxColumn1.Name = "uph_testcode";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TestCategory";
            gridViewTextBoxColumn2.HeaderText = "TestCategory";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "TestCategory";
            gridViewTextBoxColumn2.Width = 199;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "uph_name";
            gridViewTextBoxColumn3.HeaderText = "UP Health Name";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "uph_name";
            gridViewTextBoxColumn3.Width = 353;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "testname";
            gridViewTextBoxColumn4.HeaderText = "Internal Name";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "testname";
            gridViewTextBoxColumn4.Width = 214;
            this.dgTestList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgTestList.MasterTemplate.EnableFiltering = true;
            this.dgTestList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgTestList.Name = "dgTestList";
            this.dgTestList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgTestList.ShowGroupPanel = false;
            this.dgTestList.Size = new System.Drawing.Size(856, 501);
            this.dgTestList.TabIndex = 0;
            this.dgTestList.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(0, 6);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "REFRESH";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // TestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 534);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.dgTestList);
            this.Name = "TestList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.TestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTestList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgTestList;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
