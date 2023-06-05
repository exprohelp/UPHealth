namespace UPHealth
{
    partial class main_form
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.rb_new_entry = new Telerik.WinControls.UI.RadButtonElement();
            this.btnNotLinked = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_download = new Telerik.WinControls.UI.RadButtonElement();
            this.btnScanDoc = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.rbe_searchpif = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_package_doc = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.rbe_AuditRegister = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_test_audit = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_query_on_sample = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_update_software = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.rb_new = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_comstatus = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_assetlist = new Telerik.WinControls.UI.RadButtonElement();
            this.rbprinttransferform = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lbl_user_name = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.rb_print_cover = new System.Windows.Forms.Panel();
            this.Loginbox = new Telerik.WinControls.UI.RadGroupBox();
            this.txtLogin_Id = new Telerik.WinControls.UI.RadTextBox();
            this.txtpsw = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.rbtn_Login = new Telerik.WinControls.UI.RadButton();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnUpdateSoftware = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.rb_print_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loginbox)).BeginInit();
            this.Loginbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpsw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3});
            this.radRibbonBar1.Enabled = false;
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(1031, 176);
            this.radRibbonBar1.TabIndex = 0;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = false;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Registration";
            this.ribbonTab1.Click += new System.EventHandler(this.ribbonTab1_Click);
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rb_new_entry,
            this.btnNotLinked,
            this.rb_download,
            this.btnScanDoc,
            this.radButtonElement2,
            this.rbe_searchpif,
            this.rb_package_doc});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Registration";
            // 
            // rb_new_entry
            // 
            this.rb_new_entry.Image = global::UPHealth.Properties.Resources.patient_report;
            this.rb_new_entry.Name = "rb_new_entry";
            this.rb_new_entry.Text = "Registration";
            this.rb_new_entry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rb_new_entry.Click += new System.EventHandler(this.rb_new_entry_Click);
            // 
            // btnNotLinked
            // 
            this.btnNotLinked.Name = "btnNotLinked";
            this.btnNotLinked.Text = "Not Linked";
            this.btnNotLinked.Click += new System.EventHandler(this.btnNotLinked_Click);
            // 
            // rb_download
            // 
            this.rb_download.Image = global::UPHealth.Properties.Resources.download_32;
            this.rb_download.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_download.Name = "rb_download";
            this.rb_download.Text = "Download Report";
            this.rb_download.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.rb_download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rb_download.Click += new System.EventHandler(this.rb_download_Click);
            // 
            // btnScanDoc
            // 
            this.btnScanDoc.Image = global::UPHealth.Properties.Resources.browse_32;
            this.btnScanDoc.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScanDoc.Name = "btnScanDoc";
            this.btnScanDoc.Text = "Scan Document";
            this.btnScanDoc.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScanDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnScanDoc.Click += new System.EventHandler(this.btnScanDoc_Click);
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Image = global::UPHealth.Properties.Resources.printer_32;
            this.radButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "Print Cover";
            this.radButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
            // 
            // rbe_searchpif
            // 
            this.rbe_searchpif.Name = "rbe_searchpif";
            this.rbe_searchpif.Text = "Search PIF";
            this.rbe_searchpif.Click += new System.EventHandler(this.rbe_searchpif_Click);
            // 
            // rb_package_doc
            // 
            this.rb_package_doc.Name = "rb_package_doc";
            this.rb_package_doc.Text = "Package Document";
            this.rb_package_doc.Click += new System.EventHandler(this.rb_package_doc_Click);
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rbe_AuditRegister,
            this.rb_test_audit,
            this.rb_query_on_sample,
            this.rb_update_software});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Audit";
            // 
            // rbe_AuditRegister
            // 
            this.rbe_AuditRegister.Name = "rbe_AuditRegister";
            this.rbe_AuditRegister.Text = "Register";
            this.rbe_AuditRegister.Click += new System.EventHandler(this.rbe_AuditRegister_Click);
            // 
            // rb_test_audit
            // 
            this.rb_test_audit.Name = "rb_test_audit";
            this.rb_test_audit.Text = "Test Performance";
            this.rb_test_audit.Click += new System.EventHandler(this.rb_test_audit_Click);
            // 
            // rb_query_on_sample
            // 
            this.rb_query_on_sample.Image = global::UPHealth.Properties.Resources.query_question_64;
            this.rb_query_on_sample.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_query_on_sample.Name = "rb_query_on_sample";
            this.rb_query_on_sample.Text = "Query On Sample";
            this.rb_query_on_sample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rb_query_on_sample.Click += new System.EventHandler(this.rb_query_on_sample_Click);
            // 
            // rb_update_software
            // 
            this.rb_update_software.Name = "rb_update_software";
            this.rb_update_software.Text = "UPDATE SOFTWARE";
            this.rb_update_software.Click += new System.EventHandler(this.rb_update_software_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup4});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Assets";
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rb_new,
            this.rb_comstatus,
            this.rb_assetlist,
            this.rbprinttransferform});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "";
            // 
            // rb_new
            // 
            this.rb_new.Name = "rb_new";
            this.rb_new.Text = "New Complaint";
            this.rb_new.TextWrap = true;
            this.rb_new.Click += new System.EventHandler(this.rb_new_Click);
            // 
            // rb_comstatus
            // 
            this.rb_comstatus.Name = "rb_comstatus";
            this.rb_comstatus.Text = "Complaint Status";
            this.rb_comstatus.TextWrap = true;
            this.rb_comstatus.Click += new System.EventHandler(this.rb_comstatus_Click);
            // 
            // rb_assetlist
            // 
            this.rb_assetlist.Name = "rb_assetlist";
            this.rb_assetlist.Text = "Assets List";
            this.rb_assetlist.Click += new System.EventHandler(this.rb_assetlist_Click);
            // 
            // rbprinttransferform
            // 
            this.rbprinttransferform.Name = "rbprinttransferform";
            this.rbprinttransferform.Text = "Print Transfer Form";
            this.rbprinttransferform.TextWrap = true;
            this.rbprinttransferform.Click += new System.EventHandler(this.rbprinttransferform_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.IsSelected = true;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup5});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Temp";
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement3});
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "Link Document";
            this.radButtonElement3.Click += new System.EventHandler(this.radButtonElement3_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lbl_user_name,
            this.radLabelElement1,
            this.radButtonElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 513);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1031, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.Name = "lbl_user_name";
            this.radStatusStrip1.SetSpring(this.lbl_user_name, false);
            this.lbl_user_name.Text = "";
            this.lbl_user_name.TextWrap = true;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "";
            this.radLabelElement1.TextWrap = true;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radStatusStrip1.SetSpring(this.radButtonElement1, false);
            this.radButtonElement1.Text = "Test List";
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // rb_print_cover
            // 
            this.rb_print_cover.Controls.Add(this.Loginbox);
            this.rb_print_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_print_cover.Location = new System.Drawing.Point(0, 176);
            this.rb_print_cover.Name = "rb_print_cover";
            this.rb_print_cover.Size = new System.Drawing.Size(1031, 337);
            this.rb_print_cover.TabIndex = 2;
            // 
            // Loginbox
            // 
            this.Loginbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.Loginbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginbox.Controls.Add(this.txtLogin_Id);
            this.Loginbox.Controls.Add(this.txtpsw);
            this.Loginbox.Controls.Add(this.radButton1);
            this.Loginbox.Controls.Add(this.rbtn_Login);
            this.Loginbox.HeaderText = "Login Information";
            this.Loginbox.Location = new System.Drawing.Point(819, 242);
            this.Loginbox.Name = "Loginbox";
            this.Loginbox.Size = new System.Drawing.Size(200, 89);
            this.Loginbox.TabIndex = 18;
            this.Loginbox.Text = "Login Information";
            // 
            // txtLogin_Id
            // 
            this.txtLogin_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin_Id.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtLogin_Id.Location = new System.Drawing.Point(19, 21);
            this.txtLogin_Id.MaxLength = 10;
            this.txtLogin_Id.Name = "txtLogin_Id";
            this.txtLogin_Id.Size = new System.Drawing.Size(79, 20);
            this.txtLogin_Id.TabIndex = 12;
            this.txtLogin_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtLogin_Id.GetChildAt(0))).Text = "";
            // 
            // txtpsw
            // 
            this.txtpsw.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtpsw.Location = new System.Drawing.Point(102, 21);
            this.txtpsw.MaxLength = 10;
            this.txtpsw.Name = "txtpsw";
            this.txtpsw.PasswordChar = '#';
            this.txtpsw.Size = new System.Drawing.Size(79, 20);
            this.txtpsw.TabIndex = 14;
            this.txtpsw.Tag = "";
            this.txtpsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtpsw.GetChildAt(0))).Text = "";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(19, 50);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(79, 30);
            this.radButton1.TabIndex = 16;
            this.radButton1.Text = "Cancel";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Cancel";
            // 
            // rbtn_Login
            // 
            this.rbtn_Login.Location = new System.Drawing.Point(105, 50);
            this.rbtn_Login.Name = "rbtn_Login";
            this.rbtn_Login.Size = new System.Drawing.Size(75, 30);
            this.rbtn_Login.TabIndex = 15;
            this.rbtn_Login.Text = "Login";
            this.rbtn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtn_Login.Click += new System.EventHandler(this.rbtn_Login_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_Login.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_Login.GetChildAt(0))).Text = "Login";
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnUpdateSoftware});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "SOFTWARE";
            // 
            // btnUpdateSoftware
            // 
            this.btnUpdateSoftware.Name = "btnUpdateSoftware";
            this.btnUpdateSoftware.Text = "Update Software";
            this.btnUpdateSoftware.Click += new System.EventHandler(this.btnUpdateSoftware_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 539);
            this.Controls.Add(this.rb_print_cover);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "main_form";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.rb_print_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Loginbox)).EndInit();
            this.Loginbox.ResumeLayout(false);
            this.Loginbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpsw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel rb_print_cover;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadLabelElement lbl_user_name;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement rb_new_entry;
        private Telerik.WinControls.UI.RadButtonElement rb_download;
        private Telerik.WinControls.UI.RadGroupBox Loginbox;
        private Telerik.WinControls.UI.RadTextBox txtLogin_Id;
        private Telerik.WinControls.UI.RadTextBox txtpsw;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton rbtn_Login;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadButtonElement btnScanDoc;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement rbe_AuditRegister;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement rb_test_audit;
        private Telerik.WinControls.UI.RadButtonElement rbe_searchpif;
        private Telerik.WinControls.UI.RadButtonElement rb_query_on_sample;
        private Telerik.WinControls.UI.RadButtonElement rb_update_software;
        private Telerik.WinControls.UI.RadButtonElement rb_package_doc;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnUpdateSoftware;
        private Telerik.WinControls.UI.RadButtonElement btnNotLinked;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement rb_new;
        private Telerik.WinControls.UI.RadButtonElement rb_comstatus;
        private Telerik.WinControls.UI.RadButtonElement rb_assetlist;
        private Telerik.WinControls.UI.RadButtonElement rbprinttransferform;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
    }
}
