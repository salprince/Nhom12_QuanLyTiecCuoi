using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_DichVu
    {
        private string _MaDichVu;
        private string _TenDichVu;
        private string _MoTa;
        private int _DonGia;
        private string _GhiChu;

        public string MaDichVu
        {
            get { return this._MaDichVu; }
            set { this._MaDichVu = value; }
        }
        public string TenDichVu
        {
            get { return this._TenDichVu; }
            set { this._TenDichVu = value; }
        }
        public int DonGia
        {
            get { return this._DonGia; }
            set { this._DonGia = value; }
        }
        public string MoTa
        {
            get { return this._MoTa; }
            set { this._MoTa = value; }
        }
        public string GhiChu
        {
            get { return this._GhiChu; }
            set { this._GhiChu = value; }
        }
        public DTO_DichVu(string a, string b, string c, int d, string e)
        {
            this.MaDichVu = a;
            this.TenDichVu = b;
            this.MoTa = c;
            this.DonGia = d;
            this.GhiChu = e;
        }
    }
}
