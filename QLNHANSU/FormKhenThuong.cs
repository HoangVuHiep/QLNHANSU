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
    public partial class FormKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public FormKhenThuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KHENTHUONGKYLUAT _ktkl;
        NHANVIEN _nhanvien;
        private void FormKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONGKYLUAT();
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
            txtNOIDUNG.Enabled = !kt;
            txtLYDO.Enabled = !kt;
            //dtNGAYBATDAU.Enabled = !kt;
            //dtNGAYKETTHUC.Enabled = !kt;
            slkNHANVIEN.Enabled = !kt;
        }
        void _reset()
        {
            txtSOQD.Text = string.Empty;
            txtLYDO.Text = string.Empty;
            txtNOIDUNG.Text = string.Empty;
            //dtNGAYBATDAU.Value = DateTime.Now;
            //dtNGAYKETTHUC.Value = dtNGAYBATDAU.Value.AddMonths(6);
      

        }
        void loadNhanVien()
        {
            slkNHANVIEN.Properties.DataSource = _nhanvien.getList();
            slkNHANVIEN.Properties.ValueMember = "MANV";
            slkNHANVIEN.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhsach.DataSource = _ktkl.getListFull(1);
            gvDanhsach.OptionsBehavior.Editable = false;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
                _ktkl.Delete(_soQD,1);
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
            if (_them)
            {
                // Số hđ có dạng: 00001/2023/HĐLĐ
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5) + 1);
                tb_KHENTHUONG_KYLUAT kt = new tb_KHENTHUONG_KYLUAT();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2023/QĐKT";
                //hd.NGAYBATDAU = dtNGAYBATDAU.Value;
                //hd.NGAYKETTHUC = dtNGAYKETTHUC.Value;
                kt.LYDO = txtLYDO.Text;
                kt.NGAY = dtNGAY.Value;
                kt.NOIDUNG = txtNOIDUNG.Text;
                kt.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                kt.LOAI = 1;
                kt.CREATED_BY = 1;
                kt.CREATED_DATE = DateTime.Now;
                _ktkl.Add(kt);
            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                //hd.NGAYBATDAU = dtNGAYBATDAU.Value;
                //hd.NGAYKETTHUC = dtNGAYKETTHUC.Value;
                kt.LYDO = txtLYDO.Text;
                kt.NGAY = dtNGAY.Value;
                kt.NOIDUNG = txtNOIDUNG.Text;
                kt.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                kt.UPDATE_BY = 1;
                kt.UPDATE_DATE = DateTime.Now;
                _ktkl.Update(kt);
            }

        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _soQD = gvDanhsach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSOQD.Text = _soQD;
                //dtNGAYBATDAU.Value = hd.NGAYBATDAU.Value;
                //dtNGAYKETTHUC.Value = hd.NGAYKETTHUC.Value;
                dtNGAY.Value = kt.NGAY.Value;
                slkNHANVIEN.EditValue = kt.MANV;
                txtNOIDUNG.Text = kt.NOIDUNG;
                txtLYDO.Text = kt.LYDO;
                //_lstHD = _hdld.getItemFull(_soHD);
            }
        }

        
    }
}