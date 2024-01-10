using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;
using System.Collections.Generic;

namespace QLNHANSU.Report
{
    public partial class rptHopDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDong()
        {
            InitializeComponent();
        }
        public rptHopDong(List<HOPDONG_DTO> lstHD)
        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD;
            loadData();
        }
        List<HOPDONG_DTO> _lstHD;
        void loadData()
        {
            lblSOHD.DataBindings.Add("Text", _lstHD, "SOHD");
        }
    }
}
