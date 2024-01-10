using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;
namespace BusinessLayer
{
    public class PHUCAP
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_NHANVIEN_PHUCAP getItem(int id)
        {
            return db.tb_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == id);
        }
        public List<NHANVIEN_PHUCAP_DTO> getListFull()
        {
            var lstNVPC = db.tb_NHANVIEN_PHUCAP.ToList();
            List<NHANVIEN_PHUCAP_DTO> lstDTO = new List<NHANVIEN_PHUCAP_DTO>();
            NHANVIEN_PHUCAP_DTO nvpc;
            NHANVIEN _nhanvien = new NHANVIEN();
            foreach(var item in lstNVPC )
            {
                nvpc = new NHANVIEN_PHUCAP_DTO();
                nvpc.ID = item.ID;
                nvpc.MANV = item.MANV;
                var nv = _nhanvien.getItemFull(int.Parse(item.MANV.ToString()));
                nvpc.HOTEN = nv.HOTEN;
                nvpc.TENCV = nv.TENCHUCVU;
                nvpc.IDPC = item.IDPC;
                var pc = db.tb_PHUCAP.FirstOrDefault(x => x.IDPC == item.IDPC);
                nvpc.TENPC = pc.TENPC;
                nvpc.NOIDUNG = item.NOIDUNG;
                nvpc.NGAY = item.NGAY;
                nvpc.SOTIEN = item.SOTIEN;
                nvpc.CREATED_BY = item.CREATED_BY;
                nvpc.CREATED_DATE = item.CREATED_DATE;
                nvpc.UPDATE_BY = item.UPDATE_BY;
                nvpc.UPDATE_DATE = item.UPDATE_DATE;
                nvpc.DELETED_BY = item.DELETED_BY;
                nvpc.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nvpc);
            }
            return lstDTO;
        }
        public tb_PHUCAP getItemPC(int id)
        {
            return db.tb_PHUCAP.FirstOrDefault(x=> x.IDPC == id);
        }
        public List<tb_PHUCAP> getListPC()
        {
            return db.tb_PHUCAP.ToList();
        }
        public tb_NHANVIEN_PHUCAP Add(tb_NHANVIEN_PHUCAP pc)
        {
            try
            {
                db.tb_NHANVIEN_PHUCAP.Add(pc);
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public tb_NHANVIEN_PHUCAP Update(tb_NHANVIEN_PHUCAP pc)
        {
            try
            {
                var _pc = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == pc.ID);
                _pc.IDPC = pc.IDPC;
                _pc.MANV = pc.MANV;
                _pc.NGAY = pc.NGAY;
                _pc.NOIDUNG = pc.NOIDUNG;
                _pc.SOTIEN = pc.SOTIEN;
                _pc.UPDATE_BY = pc.UPDATE_BY;
                _pc.UPDATE_DATE = pc.UPDATE_DATE;
                db.SaveChanges();
                return pc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public void Delete(int id, int iduser)
        {


            var _pc = db.tb_NHANVIEN_PHUCAP.FirstOrDefault(x => x.ID == id);
            _pc.DELETED_BY = iduser;
            _pc.DELETED_DATE = DateTime.Now;
            db.SaveChanges();

        }
    }
}
