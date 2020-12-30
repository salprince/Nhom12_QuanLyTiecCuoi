using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_ThamSo
    {
        private string _TenThamSo;
        private int _GiaTri;

        public string TenThamSo
        {
            get { return this._TenThamSo; }
            set { this._TenThamSo = value; }
        }
        public int GiaTri
        {
            get { return this._GiaTri; }
            set { this._GiaTri = value; }
        }

        public DTO_ThamSo(string a, int b)
        {
            this.TenThamSo = a;
            this.GiaTri = b;
        }
    }
}
