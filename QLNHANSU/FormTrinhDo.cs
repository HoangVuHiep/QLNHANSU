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
    public partial class FormTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public FormTrinhDo()
        {
            InitializeComponent();
        }
        TRINHDO _trinhdo;
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
        }
        void loadData()
        {
            gcDanhsach.DataSource = _trinhdo.getList();
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
                _trinhdo.Delete(_id);
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

        }

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FormTrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _trinhdo = new TRINHDO();
            showHide(true);
            loadData();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_TRINHDO td = new tb_TRINHDO();
                td.TENTD = txtTEN.Text;
                _trinhdo.Add(td);
            }
            else
            {
                var td = _trinhdo.getItem(_id);
                td.TENTD = txtTEN.Text;
                _trinhdo.Update(td);
            }

        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDTD").ToString());
            txtTEN.Text = gvDanhsach.GetFocusedRowCellValue("TENTD").ToString();
        }
    }
}