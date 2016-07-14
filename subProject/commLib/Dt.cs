using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace commLib
{
    public class Dt
    {

        /// <summary>
        /// to yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <returns></returns>
        public static string ToT1(DateTime dt)
        {
         
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
