using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_YC6
    {
        DAL_YC6 dalYC6 = new DAL_YC6();

        // Get data (table)
        public DataTable getSanh()
        {
            return dalYC6.getSanh();
        }

        public DataTable getLoaiSanh()
        {
            return dalYC6.getLoaiSanh();
        }

        public DataTable getCa()
        {
            return dalYC6.getCa();
        }

        public DataTable getDichVu()
        {
            return dalYC6.getDichVu();
        }

        public DataTable getMonAn()
        {
            return dalYC6.getMonAn();
        }

        public DataTable getThamSo()
        {
            return dalYC6.getThamSo();
        }


        // Insert data
        public bool insertSanh(DTO_Sanh sanh)
        {
            return dalYC6.insertSanh(sanh);
        }

        public bool insertCa(DTO_Ca ca)
        {
            return dalYC6.insertCa(ca);
        }

        public bool insertDichVu(DTO_DichVu dvu)
        {
            return dalYC6.insertDichVu(dvu);
        }

        public bool insertMonAn(DTO_MonAn man)
        {
            return dalYC6.insertMonAn(man);
        }


        // Edit data
        public bool editSanh(DTO_Sanh sanh)
        {
            if ((dalYC6.searchSANH(sanh.MaSanh)) != null)
                return false;
            return dalYC6.editSanh(sanh);
        }

        public bool editCa(DTO_Ca ca)
        {
            if ((dalYC6.searchCA(ca.MaCa)) != null)
                return false;
            return dalYC6.editCa(ca);
        }

        public bool editDichVu(DTO_DichVu dvu)
        {
            return dalYC6.editDichVu(dvu);
        }

        public bool editMonAn(DTO_MonAn man)
        {

            return dalYC6.editMonAn(man);
        }

        public bool editThamSoPhat(int check)
        {
            return dalYC6.editThamSoPhat(check);
        }

        public bool editTiLePhat(double tile)
        {
            return dalYC6.editTiLePhat(tile);
        }


        // Delete data
        public bool deleteSanh(string id)
        {
            return dalYC6.deleteSanh(id);
        }

        public bool deleteLoaiSanh(string id)
        {
            return dalYC6.deleteLoaiSanh(id);
        }

        public bool deleteCa(string id)
        {
            return dalYC6.deleteCa(id);
        }

        public bool deleteDichVu(string id)
        {
            return dalYC6.deleteDichVu(id);
        }

        public bool deleteMonAn(string id)
        {

            return dalYC6.deleteMonAn(id);
        }


        // Search Data
        public DataTable searchSanh(string tensanh)
        {
            return dalYC6.searchSanh(tensanh);
        }

        public DataTable searchLoaiSanh(string tenlsanh)
        {
            return dalYC6.searchLoaiSanh(tenlsanh);
        }

        public DataTable searchCa(string ca)
        {
            return dalYC6.searchCa(ca);
        }

        public DataTable searchDichVu(string key)
        {
            return dalYC6.searchDichVu(key);
        }

        public DataTable searchMonAn(string key)
        {
            return dalYC6.searchMonAn(key);
        }
    }
}
