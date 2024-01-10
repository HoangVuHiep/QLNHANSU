using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;
namespace BusinessLayer
{
    public class NHANVIEN_DIEUCHUYEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_DIEUCHUYEN getItem(string soqd)
        {
            return db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
        }
        public List<tb_NHANVIEN_DIEUCHUYEN> getList()
        {
            return db.tb_NHANVIEN_DIEUCHUYEN.ToList();
        }
        public List<NHANVIEN_DC_DTO> getListFull()
        {
            var lstDC = db.tb_NHANVIEN_DIEUCHUYEN.ToList();
            List<NHANVIEN_DC_DTO> lstDTO = new List<NHANVIEN_DC_DTO>();
            NHANVIEN_DC_DTO nvDTO;
            foreach (var item in lstDC)
            {
                nvDTO = new NHANVIEN_DC_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.NGAY = item.NGAY;
                nvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;
                nvDTO.IDPB = item.IDPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB == item.IDPB);
                nvDTO.TENPB = pb.TENPB;
                nvDTO.MAPB2 = item.MAPB2;
                var pb2 = db.tb_PHONGBAN.FirstOrDefault(p2 => p2.IDPB == item.MAPB2);
                nvDTO.TENPB2 = pb2.TENPB;
                nvDTO.LYDO = item.LYDO;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.CREATED_BY = item.CREATED_BY;
                nvDTO.CREATED_DATE = item.CREATED_DATE;
                nvDTO.UPDATE_BY = item.UPDATE_BY;
                nvDTO.UPDATE_DATE = item.UPDATE_DATE;
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public tb_NHANVIEN_DIEUCHUYEN Add(tb_NHANVIEN_DIEUCHUYEN dc)
        {
            try
            {
                db.tb_NHANVIEN_DIEUCHUYEN.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public tb_NHANVIEN_DIEUCHUYEN Update(tb_NHANVIEN_DIEUCHUYEN dc)
        {
            try
            {
                var _dc = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == dc.SOQD);
                _dc.MAPB2 = dc.MAPB2;
                _dc.MANV = dc.MANV;
                _dc.NGAY = dc.NGAY;
                _dc.LYDO = dc.LYDO;
                _dc.GHICHU = dc.GHICHU;
                _dc.UPDATE_BY = dc.UPDATE_BY;
                _dc.UPDATE_DATE = dc.UPDATE_DATE;
                db.SaveChanges();
                return dc;
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
                var _dc = db.tb_NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
                _dc.DELETED_BY = iduser;
                _dc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _hd = db.tb_NHANVIEN_DIEUCHUYEN.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQD;
            }
            else
                return "00000";
        }
    }
}
