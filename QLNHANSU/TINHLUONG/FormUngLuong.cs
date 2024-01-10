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
using BusinessLayer.DTO;
using BusinessLayer;

namespace QLNHANSU.TINHLUONG
{
    public partial class FormUngLuong : DevExpress.XtraEditors.XtraForm
    {
        public FormUngLuong()
        {
            InitializeComponent();
        }

        NHANVIEN _nhanvien;
        UNGLUONG _ungluong;
        bool _them;
        int _id;
        private void FormUngLuong_Load(object sender, EventArgs e)
        {
            _them = false;
            _ungluong = new UNGLUONG();
            _nhanvien = new NHANVIEN();
            showHide(true);
            loadData();
            loadNhanVien();
        }
        void showHide(bool kt)
        {
            btnLUU.Enabled = !kt;
            btnHUY.Enabled = !kt;
            btnTHEM.Enabled = kt;
            btnSUA.Enabled = kt;
            btnXOA.Enabled = kt;
            btnDONG.Enabled = kt;
            txtNoiDung.Enabled = !kt;
            spSoTien.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }
        void loadData()
        {
            gcDanhsach.DataSource = _ungluong.getListFull();
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ungluong.Delete(_id, 1);
                loadData();
            }
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            showHide(true);
        }

        private void btnHUY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(true);
        }

        private void btnDONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_UNGLUONG ul = new tb_UNGLUONG();
                ul.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                ul.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                ul.GHICHU = txtNoiDung.Text;
                ul.NGAY = DateTime.Now.Day;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                ul.CREATED_BY = 1;
                ul.CREATED_DATE = DateTime.Now;
                _ungluong.Add(ul);
            }
            else
            {
                var ul = _ungluong.getItem(_id);
                ul.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                ul.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                ul.GHICHU = txtNoiDung.Text;
                ul.NGAY = DateTime.Now.Day;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                ul.CREATED_BY = 1;
                ul.CREATED_DATE = DateTime.Now;
                _ungluong.Update(ul);
            }

        }
        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhsach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoTien.EditValue = gvDanhsach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue = gvDanhsach.GetFocusedRowCellValue("MANV");
            }
        }
    }
}