
namespace QLNHANSU.CHAMCONG
{
    partial class FormLoaiCong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiCong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnLUU = new DevExpress.XtraBars.BarButtonItem();
            this.btnHUY = new DevExpress.XtraBars.BarButtonItem();
            this.btnDONG = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnIN = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spHESO = new DevExpress.XtraEditors.SpinEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAICONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHESO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnSUA,
            this.btnXOA,
            this.btnLUU,
            this.btnHUY,
            this.btnDONG,
            this.btnIN});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSUA, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLUU, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHUY, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDONG, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.Image")));
            this.btnTHEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHEM.ImageOptions.LargeImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnSUA
            // 
            this.btnSUA.Caption = "Sửa";
            this.btnSUA.Id = 1;
            this.btnSUA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.Image")));
            this.btnSUA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSUA.ImageOptions.LargeImage")));
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSUA_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xóa";
            this.btnXOA.Id = 2;
            this.btnXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.Image")));
            this.btnXOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXOA.ImageOptions.LargeImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnLUU
            // 
            this.btnLUU.Caption = "Lưu";
            this.btnLUU.Id = 3;
            this.btnLUU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLUU.ImageOptions.Image")));
            this.btnLUU.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLUU.ImageOptions.LargeImage")));
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLUU_ItemClick);
            // 
            // btnHUY
            // 
            this.btnHUY.Caption = "Hủy";
            this.btnHUY.Id = 4;
            this.btnHUY.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHUY.ImageOptions.Image")));
            this.btnHUY.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHUY.ImageOptions.LargeImage")));
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHUY_ItemClick);
            // 
            // btnDONG
            // 
            this.btnDONG.Caption = "Đóng";
            this.btnDONG.Id = 5;
            this.btnDONG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDONG.ImageOptions.Image")));
            this.btnDONG.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDONG.ImageOptions.LargeImage")));
            this.btnDONG.Name = "btnDONG";
            this.btnDONG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDONG_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(862, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(862, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(862, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // btnIN
            // 
            this.btnIN.Caption = "In";
            this.btnIN.Id = 6;
            this.btnIN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.Image")));
            this.btnIN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.LargeImage")));
            this.btnIN.Name = "btnIN";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.spHESO);
            this.splitContainer1.Panel1.Controls.Add(this.txtTEN);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(862, 511);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(535, 30);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hệ số";
            // 
            // spHESO
            // 
            this.spHESO.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHESO.Location = new System.Drawing.Point(600, 23);
            this.spHESO.MenuManager = this.barManager1;
            this.spHESO.Name = "spHESO";
            this.spHESO.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spHESO.Properties.Appearance.Options.UseFont = true;
            this.spHESO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHESO.Size = new System.Drawing.Size(125, 28);
            this.spHESO.TabIndex = 2;
            // 
            // txtTEN
            // 
            this.txtTEN.Location = new System.Drawing.Point(101, 23);
            this.txtTEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTEN.Properties.Appearance.Options.UseFont = true;
            this.txtTEN.Size = new System.Drawing.Size(339, 28);
            this.txtTEN.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 30);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Loại ca";
            // 
            // gcDanhsach
            // 
            this.gcDanhsach.DataSource = typeof(DataLayer.tb_DANTOC);
            this.gcDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhsach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhsach.MainView = this.gvDanhsach;
            this.gcDanhsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDanhsach.MenuManager = this.barManager1;
            this.gcDanhsach.Name = "gcDanhsach";
            this.gcDanhsach.Size = new System.Drawing.Size(862, 361);
            this.gcDanhsach.TabIndex = 0;
            this.gcDanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhsach});
            // 
            // gvDanhsach
            // 
            this.gvDanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDLC,
            this.TENLOAICONG,
            this.HESO});
            this.gvDanhsach.GridControl = this.gcDanhsach;
            this.gvDanhsach.Name = "gvDanhsach";
            this.gvDanhsach.OptionsView.ShowGroupPanel = false;
            this.gvDanhsach.Click += new System.EventHandler(this.gvDanhsach_Click);
            // 
            // IDLC
            // 
            this.IDLC.Caption = "ID";
            this.IDLC.FieldName = "IDLC";
            this.IDLC.MaxWidth = 30;
            this.IDLC.MinWidth = 30;
            this.IDLC.Name = "IDLC";
            this.IDLC.Visible = true;
            this.IDLC.VisibleIndex = 0;
            this.IDLC.Width = 30;
            // 
            // TENLOAICONG
            // 
            this.TENLOAICONG.Caption = "Loại công";
            this.TENLOAICONG.FieldName = "TENLOAICONG";
            this.TENLOAICONG.MaxWidth = 200;
            this.TENLOAICONG.MinWidth = 200;
            this.TENLOAICONG.Name = "TENLOAICONG";
            this.TENLOAICONG.Visible = true;
            this.TENLOAICONG.VisibleIndex = 1;
            this.TENLOAICONG.Width = 200;
            // 
            // HESO
            // 
            this.HESO.Caption = "Hệ số";
            this.HESO.FieldName = "HESO";
            this.HESO.MaxWidth = 50;
            this.HESO.MinWidth = 50;
            this.HESO.Name = "HESO";
            this.HESO.Visible = true;
            this.HESO.VisibleIndex = 2;
            this.HESO.Width = 50;
            // 
            // FormLoaiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLoaiCong";
            this.Text = "Loại công";
            this.Load += new System.EventHandler(this.FormLoaiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spHESO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnLUU;
        private DevExpress.XtraBars.BarButtonItem btnHUY;
        private DevExpress.XtraBars.BarButtonItem btnDONG;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnIN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spHESO;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn IDLC;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAICONG;
        private DevExpress.XtraGrid.Columns.GridColumn HESO;
    }
}