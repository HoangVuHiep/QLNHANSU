using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO
{
    public class NHANVIEN_DC_DTO
    {
        public string SOQD { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { set; get; }
        public Nullable<int> IDPB { get; set; }
        public string TENPB { set; get; }
        public Nullable<int> MAPB2 { get; set; }
        public string TENPB2 { set; get; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }

    }
}
