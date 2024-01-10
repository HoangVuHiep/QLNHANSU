﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using System.Data.Entity;

namespace QLNHANSU
{
    public partial class FormTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public FormTonGiao()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DataLayer.QLNHANSUEntities dbContext = new DataLayer.QLNHANSUEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.tb_TONGIAO.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gcDanhsach.DataSource = dbContext.tb_TONGIAO.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        TONGIAO _tongiao;
        bool _them;
        int _id;
        private void FormTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _tongiao = new TONGIAO();
            showHide(true);
            loadData();
        }
        void loadData()
        {
            gcDanhsach.DataSource = _tongiao.getList();
            gvDanhsach.OptionsBehavior.Editable = false;
        }
        void showHide(bool kt)
        {
            btnLUU.Enabled = !kt;
            btnHUY.Enabled = !kt;
            btnTHEM.Enabled = kt;
            btnSUA.Enabled = kt;
            btnXOA.Enabled = kt;
            btnDONG.Enabled = kt;
            btnIN.Enabled = kt;
            txtTEN.Enabled = !kt;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            txtTEN.Text = string.Empty;
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tongiao.Delete(_id);
                loadData();
            }
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            showHide(true);
        }

        private void btnHUY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(true);
        }

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDONG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_TONGIAO tg = new tb_TONGIAO();
                tg.TENTG = txtTEN.Text;
                _tongiao.Add(tg);
            }
            else
            {
                var dt = _tongiao.getItem(_id);
                dt.TENTG = txtTEN.Text;
                _tongiao.Update(dt);
            }

        }

        private void gvDanhsach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhsach.GetFocusedRowCellValue("IDTG").ToString());
            txtTEN.Text = gvDanhsach.GetFocusedRowCellValue("TENTG").ToString();
        }
    }
}