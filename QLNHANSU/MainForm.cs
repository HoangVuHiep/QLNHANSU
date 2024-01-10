using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using System.Data.Entity;
using QLNHANSU.CHAMCONG;
using QLNHANSU.TINHLUONG;

namespace QLNHANSU
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void openform(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if(frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        NHANVIEN _nhanvien;
        HOPDONG _hopdong;
        private void MainForm_Load(object sender,EventArgs e)
        {
            _nhanvien = new NHANVIEN();
            _hopdong = new HOPDONG();
            ribbonControl1.SelectedPage = ribbonPage2;

            
        }


        private void btnDANTOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormDanToc));
        }

        private void btnTONGIAO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormTonGiao));
        }

        private void btnTRINHDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormTrinhDo));
        }

        private void btnPHONGBAN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormPhongBan));
        }

        private void btnCONGTY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormCongTy));
        }

        private void btnBOPHAN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormBoPhan));
        }

        private void btnCHUCVU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormChucVu));
        }

        private void btnNHANVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormNhanVien));
        }

        private void btnHOPDONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormHopDong));
        }

        private void btnKHENTHUONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormKhenThuong));
        }

        private void btnKILUAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormKyLuat));
        }

        private void btnDIEUCHUYEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormNHANVIENDC));
        }

        private void btnTHOIVIEC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormNhanVien_TV));
        }

        private void btnQUNANLYLUONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormQuanLyLuong));
        }

        private void btnLOAICA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormLoaiCa));
        }

        private void btnLOAICONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormLoaiCong));
        }

        private void btnBANGCONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormBangCong));
        }

        private void btnPHUCAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormPhuCap));
        }

        private void btnTANGCA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormTangCa));
        }

        private void btnUNGLUONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormUngLuong));
        }

        private void btnBANGLUONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openform(typeof(FormBangLuong));
        }
    }
}
