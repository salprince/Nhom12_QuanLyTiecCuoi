using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Ca
    {
        DAL_Ca dalCa = new DAL_Ca();
        public DataTable getCa()
        {
            return dalCa.getCa();
        }
        public bool insertCa(DTO_Ca ca)
        {
            return dalCa.insertCa(ca);
        }
        public bool editCa(DTO_Ca ca)
        {
            if ((dalCa.searchCA(ca.MaCa)) != null)
                return false;
            return dalCa.editCa(ca);
        }
        public bool deleteCa(string id)
        {
            return dalCa.deleteCa(id);
        }
        public DataTable searchCa(string ca)
        {
            return dalCa.searchCa(ca);
        }
    }
}
