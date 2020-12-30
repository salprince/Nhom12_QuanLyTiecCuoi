using System;
using System.Data;
using System.Data.SQLite;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_YC1
    {
        DAL_YC1 dalYC1 = new DAL_YC1();
        public DataTable checkSanh()
        {
            return dalYC1.getSanh();
        }


    }
}
