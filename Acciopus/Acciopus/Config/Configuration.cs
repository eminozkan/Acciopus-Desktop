using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.Config
{
    internal class Configuration
    {
        private static String ApplicationName = "İş Arama ve Bulma Platformu";
        private static String ConnectionString = @"Server = localhost\SQLEXPRESS;Database=202503049;Trusted_Connection=True";
        private static String Author = "Muhammet Emin Ozkan";


        public static String getAppName()
        {
            return ApplicationName;
        }

        public static String getConnectionString()
        {
            return ConnectionString;
        }

        public static String getAuthorName()
        {
            return Author;
        }
    }
}
