using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_YC3
    {
        DAL_YC3 dalTiecCuoi = new DAL_YC3();

        public DataTable SearchTiecCuoi(string MatiecCuoi)
        {
            return dalTiecCuoi.SearchTiecCuoi(MatiecCuoi);
        }

        public DataTable XemTiecCuoi()
        {
            return dalTiecCuoi.XemTiecCuoi();

        }
    }
}
