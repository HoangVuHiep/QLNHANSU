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
    public partial class FormBangCong : DevExpress.XtraEditors.XtraForm
    {
        public FormBangCong()
        {
            InitializeComponent();
        }

        KYCONG _kycong;
        bool _them;
        int _makycong;

        private void FormBangCong_Load(object sender, EventArgs e)
        {
            _them = false;
            _kycong = new KYCONG();
            showHide(true);
            loadData();
            cboNAM.Text = DateTime.Now.Year.ToString();
            cboTHANG.Text = DateTime.Now.Month.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }
        void loadData()
        {
            gcDanhsach.DataSource = _kycong.getList();
            gvDanhsach.OptionsBehavior.Editable = false;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            cboNAM.Text = DateTime.Now.Year.ToString();
            cboTHANG.Text = DateTime.Now.Month.ToString();
            chkKHOA.Checked = false;
            chkTRANGTHAI.Checked = false;

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
                _kycong.Delete(_makycong, 1);
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

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void SaveData()
        {
            if (_them)
            {
                tb_KYCONG kc = new tb_KYCONG();
                kc.MAKYCONG = int.Parse(cboNAM.Text) * 100 + int.Parse(cboTHANG.Text);
                kc.NAM = int.Parse(cboNAM.Text);
                kc.THANG = int.Parse(cboTHANG.Text);
                kc.KHOA = chkKHOA.Checked;
                kc.TRANGTHAI = chkTRANGTHAI.Checked;
                kc.MACT = 1;
                kc.NGAYCONGTRONGTHANG = HFunctions.demSoNgayLamViecTrongThang(int.Parse(cboTHANG.Text),int.Parse(cboNAM.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Add(kc);
            }
            else
            {
                var kc = _kycong.getItem(_makycong);
                kc.MAKYCONG = int.Parse(cboNAM.Text) * 100 + int.Parse(cboTHANG.Text);
                kc.NAM = int.Parse(cboNAM.Text);
                kc.THANG = int.Parse(cboTHANG.Text);
                kc.KHOA = chkKHOA.Checked;
                kc.TRANGTHAI = chkTRANGTHAI.Checked;
                kc.MACT = 1;
                kc.NGAYCONGTRONGTHANG = HFunctions.demSoNgayLamViecTrongThang(int.Parse(cboTHANG.Text), int.Parse(cboNAM.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Update(kc);
            }

        }
        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _makycong = int.Parse(gvDanhsach.GetFocusedRowCellValue("MAKYCONG").ToString());
                cboNAM.Text = gvDanhsach.GetFocusedRowCellValue("NAM").ToString();
                cboTHANG.Text = gvDanhsach.GetFocusedRowCellValue("THANG").ToString();
                chkKHOA.Checked = bool.Parse(gvDanhsach.GetFocusedRowCellValue("KHOA").ToString());
                chkTRANGTHAI.Checked = bool.Parse(gvDanhsach.GetFocusedRowCellValue("TRANGTHAI").ToString());
            }
        }

        private void btnXEMBC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBangCongCT frm = new FormBangCongCT();
            frm._makycong = _makycong;
            frm._thang = int.Parse(cboTHANG.Text);
            frm._nam = int.Parse(cboNAM.Text);
            frm._mact = 1;
            frm.ShowDialog();
        }
    }
}