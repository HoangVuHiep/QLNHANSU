using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;
namespace BusinessLayer
{
    public class HOPDONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_HOPDONG getItem(string id)
        {
            return db.tb_HOPDONG.FirstOrDefault(x=>x.SOHD==id);
        }
        public List<HOPDONG_DTO> getItemFull(string sohd)
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x=>x.SOHD==sohd).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");//"Từ ngày" + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(0, 2) + "tháng" + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(3, 2) + "năm" + item.NGAYBATDAU.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");//"Đến ngày" + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(0, 2) + "tháng" + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(3, 2) + "năm" + item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKY = item.NGAYKY.ToString();
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;

                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACT = item.MACT;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
        public List<tb_HOPDONG>getList()
        {
            return db.tb_HOPDONG.ToList();
        }
        public List<HOPDONG_DTO> getListFull()
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = item.NGAYKY.ToString();
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;

                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACT = item.MACT;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
        public tb_HOPDONG Add(tb_HOPDONG hd)
        {
            try
            {
                db.tb_HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tb_HOPDONG Update(tb_HOPDONG hd)
        {
            try
            {
                var _hd= db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBATDAU = hd.NGAYBATDAU;
                _hd.NGAYKETTHUC = hd.NGAYKETTHUC;
                _hd.MANV = hd.MANV;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.LANKY = hd.LANKY;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.LUONGCOBAN = hd.LUONGCOBAN;
                _hd.NOIDUNG = hd.NOIDUNG;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.SOHD = hd.SOHD;
                _hd.MACT = hd.MACT;
                _hd.UPDATE_BY = hd.UPDATE_BY;
                _hd.UPDATE_DATE = hd.UPDATE_DATE;
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(string id,int manv)
        {
            var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == id);
          
            _hd.DELETED_BY= manv;
            _hd.DELETED_DATE = DateTime.Now;
            db.SaveChanges();
        }
        public string MaxSoHopDong()
        {
            var _hd = db.tb_HOPDONG.OrderByDescending(x=>x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOHD;
            }
            else
                return "00000";
        }
        public List<HOPDONG_DTO> getLenluong()
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x=>(x.NGAYBATDAU.Value.Day-DateTime.Now.Day)==0 && (x.NGAYBATDAU.Value.Month - DateTime.Now.Month) == 0 &&
            (DateTime.Now.Year -  x.NGAYBATDAU.Value.Year )== 2).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBATDAU = item.NGAYBATDAU.Value.ToString("dd/MM/yyyy");
                hd.NGAYKETTHUC = item.NGAYKETTHUC.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = item.NGAYKY.ToString();
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;

                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACT = item.MACT;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
    }
}
