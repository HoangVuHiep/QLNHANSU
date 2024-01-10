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

namespace QLNHANSU.CHAMCONG
{
    public partial class FormLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        public FormLoaiCa()
        {
            InitializeComponent();
        }
        LOAICA _loaica;
        bool _them;
        int _id;

        private void FormLoaiCa_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaica = new LOAICA();
            showHide(true);
            loadData();
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
            txtTEN.Enabled = !kt;
            spHESO.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhsach.DataSource = _loaica.getList();
            gvDanhsach.OptionsBehavior.Editable = false;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtTEN.Text = string.Empty;
            spHESO.EditValue = 1;
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
                _loaica.Delete(_id,1);
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
                tb_LOAICA lc = new tb_LOAICA();
                lc.TENLOAICA = txtTEN.Text;
                lc.HESO = double.Parse(spHESO.EditValue.ToString());
                lc.CREATED_BY = 1;
                lc.CREATED_DATE = DateTime.Now;
                _loaica.Add(lc);
            }
            else
            {
                var lc = _loaica.getItem(_id);
                lc.TENLOAICA = txtTEN.Text;
                lc.HESO = double.Parse(spHESO.EditValue.ToString());
                lc.CREATED_BY = 1;
                lc.CREATED_DATE = DateTime.Now;
                _loaica.Update(lc);
            }

        }
        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDLOAICA").ToString());
                txtTEN.Text = gvDanhsach.GetFocusedRowCellValue("TENLOAICA").ToString();
                spHESO.Text = gvDanhsach.GetFocusedRowCellValue("HESO").ToString();

            }
        }
    }
}