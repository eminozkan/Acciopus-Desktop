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
        private static String ExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static String AppFilePath = System.IO.Path.GetDirectoryName(ExeFilePath);
        private static String LogFilePath = AppFilePath + @"\log_file\log.txt";
        private String Author = "Muhammet Emin Ozkan";


        public static String getAppName()
        {
            return ApplicationName;
        }

        public static String getConnectionString()
        {
            return ConnectionString;
        }

        public static String getLogFilePath()
        {
            return LogFilePath;
        }
    }
}
