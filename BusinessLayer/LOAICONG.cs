using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class LOAICONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_LOAICONG getItem(int id)
        {
            return db.tb_LOAICONG.FirstOrDefault(x => x.IDLC == id);
        }
        public List<tb_LOAICONG> getList()
        {
            return db.tb_LOAICONG.ToList();
        }
        public tb_LOAICONG Add(tb_LOAICONG lc)
        {
            try
            {
                db.tb_LOAICONG.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public tb_LOAICONG Update(tb_LOAICONG lc)
        {
            try
            {
                var _lc = db.tb_LOAICONG.FirstOrDefault(x => x.IDLC == lc.IDLC);
                _lc.TENLOAICONG = lc.TENLOAICONG;
                _lc.HESO = lc.HESO;
                _lc.UPDATE_BY = lc.UPDATE_BY;
                _lc.UPDATE_DATE = lc.UPDATE_DATE;
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public void Delete(int id, int iduser)
        {


            var _lc = db.tb_LOAICONG.FirstOrDefault(x => x.IDLC == id);
            _lc.DELETED_BY = iduser;
            _lc.DELETED_DATE = DateTime.Now;
            db.SaveChanges();

        }
    }
}
