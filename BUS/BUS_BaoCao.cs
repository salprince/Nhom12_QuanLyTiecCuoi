using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_BaoCao
    {
        DAL_BaoCao BaoCao = new DAL_BaoCao();
        public DataTable getBaoCao()
        {
            return BaoCao.getBaoCao();
        }

        public bool insertBaoCao(DTO_BaoCao hd)
        {
            return BaoCao.insertBaoCao(hd);
        }
        public bool xoaBaoCao(int Quy, int Nam)
        {
            return BaoCao.xoaBaoCao(Quy, Nam);
        }
        public double TinhTongThu(int Quy, int Nam)
        {
            return BaoCao.TinhTongThu(Quy, Nam);

        }
        public double DemTongTiecCuoi(int Quy, int Nam)
        {
            return BaoCao.DemSoTiecCuoi(Quy, Nam);

        }
        public double TinhTiecCuoiHuy(int Quy, int Nam)
        {
            return BaoCao.TiecCuoiHuy(Quy, Nam);

        }
        public double TinhTiecCuoiThanhCong(int Quy, int Nam)
        {
            return BaoCao.TiecCuoiThanhCong(Quy, Nam);

        }
        public string TimBaoCao(string MaBaoCao)
        {
            return BaoCao.TimBaoCao(MaBaoCao);
        }
    }
}
