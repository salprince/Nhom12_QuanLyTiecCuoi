using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Ca
    {
        private string _MaCa;
        private string _TenCa;

        public string MaCa
        {
            get { return this._MaCa; }
            set { this._MaCa = value; }
        }
        public string TenCa
        {
            get { return this._TenCa; }
            set { this._TenCa = value; }
        }

        public DTO_Ca(string a, string b)
        {
            this.MaCa = a;
            this.TenCa = b;
        }
    }
}
