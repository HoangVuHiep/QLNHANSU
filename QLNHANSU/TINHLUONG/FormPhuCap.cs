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
namespace QLNHANSU.TINHLUONG
{
    public partial class FormPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public FormPhuCap()
        {
            InitializeComponent();
        }
        PHUCAP _phucap;
        NHANVIEN _nhanvien;
        bool _them;
        int _id;
        private void FormPhuCap_Load(object sender, EventArgs e)
        {
            _them = false;
            _phucap = new PHUCAP();
            _nhanvien = new NHANVIEN();
            showHide(true);
            loadData();
            loadNhanVien();
            loadPhuCap();
            cboPhuCap.SelectedIndexChanged += CboPhuCap_SelectedIndexChanged;
        }
        private void CboPhuCap_SelectedIndexChanged(object sender,EventArgs e)
        {
            var pc = _phucap.getItemPC(int.Parse(cboPhuCap.SelectedValue.ToString()));
            if (pc!=null){
                spSoTien.EditValue = pc.SOTIEN;
            }
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
            cboPhuCap.Enabled = !kt;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }
        void loadPhuCap()
        {
            cboPhuCap.DataSource = _phucap.getListPC();
            cboPhuCap.DisplayMember = "TENPC";
            cboPhuCap.ValueMember = "IDPC";
        }
        void loadData()
        {
            gcDanhsach.DataSource = _phucap.getListFull();
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
            cboPhuCap.SelectedIndex = 0;
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
                _phucap.Delete(_id, 1);
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
                tb_NHANVIEN_PHUCAP pc = new tb_NHANVIEN_PHUCAP();
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.NOIDUNG = txtNoiDung.Text;
                pc.NGAY = DateTime.Now;
                pc.CREATED_BY = 1;
                pc.CREATED_DATE = DateTime.Now;
                _phucap.Add(pc);
            }
            else
            {
                var pc = _phucap.getItem(_id);
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.NOIDUNG = txtNoiDung.Text;
                pc.NGAY = DateTime.Now;
                pc.CREATED_BY = 1;
                pc.CREATED_DATE = DateTime.Now;
                _phucap.Update(pc);
            }

        }

        private void gcDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhsach.GetFocusedRowCellValue("NOIDUNG").ToString();
                spSoTien.EditValue = gvDanhsach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue= gvDanhsach.GetFocusedRowCellValue("MANV");
                cboPhuCap.SelectedValue = gvDanhsach.GetFocusedRowCellValue("IDPC");
            }
        }


    }
}