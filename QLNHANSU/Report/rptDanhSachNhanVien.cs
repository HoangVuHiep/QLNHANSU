using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using BusinessLayer.DTO;
namespace QLNHANSU.Report
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NHANVIEN_DTO> _lstNV;
        public rptDanhSachNhanVien(List<NHANVIEN_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            loadData();
        }
        void loadData()
        {
            lblMANV.DataBindings.Add("Text", _lstNV, "MANV");
            lblHOTEN.DataBindings.Add("Text", _lstNV, "HOTEN");
            lblGIOITINH.DataBindings.Add("Text", _lstNV, "GIOITINH");
            lblNGAYSINH.DataBindings.Add("Text", _lstNV, "NGAYSINH");
            lblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lblDIENTHOAI.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
            lblPHONGBAN.DataBindings.Add("Text", _lstNV, "TENPB");
            lblCHUCVU.DataBindings.Add("Text", _lstNV, "TENCHUCVU");
            lblTRINHDO.DataBindings.Add("Text", _lstNV, "TENTD");
            lblDANTOC.DataBindings.Add("Text", _lstNV, "TENDT");
            lblTONGIAO.DataBindings.Add("Text", _lstNV, "TENTG");
            lblDIACHI.DataBindings.Add("Text", _lstNV, "DIACHI");
        }
    }
}
