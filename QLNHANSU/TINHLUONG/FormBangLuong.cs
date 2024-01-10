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
using BusinessLayer;
namespace QLNHANSU.TINHLUONG
{
    public partial class FormBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }
        BANGLUONG _bangluong;
        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            _bangluong = new BANGLUONG();
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
        }
        private void btnTINHLUONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.Delete(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            _bangluong.TinhLuongNhanVien(int.Parse(cboNam.Text) *100 + int.Parse(cboThang.Text));
            LoadData();
        }
        void LoadData()
        {
            gcDanhsach.DataSource = _bangluong.getList(int.Parse(cboNam.Text) *100 + int.Parse(cboThang.Text));
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}