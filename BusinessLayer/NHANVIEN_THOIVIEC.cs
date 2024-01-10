using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;
namespace BusinessLayer
{
    public class NHANVIEN_THOIVIEC
    {

        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_THOIVIEC getItem(string soqd)
        {
            return db.tb_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
        }
           public List<tb_NHANVIEN_THOIVIEC> getList()
        {
            return db.tb_NHANVIEN_THOIVIEC.ToList();
        }
        public List<NHANVIEN_TV_DTO> getListFull()
        {
            var lstTV = db.tb_NHANVIEN_THOIVIEC.ToList();
            List<NHANVIEN_TV_DTO> lstDTO = new List<NHANVIEN_TV_DTO>();
            NHANVIEN_TV_DTO nvDTO;
            foreach (var item in lstTV)
            {
                nvDTO = new NHANVIEN_TV_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.NGAYNOPDON = item.NGAYNOPDON;
                nvDTO.NGAYNGHI = item.NGAYNGHI;
                nvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;
                nvDTO.LYDO = item.LYDO;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.CREATE_BY = item.CREATE_BY;
                nvDTO.CREATE_DATE = item.CREATE_DATE;
                nvDTO.UPDATE_BY = item.UPDATE_BY;
                nvDTO.UPDATE_DATE = item.UPDATE_DATE;
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public tb_NHANVIEN_THOIVIEC Add(tb_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                db.tb_NHANVIEN_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch ( Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public tb_NHANVIEN_THOIVIEC Update(tb_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                var _tv= db.tb_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.MANV = tv.MANV;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.LYDO = tv.LYDO;
                _tv.GHICHU = tv.GHICHU;
                _tv.UPDATE_BY = tv.UPDATE_BY;
                _tv.UPDATE_DATE = tv.UPDATE_DATE;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public void Delete(string soqd,int iduser)
        {
            try
            {
                var _tv = db.tb_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
                
                _tv.DELETED_BY = iduser;
                _tv.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _hd = db.tb_NHANVIEN_THOIVIEC.OrderByDescending(x => x.CREATE_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQD;
            }
            else
                return "00000";
        }
    }
}
