using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Global
    {
        private static string _access_t = "";
        private static string _refresh_t = "";

        public static string _Access_t
        {
            get { return _access_t; }
            set { _access_t = value; }
        }

        public static string _Refresh_t
        {
            get { return _refresh_t; }
            set { _refresh_t = value; }
        }
    }
}
