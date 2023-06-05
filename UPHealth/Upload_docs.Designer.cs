namespace UPHealth
{
    partial class Upload_docs
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new Telerik.WinControls.UI.RadButton();
            this.btn_pif = new Telerik.WinControls.UI.RadButton();
            this.btn_idcard = new Telerik.WinControls.UI.RadButton();
            this.btn_prc1 = new Telerik.WinControls.UI.RadButton();
            this.btn_prc2 = new Telerik.WinControls.UI.RadButton();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.pic_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_idcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(666, 479);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radGroupBox1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel1.Size = new System.Drawing.Size(202, 479);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1952381F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-163, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.btnUpload);
            this.radGroupBox1.Controls.Add(this.btn_pif);
            this.radGroupBox1.Controls.Add(this.btn_idcard);
            this.radGroupBox1.Controls.Add(this.btn_prc1);
            this.radGroupBox1.Controls.Add(this.btn_prc2);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(11, 10);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(175, 248);
            this.radGroupBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "XXXXX";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(22, 164);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(127, 32);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btn_pif
            // 
            this.btn_pif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pif.Image = global::UPHealth.Properties.Resources.browse_32;
            this.btn_pif.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pif.Location = new System.Drawing.Point(22, 17);
            this.btn_pif.Name = "btn_pif";
            this.btn_pif.Size = new System.Drawing.Size(54, 55);
            this.btn_pif.TabIndex = 0;
            this.btn_pif.Text = "PIF";
            this.btn_pif.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pif.Click += new System.EventHandler(this.btn_pif_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_pif.GetChildAt(0))).Image = global::UPHealth.Properties.Resources.browse_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_pif.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_pif.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_pif.GetChildAt(0))).Text = "PIF";
            // 
            // btn_idcard
            // 
            this.btn_idcard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_idcard.Image = global::UPHealth.Properties.Resources.browse_32;
            this.btn_idcard.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_idcard.Location = new System.Drawing.Point(95, 93);
            this.btn_idcard.Name = "btn_idcard";
            this.btn_idcard.Size = new System.Drawing.Size(54, 55);
            this.btn_idcard.TabIndex = 3;
            this.btn_idcard.Text = "IDCard";
            this.btn_idcard.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_idcard.GetChildAt(0))).Image = global::UPHealth.Properties.Resources.browse_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_idcard.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_idcard.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_idcard.GetChildAt(0))).Text = "IDCard";
            // 
            // btn_prc1
            // 
            this.btn_prc1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prc1.Image = global::UPHealth.Properties.Resources.browse_32;
            this.btn_prc1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_prc1.Location = new System.Drawing.Point(95, 17);
            this.btn_prc1.Name = "btn_prc1";
            this.btn_prc1.Size = new System.Drawing.Size(54, 55);
            this.btn_prc1.TabIndex = 1;
            this.btn_prc1.Text = "PRC_1";
            this.btn_prc1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc1.GetChildAt(0))).Image = global::UPHealth.Properties.Resources.browse_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc1.GetChildAt(0))).Text = "PRC_1";
            // 
            // btn_prc2
            // 
            this.btn_prc2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prc2.Image = global::UPHealth.Properties.Resources.browse_32;
            this.btn_prc2.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_prc2.Location = new System.Drawing.Point(22, 93);
            this.btn_prc2.Name = "btn_prc2";
            this.btn_prc2.Size = new System.Drawing.Size(54, 55);
            this.btn_prc2.TabIndex = 2;
            this.btn_prc2.Text = "PRC_2";
            this.btn_prc2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc2.GetChildAt(0))).Image = global::UPHealth.Properties.Resources.browse_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc2.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc2.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_prc2.GetChildAt(0))).Text = "PRC_2";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.pic_image);
            this.splitPanel2.Location = new System.Drawing.Point(206, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel2.Size = new System.Drawing.Size(460, 479);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1952381F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(163, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // pic_image
            // 
            this.pic_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_image.Location = new System.Drawing.Point(0, 0);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(460, 479);
            this.pic_image.TabIndex = 0;
            this.pic_image.TabStop = false;
            // 
            // Upload_docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 479);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "Upload_docs";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Upload Document";
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_idcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadButton btn_pif;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btn_idcard;
        private Telerik.WinControls.UI.RadButton btn_prc1;
        private Telerik.WinControls.UI.RadButton btn_prc2;
        private Telerik.WinControls.UI.RadButton btnUpload;
        private System.Windows.Forms.PictureBox pic_image;
        private System.Windows.Forms.Label label1;

    }
}
