
namespace QLNHANSU
{
    partial class FormCapNhatNgayCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatNgayCong));
            this.btnCAPNHAT = new DevExpress.XtraEditors.SimpleButton();
            this.cldNGAYCONG = new System.Windows.Forms.MonthCalendar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdgCHAMCONG = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdgTHOIGIANNGHI = new DevExpress.XtraEditors.RadioGroup();
            this.btnTHOAT = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgCHAMCONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTHOIGIANNGHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCAPNHAT
            // 
            this.btnCAPNHAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCAPNHAT.ImageOptions.SvgImage")));
            this.btnCAPNHAT.Location = new System.Drawing.Point(330, 419);
            this.btnCAPNHAT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCAPNHAT.Name = "btnCAPNHAT";
            this.btnCAPNHAT.Size = new System.Drawing.Size(148, 38);
            this.btnCAPNHAT.TabIndex = 0;
            this.btnCAPNHAT.Text = "Cập nhật";
            this.btnCAPNHAT.Click += new System.EventHandler(this.btnCAPNHAT_Click);
            // 
            // cldNGAYCONG
            // 
            this.cldNGAYCONG.Location = new System.Drawing.Point(28, 24);
            this.cldNGAYCONG.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.cldNGAYCONG.Name = "cldNGAYCONG";
            this.cldNGAYCONG.TabIndex = 1;
            this.cldNGAYCONG.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldNGAYCONG_DateSelected);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.rdgCHAMCONG);
            this.groupControl1.Location = new System.Drawing.Point(372, 24);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(182, 176);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chấm công";
            // 
            // rdgCHAMCONG
            // 
            this.rdgCHAMCONG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgCHAMCONG.EditValue = "P";
            this.rdgCHAMCONG.Location = new System.Drawing.Point(2, 28);
            this.rdgCHAMCONG.Name = "rdgCHAMCONG";
            this.rdgCHAMCONG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("VR", "Việc riêng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công tác", true, null, "")});
            this.rdgCHAMCONG.Size = new System.Drawing.Size(178, 146);
            this.rdgCHAMCONG.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.rdgTHOIGIANNGHI);
            this.groupControl2.Location = new System.Drawing.Point(372, 208);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(182, 161);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thời gian nghỉ";
            // 
            // rdgTHOIGIANNGHI
            // 
            this.rdgTHOIGIANNGHI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgTHOIGIANNGHI.EditValue = "CN";
            this.rdgTHOIGIANNGHI.Location = new System.Drawing.Point(2, 28);
            this.rdgTHOIGIANNGHI.Name = "rdgTHOIGIANNGHI";
            this.rdgTHOIGIANNGHI.Properties.Columns = 2;
            this.rdgTHOIGIANNGHI.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NN", "Cả ngày")});
            this.rdgTHOIGIANNGHI.Size = new System.Drawing.Size(178, 131);
            this.rdgTHOIGIANNGHI.TabIndex = 0;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Location = new System.Drawing.Point(503, 419);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(148, 38);
            this.btnTHOAT.TabIndex = 4;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.lbHoTen);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.lbID);
            this.groupControl3.Location = new System.Drawing.Point(28, 246);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(262, 211);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ tên:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbHoTen.ForeColor = System.Drawing.Color.Green;
            this.lbHoTen.Location = new System.Drawing.Point(76, 77);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(52, 18);
            this.lbHoTen.TabIndex = 8;
            this.lbHoTen.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbID.ForeColor = System.Drawing.Color.Green;
            this.lbID.Location = new System.Drawing.Point(76, 44);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 18);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "ID";
            // 
            // FormCapNhatNgayCong
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 512);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cldNGAYCONG);
            this.Controls.Add(this.btnCAPNHAT);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCapNhatNgayCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.FormCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgCHAMCONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgTHOIGIANNGHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCAPNHAT;
        private System.Windows.Forms.MonthCalendar cldNGAYCONG;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rdgTHOIGIANNGHI;
        private DevExpress.XtraEditors.RadioGroup rdgCHAMCONG;
        private DevExpress.XtraEditors.SimpleButton btnTHOAT;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
    }
}