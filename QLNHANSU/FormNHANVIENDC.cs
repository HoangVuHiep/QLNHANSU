using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace QLNHANSU
{
    public partial class FormNHANVIENDC : DevExpress.XtraEditors.XtraForm
    {
        public FormNHANVIENDC()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NHANVIEN_DIEUCHUYEN _nvdc;
        NHANVIEN _nhanvien;
        PHONGBAN _phongban;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormNHANVIENDC_Load(object sender, EventArgs e)
        {
            _nvdc = new NHANVIEN_DIEUCHUYEN();
            _nhanvien = new NHANVIEN();
            _phongban = new PHONGBAN();
            _them = false;
            showHide(true);
            loadNhanVien();
            LoadDonViDen();
            loadData();

            splitContainer1.Panel1Collapsed = true;
        }
        void showHide(bool kt)
        {
            btnLUU.Enabled = !kt;
            btnHUY.Enabled = !kt;
            btnTHEM.Enabled = kt;
            btnSUA.Enabled = kt;
            btnXOA.Enabled = kt;
            btnDONG.Enabled = kt;
            btnIN.Enabled = kt;
            gcDanhsach.Enabled = kt;
            txtSOQD.Enabled = !kt;
            txtGHICHU.Enabled = !kt;
            txtLYDO.Enabled = !kt;
            cboDONVIDEN.Enabled = !kt;
            slkNHANVIEN.Enabled = !kt;
        }
        void _reset()
        {
            txtSOQD.Text = string.Empty;
            txtLYDO.Text = string.Empty;
            txtGHICHU.Text = string.Empty;


        }
        void loadNhanVien()
        {
            slkNHANVIEN.Properties.DataSource = _nhanvien.getList();
            slkNHANVIEN.Properties.ValueMember = "MANV";
            slkNHANVIEN.Properties.DisplayMember = "HOTEN";
        }
        void LoadDonViDen()
        {
            cboDONVIDEN.DataSource = _phongban.getList();
            cboDONVIDEN.DisplayMember = "TENPB";
            cboDONVIDEN.ValueMember = "IDPB";
        }
        void loadData()
        {
            gcDanhsach.DataSource = _nvdc.getListFull();
            gvDanhsach.OptionsBehavior.Editable = false;

        }
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcDanhsach.Enabled = true;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nvdc.Delete(_soQD, 1);
                loadData();
            }
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHUY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void SaveData()
        {
            tb_NHANVIEN_DIEUCHUYEN dc;
            if (_them)
            {
                // Số hđ có dạng: 00001/2023/HĐLĐ
                var maxSoQD = _nvdc.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5) + 1);
                dc = new tb_NHANVIEN_DIEUCHUYEN();
                dc.SOQD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+@"/QĐDC";
                dc.LYDO = txtLYDO.Text;
                dc.NGAY = dtNGAY.Value;
                dc.GHICHU = txtGHICHU.Text;
                dc.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                dc.IDPB = _nhanvien.getItem(int.Parse(slkNHANVIEN.EditValue.ToString())).IDPB;
                dc.MAPB2 = int.Parse(cboDONVIDEN.SelectedValue.ToString());
                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _nvdc.Add(dc);
            }
            else
            {
                dc = _nvdc.getItem(_soQD);         
                dc.LYDO = txtLYDO.Text;
                dc.NGAY = dtNGAY.Value;
                dc.GHICHU = txtGHICHU.Text;
                dc.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                dc.MAPB2 = int.Parse(cboDONVIDEN.SelectedValue.ToString());
                dc.UPDATE_BY = 1;
                dc.UPDATE_DATE = DateTime.Now;
                _nvdc.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.MANV.Value);
            nv.IDPB = dc.MAPB2;
            _nhanvien.Update(nv);
        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _soQD = gvDanhsach.GetFocusedRowCellValue("SOQD").ToString();
                var dc = _nvdc.getItem(_soQD);
                txtSOQD.Text = _soQD;
                dtNGAY.Value = dc.NGAY.Value;
                slkNHANVIEN.EditValue = dc.MANV;
                txtGHICHU.Text = dc.GHICHU;
                txtLYDO.Text = dc.LYDO;
                cboDONVIDEN.SelectedValue = dc.MAPB2;
            }
        }

        private void gvDanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name=="DELETED_BY" && e.CellValue!=null)
            {
                Image img = Properties.Resources.images;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }    
        }

        private void gvDanhsach_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

        }
    }
}