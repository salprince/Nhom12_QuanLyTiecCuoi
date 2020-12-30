
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_MonAn
    {
        DAL_MonAn dalmonan = new DAL_MonAn();

        public DataTable getMonAn()
        {
            return dalmonan.getMonAn();
        }
        public bool insertMonAn(DTO_MonAn man)
        {
            return dalmonan.insertMonAn(man);
        }

        public bool editMonAn(DTO_MonAn man)
        {
            return dalmonan.editMonAn(man);
        }

        public bool deleteMonAn(string id)
        {

            return dalmonan.deleteMonAn(id);
        }

        public DataTable searchMonAn(string key)
        {
            return dalmonan.searchMonAn(key);
        }
    }
}
