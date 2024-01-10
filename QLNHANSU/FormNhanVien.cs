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
using System.IO;
using QLNHANSU.Report;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
namespace QLNHANSU
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        CHUCVU _chucvu;
        TRINHDO _trinhdo;
        PHONGBAN _phongban;
        BOPHAN _bophan;
        bool _them;
        int _id;
        private Image _hinh;
        List<NHANVIEN_DTO> _lstNVDTO;
        void loadCombo()
        {
            cboBOPHAN.DataSource = _bophan.getList();
            cboBOPHAN.DisplayMember = "TENBP";
            cboBOPHAN.ValueMember = "IDBP";

            cboPHONGBAN.DataSource = _phongban.getList();
            cboPHONGBAN.DisplayMember = "TENPB";
            cboPHONGBAN.ValueMember = "IDPB";

            cboTRINHDO.DataSource = _trinhdo.getList();
            cboTRINHDO.DisplayMember = "TENTD";
            cboTRINHDO.ValueMember = "IDTD";

            cboCHUCVU.DataSource = _chucvu.getList();
            cboCHUCVU.DisplayMember = "TENCHUCVU";
            cboCHUCVU.ValueMember = "IDCV";

            cboDANTOC.DataSource = _dantoc.getList();
            cboDANTOC.DisplayMember = "TENDT";
            cboDANTOC.ValueMember = "IDDT";

            cboTONGIAO.DataSource = _tongiao.getList();
            cboTONGIAO.DisplayMember = "TENTG";
            cboTONGIAO.ValueMember = "IDTG";
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
            txtDIENTHOAI.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDIACHI.Enabled = !kt;
            chkGIOITINH.Enabled = !kt;
            //picHINHANH.Enabled = !kt;
            cboBOPHAN.Enabled = !kt;
            cboPHONGBAN.Enabled = !kt;
            cboTRINHDO.Enabled = !kt;
            cboCHUCVU.Enabled = !kt;
            cboDANTOC.Enabled = !kt;
            cboTONGIAO.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            dtNGAYSINH.Enabled = !kt;
            gcDanhsach.Enabled = kt;
        }
        void _reset()
        {
            txtTEN.Text = string.Empty;
            txtDIENTHOAI.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDIACHI.Text = string.Empty;
            chkGIOITINH.Checked = false;

        }
        void loadData()
        {
            gcDanhsach.DataSource = _nhanvien.getListFull();
            gvDanhsach.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();
        }
        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void picHINHANH_Click(object sender, EventArgs e)
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
            picHINHANH.Image = _hinh;
            splitContainer1.Panel1Collapsed = false;
            gcDanhsach.Enabled = true;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
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
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);
            rpt.ShowRibbonPreview();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.HOTEN = txtTEN.Text;
                nv.GIOITINH = chkGIOITINH.Checked;
                nv.NGAYSINH = dtNGAYSINH.Value;
                nv.DIENTHOAI = txtDIENTHOAI.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDIACHI.Text;
                nv.HINHANH = ImageToBase64(picHINHANH.Image, picHINHANH.Image.RawFormat);
                nv.IDBP = int.Parse(cboBOPHAN.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPHONGBAN.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTRINHDO.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboCHUCVU.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDANTOC.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTONGIAO.SelectedValue.ToString());
                nv.MACT = 1;
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtTEN.Text;
                nv.GIOITINH = chkGIOITINH.Checked;
                nv.NGAYSINH = dtNGAYSINH.Value;
                nv.DIENTHOAI = txtDIENTHOAI.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDIACHI.Text;
                nv.HINHANH = ImageToBase64(picHINHANH.Image, picHINHANH.Image.RawFormat);
                nv.IDBP = int.Parse(cboBOPHAN.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPHONGBAN.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTRINHDO.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboCHUCVU.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDANTOC.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTONGIAO.SelectedValue.ToString());
                nv.MACT = 1;
                _nhanvien.Update(nv);
            }

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NHANVIEN();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            _chucvu = new CHUCVU();
            _trinhdo = new TRINHDO();
            _phongban =  new PHONGBAN();
            _bophan = new BOPHAN();
            showHide(true);
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
        }


        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtTEN.Text =nv.HOTEN;
                chkGIOITINH.Checked = nv.GIOITINH.Value;
                dtNGAYSINH.Value = nv.NGAYSINH.Value;
                txtDIENTHOAI.Text = nv.DIENTHOAI;
                txtCCCD.Text = nv.CCCD;
                txtDIACHI.Text = nv.DIACHI;
                picHINHANH.Image = Base64ToImage(nv.HINHANH);
                cboBOPHAN.SelectedValue = nv.IDBP;
                cboPHONGBAN.SelectedValue = nv.IDBP;
                cboTRINHDO.SelectedValue = nv.IDTD;
                cboCHUCVU.SelectedValue = nv.IDCV;
                cboDANTOC.SelectedValue = nv.IDDT;
                cboTONGIAO.SelectedValue = nv.IDTG;
                //nv.MACT = 1;

            }
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }    
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                picHINHANH.Image = Image.FromFile(openFile.FileName);
                picHINHANH.SizeMode = PictureBoxSizeMode.StretchImage;
            }    
        }
    }
}