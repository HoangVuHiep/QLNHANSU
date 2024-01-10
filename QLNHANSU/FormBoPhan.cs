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
    public partial class FormBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public FormBoPhan()
        {
            InitializeComponent();
        }
        BOPHAN _bophan;
        bool _them;
        int _id;
        private void gcDanhsach_Click(object sender, EventArgs e)
        {

        }

        private void FormBoPhan_Load(object sender, EventArgs e)
        {
            _them = false;
            _bophan = new BOPHAN();
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
        }
        void loadData()
        {
            gcDanhsach.DataSource = _bophan.getList();
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtTEN.Text = string.Empty;
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
                _bophan.Delete(_id);
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
                tb_BOPHAN bp = new tb_BOPHAN();
                bp.TENBP = txtTEN.Text;
                _bophan.Add(bp);
            }
            else
            {
                var bp = _bophan.getItem(_id);
                bp.TENBP = txtTEN.Text;
                _bophan.Update(bp);
            }

        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDBP").ToString());
                txtTEN.Text = gvDanhsach.GetFocusedRowCellValue("TENBP").ToString();
            }
        }
    }
}