
namespace QLNHANSU
{
    partial class FormNHANVIENDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNHANVIENDC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnLUU = new DevExpress.XtraBars.BarButtonItem();
            this.btnHUY = new DevExpress.XtraBars.BarButtonItem();
            this.btnDONG = new DevExpress.XtraBars.BarButtonItem();
            this.btnIN = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboDONVIDEN = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNGAY = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGHICHU = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLYDO = new DevExpress.XtraEditors.TextEdit();
            this.slkNHANVIEN = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSOQD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETE_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOQD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAPB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGHICHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLYDO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNHANVIEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOQD.Properties)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDONG, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIN, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnIN
            // 
            this.btnIN.Caption = "In";
            this.btnIN.Id = 6;
            this.btnIN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.Image")));
            this.btnIN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.LargeImage")));
            this.btnIN.Name = "btnIN";
            this.btnIN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIN_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1414, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1414, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1414, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 540);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(-1, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboDONVIDEN);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.dtNGAY);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txtGHICHU);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtLYDO);
            this.splitContainer1.Panel1.Controls.Add(this.slkNHANVIEN);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.txtSOQD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1415, 545);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 13;
            // 
            // cboDONVIDEN
            // 
            this.cboDONVIDEN.FormattingEnabled = true;
            this.cboDONVIDEN.Location = new System.Drawing.Point(607, 106);
            this.cboDONVIDEN.Name = "cboDONVIDEN";
            this.cboDONVIDEN.Size = new System.Drawing.Size(334, 29);
            this.cboDONVIDEN.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(488, 110);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 21);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Chuyển đến";
            // 
            // dtNGAY
            // 
            this.dtNGAY.CustomFormat = "dd/MM/yyyy";
            this.dtNGAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNGAY.Location = new System.Drawing.Point(170, 107);
            this.dtNGAY.Name = "dtNGAY";
            this.dtNGAY.Size = new System.Drawing.Size(235, 28);
            this.dtNGAY.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(93, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 21);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(93, 226);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 21);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Ghi chú";
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Location = new System.Drawing.Point(170, 223);
            this.txtGHICHU.MenuManager = this.barManager1;
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtGHICHU.Properties.Appearance.Options.UseFont = true;
            this.txtGHICHU.Size = new System.Drawing.Size(490, 28);
            this.txtGHICHU.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(93, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 21);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Lý do :";
            // 
            // txtLYDO
            // 
            this.txtLYDO.Location = new System.Drawing.Point(170, 174);
            this.txtLYDO.MenuManager = this.barManager1;
            this.txtLYDO.Name = "txtLYDO";
            this.txtLYDO.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtLYDO.Properties.Appearance.Options.UseFont = true;
            this.txtLYDO.Size = new System.Drawing.Size(490, 28);
            this.txtLYDO.TabIndex = 16;
            // 
            // slkNHANVIEN
            // 
            this.slkNHANVIEN.Location = new System.Drawing.Point(607, 67);
            this.slkNHANVIEN.MenuManager = this.barManager1;
            this.slkNHANVIEN.Name = "slkNHANVIEN";
            this.slkNHANVIEN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.slkNHANVIEN.Properties.Appearance.Options.UseFont = true;
            this.slkNHANVIEN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNHANVIEN.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNHANVIEN.Size = new System.Drawing.Size(334, 28);
            this.slkNHANVIEN.TabIndex = 14;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMANV.AppearanceCell.Options.UseFont = true;
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MaxWidth = 80;
            this.colMANV.MinWidth = 80;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 80;
            // 
            // colHOTEN
            // 
            this.colHOTEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colHOTEN.AppearanceCell.Options.UseFont = true;
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MaxWidth = 200;
            this.colHOTEN.MinWidth = 200;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 200;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(488, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 21);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Nhân viên";
            // 
            // txtSOQD
            // 
            this.txtSOQD.Location = new System.Drawing.Point(170, 67);
            this.txtSOQD.MenuManager = this.barManager1;
            this.txtSOQD.Name = "txtSOQD";
            this.txtSOQD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSOQD.Properties.Appearance.Options.UseFont = true;
            this.txtSOQD.Properties.ReadOnly = true;
            this.txtSOQD.Size = new System.Drawing.Size(235, 28);
            this.txtSOQD.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(93, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số QĐ";
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
            this.gcDanhsach.Size = new System.Drawing.Size(1415, 198);
            this.gcDanhsach.TabIndex = 0;
            this.gcDanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhsach});
            // 
            // gvDanhsach
            // 
            this.gvDanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETE_BY,
            this.SOQD,
            this.MANV,
            this.HOTEN,
            this.NGAY,
            this.LYDO,
            this.GHICHU,
            this.IDPB,
            this.TENPB,
            this.MAPB2,
            this.TENPB2});
            this.gvDanhsach.GridControl = this.gcDanhsach;
            this.gvDanhsach.Name = "gvDanhsach";
            this.gvDanhsach.OptionsView.ShowGroupPanel = false;
            this.gvDanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhsach_CustomDrawCell);
            this.gvDanhsach.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvDanhsach_CustomRowCellEdit);
            this.gvDanhsach.Click += new System.EventHandler(this.gvDanhsach_Click);
            // 
            // DELETE_BY
            // 
            this.DELETE_BY.FieldName = "DELETE_BY";
            this.DELETE_BY.MaxWidth = 22;
            this.DELETE_BY.MinWidth = 22;
            this.DELETE_BY.Name = "DELETE_BY";
            this.DELETE_BY.Visible = true;
            this.DELETE_BY.VisibleIndex = 0;
            this.DELETE_BY.Width = 22;
            // 
            // SOQD
            // 
            this.SOQD.Caption = "Số quyết định";
            this.SOQD.FieldName = "SOQD";
            this.SOQD.MaxWidth = 150;
            this.SOQD.MinWidth = 150;
            this.SOQD.Name = "SOQD";
            this.SOQD.Visible = true;
            this.SOQD.VisibleIndex = 1;
            this.SOQD.Width = 150;
            // 
            // MANV
            // 
            this.MANV.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MANV.AppearanceCell.Options.UseFont = true;
            this.MANV.Caption = "Mã nhân viên";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 300;
            this.MANV.MinWidth = 300;
            this.MANV.Name = "MANV";
            this.MANV.Width = 300;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Nhân viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 200;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 7;
            this.HOTEN.Width = 200;
            // 
            // NGAY
            // 
            this.NGAY.Caption = "Ngày";
            this.NGAY.FieldName = "NGAY";
            this.NGAY.MaxWidth = 150;
            this.NGAY.MinWidth = 150;
            this.NGAY.Name = "NGAY";
            this.NGAY.Visible = true;
            this.NGAY.VisibleIndex = 2;
            this.NGAY.Width = 150;
            // 
            // LYDO
            // 
            this.LYDO.Caption = "Lý do diều chuyển";
            this.LYDO.FieldName = "LYDO";
            this.LYDO.MaxWidth = 200;
            this.LYDO.MinWidth = 200;
            this.LYDO.Name = "LYDO";
            this.LYDO.Visible = true;
            this.LYDO.VisibleIndex = 3;
            this.LYDO.Width = 200;
            // 
            // GHICHU
            // 
            this.GHICHU.Caption = "Ghi chú";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MaxWidth = 250;
            this.GHICHU.MinWidth = 250;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 4;
            this.GHICHU.Width = 250;
            // 
            // IDPB
            // 
            this.IDPB.Caption = "Mã phòng ban";
            this.IDPB.FieldName = "IDPB";
            this.IDPB.MinWidth = 25;
            this.IDPB.Name = "IDPB";
            this.IDPB.Width = 94;
            // 
            // TENPB
            // 
            this.TENPB.Caption = "Đơn vị hiện tại";
            this.TENPB.FieldName = "TENPB";
            this.TENPB.MinWidth = 25;
            this.TENPB.Name = "TENPB";
            this.TENPB.Visible = true;
            this.TENPB.VisibleIndex = 5;
            this.TENPB.Width = 94;
            // 
            // MAPB2
            // 
            this.MAPB2.Caption = "MAPB2";
            this.MAPB2.FieldName = "MAPB2";
            this.MAPB2.MinWidth = 25;
            this.MAPB2.Name = "MAPB2";
            this.MAPB2.Width = 94;
            // 
            // TENPB2
            // 
            this.TENPB2.Caption = "Đơn vị đến";
            this.TENPB2.FieldName = "TENPB2";
            this.TENPB2.MinWidth = 25;
            this.TENPB2.Name = "TENPB2";
            this.TENPB2.Visible = true;
            this.TENPB2.VisibleIndex = 6;
            this.TENPB2.Width = 94;
            // 
            // FormNHANVIENDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNHANVIENDC";
            this.Text = "Danh sách điều chuyển";
            this.Load += new System.EventHandler(this.FormNHANVIENDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGHICHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLYDO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNHANVIEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOQD.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnIN;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtNGAY;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtGHICHU;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLYDO;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNHANVIEN;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSOQD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn SOQD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY;
        private DevExpress.XtraGrid.Columns.GridColumn LYDO;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private System.Windows.Forms.ComboBox cboDONVIDEN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn DELETE_BY;
        private DevExpress.XtraGrid.Columns.GridColumn IDPB;
        private DevExpress.XtraGrid.Columns.GridColumn TENPB;
        private DevExpress.XtraGrid.Columns.GridColumn MAPB2;
        private DevExpress.XtraGrid.Columns.GridColumn TENPB2;
    }
}