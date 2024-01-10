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
using System.Data.Entity;

namespace QLNHANSU
{
    public partial class FormDanToc : DevExpress.XtraEditors.XtraForm
    {
        public FormDanToc()
        {
            InitializeComponent();

        }
        DANTOC _dantoc;
        bool _them;
        int _id;
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _dantoc = new DANTOC();
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
            gcDanhsach.DataSource = _dantoc.getList();
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtTEN.Text = string.Empty;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _dantoc.Delete(_id);
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
                tb_DANTOC dt = new tb_DANTOC();
                dt.TENDT = txtTEN.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TENDT = txtTEN.Text;
                _dantoc.Update(dt);
            }    

        }

        private void gcDanhsach_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDDT").ToString());
            txtTEN.Text = gvDanhsach.GetFocusedRowCellValue("TENDT").ToString();
        }
    }
}