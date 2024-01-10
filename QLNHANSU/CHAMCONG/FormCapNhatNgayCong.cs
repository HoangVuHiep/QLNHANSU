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
using System.Data.SqlClient;

namespace QLNHANSU
{
    public partial class FormCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public FormCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;
        KYCONGCHITIET _kcct;
        BANGCONG_NV_CT _bcct_nv;
        FormBangCongCT frmBCCC =(FormBangCongCT) Application.OpenForms["FormBangCongCT"];
        private void FormCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct_nv = new BANGCONG_NV_CT();
            lbID.Text = _manv.ToString();
            lbHoTen.Text = _hoten;
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNGAYCONG.SetDate(_d);
        }

        private void btnCAPNHAT_Click(object sender, EventArgs e)
        {
            
            string _valueChamCong = rdgCHAMCONG.Properties.Items[rdgCHAMCONG.SelectedIndex].Value.ToString();
            string _valueNgayNghi = rdgTHOIGIANNGHI.Properties.Items[rdgTHOIGIANNGHI.SelectedIndex].Value.ToString();
            string fieldname = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);

            //double? tongngaycong = kcct.TONGNGAYCONG;
            //double? tongngayphep = kcct.NGAYPHEP;
            //double? tongngaykhongphep = kcct.NGHIKHONGPHEP;
            //double? tongngayle = kcct.CONGNGAYLE;
            if (cldNGAYCONG.SelectionRange.Start.Year*100+cldNGAYCONG.SelectionRange.Start.Month!=+_makycong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kì công. Vui lòng kiểm tra lại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information );
                return;
            }

            //HFunctions.execQuery("UPDATE tb_KYCONGCHITIET SET" + fieldname + "= '" + _valueChamCong + "' WHERE MAKYCONG=" + _makycong + "AND MANV=" + _manv);
            string query = "UPDATE tb_KYCONGCHITIET SET " + fieldname + " = @ValueChamCong WHERE MAKYCONG = @MaKyCong AND MANV = @MaNV";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ValueChamCong", SqlDbType.VarChar) { Value = _valueChamCong },
                new SqlParameter("@MaKyCong", SqlDbType.Int) { Value = _makycong },
                new SqlParameter("@MaNV", SqlDbType.Int) { Value = _manv }
            };

            HFunctions.execQuery(query, parameters);

            tb_BANCONG_NV_CT bcctnv = _bcct_nv.getItem(_makycong, _manv, cldNGAYCONG.SelectionStart.Day);
            
            if (cldNGAYCONG.SelectionStart.DayOfWeek==DayOfWeek.Sunday)
            {
                if (_valueNgayNghi == "NN")
                {
                    bcctnv.CONGCHUNHAT = 1;
                    bcctnv.NGAYCONG = 0;

                }
                else
                {
                    bcctnv.CONGCHUNHAT = 0.5;
                    bcctnv.NGAYCONG = 0;

                }
            }
            else
            {
                bcctnv.KYHIEU = _valueChamCong;
                switch (_valueChamCong)
                {
                    case "P":

                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYPHEP = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;

                        }
                        break;
                    case "CT":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 1;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    case "V":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 0;
                            bcctnv.NGAYPHEP = 0;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    case "VR":
                        if (_valueNgayNghi == "NN")
                        {
                            bcctnv.NGAYCONG = 0;
                            bcctnv.NGAYPHEP = 0;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    default:
                        break;
                }
            }
            
            _bcct_nv.Update(bcctnv);
            double congchunhat = _bcct_nv.tongNgayCongChuNhat(_makycong, _manv);
            double tongngaycong = _bcct_nv.tongNgayCong(_makycong, _manv);
            double tongngayphep = _bcct_nv.tongNgayPhep(_makycong, _manv);
            kcct.CONGCHUNHAT = congchunhat;
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG = tongngaycong;
            _kcct.Update(kcct);
            frmBCCC.loadBangCong();
            //tb_KYCONGCHITIET kcct = _kcct.getItem(_makycong, _manv);
            // MessageBox.Show(_valueChamCong+"--"+_valueNgayNghi);
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cldNGAYCONG_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldNGAYCONG.SelectionRange.Start.Day;
        }
    }
}