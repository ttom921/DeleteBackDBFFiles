using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class DateFileName
    {
        public string GenDataFileName()
        {
            string ret = null;
            DateTime dt = DateTime.Now.AddDays(-7);
            string strdt = dt.ToString("_yyyy_MM_dd_");
            return ret= strdt;
        }
    }
}
