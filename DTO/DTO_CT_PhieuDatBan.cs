using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO
{
    public class DTO_CT_PhieuDatBan
    {
        private string _MaTiecCuoi;
        private string _MaMonAn;
        private string _GhiChu;

        public string MaTiecCuoi
        {
            get { return this._MaTiecCuoi; }
            set { this._MaTiecCuoi = value; }
        }
        public string MaMonAn
        {
            get { return this._MaMonAn; }
            set { this._MaMonAn = value; }
        }


        public string GhiChu
        {
            get { return this._GhiChu; }
            set { this._GhiChu = value; }
        }
        public DTO_CT_PhieuDatBan(string a, string b, string e)
        {
            this.MaTiecCuoi = a;
            this.MaMonAn = b;
            this.GhiChu = e;
        }
        public DTO_CT_PhieuDatBan(DataRow row)
        {
            this.MaTiecCuoi = (string)row["matieccuoi"];
            this.MaMonAn = (string)row["mamonan"];
            this.GhiChu = (string)row["ghichu"];

        }
    }
}
