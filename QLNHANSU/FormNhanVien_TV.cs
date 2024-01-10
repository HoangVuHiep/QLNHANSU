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
    public partial class FormNhanVien_TV : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien_TV()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NHANVIEN_THOIVIEC _nvtv;
        NHANVIEN _nhanvien;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhanVien_TV_Load(object sender, EventArgs e)
        {
            _nvtv = new NHANVIEN_THOIVIEC();
            _nhanvien = new NHANVIEN();
            _them = false;
            showHide(true);
            loadNhanVien();
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
            slkNHANVIEN.Enabled = !kt;
            dtNGAYNOPDON.Enabled = !kt;
        }
        void _reset()
        {
            txtSOQD.Text = string.Empty;
            txtLYDO.Text = string.Empty;
            txtGHICHU.Text = string.Empty;
            dtNGAYNOPDON.Value = DateTime.Now;
            dtNGAYNGHI.Value = dtNGAYNOPDON.Value.AddDays(45);

        }
        void loadNhanVien()
        {
            slkNHANVIEN.Properties.DataSource = _nhanvien.getList();
            slkNHANVIEN.Properties.ValueMember = "MANV";
            slkNHANVIEN.Properties.DisplayMember = "HOTEN";
        }

        void loadData()
        {
            gcDanhsach.DataSource = _nvtv.getListFull();
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
                _nvtv.Delete(_soQD, 1);
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
            tb_NHANVIEN_THOIVIEC tv;
            if (_them)
            {
                
                var maxSoQD = _nvtv.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5) + 1);
                tv = new tb_NHANVIEN_THOIVIEC();
                tv.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐTV";
                tv.LYDO = txtLYDO.Text;
                tv.NGAYNOPDON = dtNGAYNOPDON.Value;
                tv.NGAYNGHI = dtNGAYNGHI.Value;
                tv.GHICHU = txtGHICHU.Text;
                tv.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                tv.CREATE_BY = 1;
                tv.CREATE_DATE = DateTime.Now;
                _nvtv.Add(tv);
            }
            else
            {
                tv = _nvtv.getItem(_soQD);
                tv.LYDO = txtLYDO.Text;
                tv.NGAYNOPDON = dtNGAYNOPDON.Value;
                tv.NGAYNGHI = dtNGAYNGHI.Value;
                tv.GHICHU = txtGHICHU.Text;
                tv.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                tv.UPDATE_BY = 1;
                tv.UPDATE_DATE = DateTime.Now;
                _nvtv.Update(tv);
            }
            var nv = _nhanvien.getItem(tv.MANV.Value);
            nv.DATHOIVIEC = true;
            _nhanvien.Update(nv);
        }


        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _soQD = gvDanhsach.GetFocusedRowCellValue("SOQD").ToString();
                var tv = _nvtv.getItem(_soQD);
                txtSOQD.Text = _soQD;
                dtNGAYNOPDON.Value = tv.NGAYNOPDON.Value;
                dtNGAYNGHI.Value = tv.NGAYNGHI.Value;
                slkNHANVIEN.EditValue = tv.MANV;
                txtGHICHU.Text = tv.GHICHU;
                txtLYDO.Text = tv.LYDO;
            }
        }

        private void gvDanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.images;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void dtNGAYNOPDON_ValueChanged(object sender, EventArgs e)
        {
            dtNGAYNGHI.Value = dtNGAYNOPDON.Value.AddDays(45);
        }
    }
}