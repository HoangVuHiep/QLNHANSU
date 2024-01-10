﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class CONGTY
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public tb_CONGTY getItem(int id)
        {
            return db.tb_CONGTY.FirstOrDefault(x => x.MACT == id);
        }
        public List<tb_CONGTY> getList()
        {
            return db.tb_CONGTY.ToList();
        }
        public tb_CONGTY Add(tb_CONGTY ct)
        {
            try
            {
                db.tb_CONGTY.Add(ct);
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public tb_CONGTY Update(tb_CONGTY ct)
        {
            try
            {
                var _ct = db.tb_CONGTY.FirstOrDefault(x => x.MACT == ct.MACT);
                _ct.TENCT = ct.TENCT;
                _ct.DIENTHOAI = ct.DIENTHOAI;
                _ct.EMAIL = ct.EMAIL;
                _ct.DIACHI = ct.DIACHI;
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public void Delete(int id)
        {

            try
            {
                var _ct = db.tb_CONGTY.FirstOrDefault(x => x.MACT == id);
                db.tb_CONGTY.Remove(_ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi:" + ex.Message);
            }
        }
    }
}