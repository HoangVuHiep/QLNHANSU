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
using QLNHANSU.Report;
using DevExpress.XtraReports.UI;
using BusinessLayer.DTO;

namespace QLNHANSU
{
    public partial class FormHopDong : DevExpress.XtraEditors.XtraForm
    {
        public FormHopDong()
        {
            InitializeComponent();
        }
        HOPDONG _hdld;
        NHANVIEN _nhanvien;
        bool _them;
        string _soHD;
        string _MaxSoHD;
        List<HOPDONG_DTO> _lstHD;
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
            txtSOHD.Enabled = !kt;
            dtNGAYBATDAU.Enabled = !kt;
            dtNGAYKETTHUC.Enabled = !kt;
            dtNGAYKY.Enabled = !kt;
            spHESOLUONG.Enabled = !kt;
            spLANKY.Enabled = !kt;
            slkNHANVIEN.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
        }
        void _reset()
        {
            txtSOHD.Text = string.Empty;
            dtNGAYBATDAU.Value = DateTime.Now;
            dtNGAYKETTHUC.Value = dtNGAYBATDAU.Value.AddMonths(6);
            dtNGAYKY.Value = DateTime.Now;
            spLANKY.Text = "1";
            spHESOLUONG.Text = "1";

        }
        void loadNhanVien()
        {
            slkNHANVIEN.Properties.DataSource = _nhanvien.getList();
            slkNHANVIEN.Properties.ValueMember = "MANV";
            slkNHANVIEN.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhsach.DataSource = _hdld.getListFull();
            gvDanhsach.OptionsBehavior.Editable = false;
            
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
                _hdld.Delete(_soHD,1);
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
            _lstHD = _hdld.getItemFull(_soHD);
            rptHopDong rpt = new rptHopDong(_lstHD);
            rpt.ShowPreviewDialog();
        }
        void SaveData()
        {
            if (_them)
            {
                // Số hđ có dạng: 00001/2023/HĐLĐ
                var maxSoHD = _hdld.MaxSoHopDong();
                int so = int.Parse(maxSoHD.Substring(0, 5) + 1);
                tb_HOPDONG hd = new tb_HOPDONG();
                hd.SOHD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString() + @"/HĐLĐ";
                hd.NGAYBATDAU = dtNGAYBATDAU.Value;
                hd.NGAYKETTHUC = dtNGAYKETTHUC.Value;
                hd.NGAYKY = dtNGAYKY.Value;
                hd.THOIHAN = cboTHOIHAN.Text;
                hd.HESOLUONG = double.Parse(spHESOLUONG.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongCoBan.EditValue.ToString());
                hd.LANKY = int.Parse(spLANKY.EditValue.ToString());
                hd.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                hd.NOIDUNG = txtNoiDung.RtfText;
                hd.MACT = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Add(hd);
            }
            else
            {
                var hd = _hdld.getItem(_soHD);       
                hd.NGAYBATDAU = dtNGAYBATDAU.Value;
                hd.NGAYKETTHUC = dtNGAYKETTHUC.Value;
                hd.NGAYKY = dtNGAYKY.Value;
                hd.THOIHAN = cboTHOIHAN.Text;
                hd.HESOLUONG = double.Parse(spHESOLUONG.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongCoBan.EditValue.ToString());
                hd.LANKY = int.Parse(spLANKY.EditValue.ToString());
                hd.MANV = int.Parse(slkNHANVIEN.EditValue.ToString());
                hd.NOIDUNG = txtNoiDung.RtfText;
                hd.MACT = 1;
                hd.UPDATE_BY = 1;
                hd.UPDATE_DATE = DateTime.Now;
                _hdld.Update(hd);
            }

        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            _hdld = new HOPDONG();
            _nhanvien = new NHANVIEN();
            _them = false;
            showHide(true);
            loadData();
            loadNhanVien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _soHD = gvDanhsach.GetFocusedRowCellValue("SOHD").ToString();
                var hd = _hdld.getItem(_soHD);
                txtSOHD.Text = _soHD;
                dtNGAYBATDAU.Value = hd.NGAYBATDAU.Value;
                dtNGAYKETTHUC.Value = hd.NGAYKETTHUC.Value;
                dtNGAYKY.Value = hd.NGAYKY.Value;
                cboTHOIHAN.Text = hd.THOIHAN;
                spHESOLUONG.EditValue = hd.HESOLUONG;
                spLuongCoBan.EditValue = hd.LUONGCOBAN;
                spLANKY.Text = hd.LANKY.ToString();
                slkNHANVIEN.EditValue = hd.MANV;
                txtNoiDung.RtfText= hd.NOIDUNG;
                _lstHD = _hdld.getItemFull(_soHD);
            }
        }
    }
}