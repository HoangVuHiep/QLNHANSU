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
    public partial class FormCongTy : DevExpress.XtraEditors.XtraForm
    {
        public FormCongTy()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        bool _them;
        int _id;
        void showHide(bool kt)
        {
            btnLUU.Enabled = !kt;
            btnHUY.Enabled = !kt;
            btnTHEM.Enabled = kt;
            btnSUA.Enabled = kt;
            btnXOA.Enabled = kt;
            btnDONG.Enabled = kt;
            btnIN.Enabled = kt;
            txtTEN.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtSDT.Enabled = !kt;
            txtDIACHI.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhsach.DataSource = _congty.getList();
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtTEN.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDIACHI.Text = string.Empty;
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
                _congty.Delete(_id);
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
                tb_CONGTY ct = new tb_CONGTY();
                ct.TENCT = txtTEN.Text;
                ct.EMAIL = txtEmail.Text;
                ct.DIENTHOAI = txtSDT.Text;
                ct.DIACHI = txtDIACHI.Text;
                _congty.Add(ct);
            }
            else
            {
                var ct = _congty.getItem(_id);
                ct.TENCT = txtTEN.Text;
                ct.EMAIL = txtEmail.Text;
                ct.DIENTHOAI = txtSDT.Text;
                ct.DIACHI = txtDIACHI.Text;
                _congty.Update(ct);
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcDanhsach_Click(object sender, EventArgs e)
        {

        }

        private void FormCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _congty = new CONGTY();
            showHide(true);
            loadData();
        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("MACT").ToString());
                txtTEN.Text = gvDanhsach.GetFocusedRowCellValue("TENCT").ToString();
                txtEmail.Text = gvDanhsach.GetFocusedRowCellValue("EMAIL").ToString();
                txtSDT.Text = gvDanhsach.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtDIACHI.Text = gvDanhsach.GetFocusedRowCellValue("DIACHI").ToString();
            }
        }
    }
}