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
    public partial class FormQuanLyLuong : DevExpress.XtraEditors.XtraForm
    {
        public FormQuanLyLuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NHANVIEN_NANGLUONG _nvnl;
        HOPDONG _hopdong;
        NHANVIEN _nv;
        private void FormQuanLyLuong_Load(object sender, EventArgs e)
        {
            _nvnl = new NHANVIEN_NANGLUONG();
            _hopdong = new HOPDONG();
            _nv = new NHANVIEN();
            _them = false;
            showHide(true);
            loadHopDong();
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
            txtGHICHU.Enabled = !kt;
            slkHOPDONG.Enabled = !kt;
            dtNGAYLENLUONG.Enabled = !kt;
        }
        void _reset()
        {
            txtSOQD.Text = string.Empty;
            txtGHICHU.Text = string.Empty;
            dtNGAYLENLUONG.Value = DateTime.Now;
            dtNGAYKY.Value = dtNGAYLENLUONG.Value.AddDays(45);

        }
        void loadHopDong()
        {
            slkHOPDONG.Properties.DataSource = _hopdong.getList();
            slkHOPDONG.Properties.ValueMember = "SOHD";
            slkHOPDONG.Properties.DisplayMember = "SOHD";
        }

        void loadData()
        {
            gcDanhsach.DataSource = _nvnl.getListFull();
            gvDanhsach.OptionsBehavior.Editable = false;

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
                _nvnl.Delete(_soQD, 1);
                var hd = _hopdong.getItem(slkHOPDONG.EditValue.ToString());
                hd.HESOLUONG = double.Parse(spHSLCU.EditValue.ToString());
                _hopdong.Update(hd);
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
            tb_NHANVIEN_LENLUONG nl;
            if (_them)
            {

                var maxSoQD = _nvnl.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5) + 1);
                nl = new tb_NHANVIEN_LENLUONG();
                nl.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐNL";
                nl.SOHD = slkHOPDONG.EditValue.ToString();
                nl.NGAYKY = dtNGAYKY.Value;
                nl.NGAYLENLUONG = dtNGAYLENLUONG.Value;
                nl.HESOLUONGHIENTAI = _hopdong.getItem(slkHOPDONG.EditValue.ToString()).HESOLUONG;
                nl.HESOLUONGMOI = double.Parse(spHSLMOI.EditValue.ToString());
                nl.GHICHU = txtGHICHU.Text;
                nl.MANV = _hopdong.getItem(slkHOPDONG.EditValue.ToString()).MANV;
                nl.CREATED_BY = 1;
                nl.CREATED_DATE = DateTime.Now;
                _nvnl.Add(nl);
            }
            else
            {
                nl = _nvnl.getItem(_soQD);
                nl.SOHD = slkHOPDONG.EditValue.ToString();
                nl.NGAYKY = dtNGAYKY.Value;
                nl.NGAYLENLUONG = dtNGAYLENLUONG.Value;
                nl.HESOLUONGHIENTAI = _hopdong.getItem(slkHOPDONG.EditValue.ToString()).HESOLUONG;
                nl.HESOLUONGMOI = double.Parse(spHSLMOI.EditValue.ToString());
                nl.GHICHU = txtGHICHU.Text;
                nl.MANV = _hopdong.getItem(slkHOPDONG.EditValue.ToString()).MANV;
                nl.UPDATED_BY = 1;
                nl.UPDATED_DATE = DateTime.Now;
                _nvnl.Update(nl);
            }
            var hd = _hopdong.getItem(slkHOPDONG.EditValue.ToString());
            hd.HESOLUONG = double.Parse(spHSLMOI.EditValue.ToString());
            _hopdong.Update(hd);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            if (gvDanhsach.RowCount > 0)
            {
                _soQD = gvDanhsach.GetFocusedRowCellValue("SOQD").ToString();
                var nl = _nvnl.getItem(_soQD);
                txtSOQD.Text = _soQD;
                dtNGAYLENLUONG.Value = nl.NGAYLENLUONG.Value;
                dtNGAYKY.Value = nl.NGAYKY.Value;
                slkHOPDONG.EditValue = nl.SOHD;
                txtGHICHU.Text = nl.GHICHU;
                spHSLCU.EditValue = nl.HESOLUONGHIENTAI;
                spHSLMOI.EditValue = nl.HESOLUONGMOI;
                txtNHANVIEN.Text = gvDanhsach.GetFocusedRowCellValue("HOTEN").ToString();
            }
        }

        private void gvDanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.images;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void slkHOPDONG_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hopdong.getItemFull(slkHOPDONG.EditValue.ToString());
            if(hd.Count!=0)
                {
                txtNHANVIEN.Text = hd[0].MANV +" - " +hd[0].HOTEN;
                spHSLCU.EditValue = hd[0].HESOLUONG;
            }
        }
    }
}