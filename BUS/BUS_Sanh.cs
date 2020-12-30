using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Sanh
    {
        DAL_SANH Sanh = new DAL_SANH();
        public DataTable getSanh()
        {
            return Sanh.getSanh();
        }
        public bool insertSanh(DTO_Sanh sanh)
        {
            return Sanh.insertSanh(sanh);
        }
        public bool editSanh(DTO_Sanh sanh)
        {
           return Sanh.editSanh(sanh);
        }
        public bool deleteSanh(string id)
        {
            return Sanh.deleteSanh(id);
        }
        public DataTable searchSanh(string tensanh)
        {
            return Sanh.searchSanh(tensanh);
        }
    }
}
