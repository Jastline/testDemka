using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using testDemka.Data;

namespace testDemka
{
    static class Session
    {
        public static int userID { get; set;}
        public static int password { get; set; }
        public static TypeUser typeUser { get; set; }
    }
}
