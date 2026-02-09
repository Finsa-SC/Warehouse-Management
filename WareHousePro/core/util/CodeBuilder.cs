using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHousePro.core.network;

namespace WareHousePro.core.util
{
    internal class CodeBuilder
    {
        public static string createCode(string query, string prefix)
        {
            object stringCode = DBHelper.ExecuteScalar(query);
            if (stringCode == null || stringCode == DBNull.Value || stringCode is null) return prefix + "001";
            int code = Convert.ToInt32(stringCode.ToString().Replace(prefix, ""));
            code++;
            return prefix + code.ToString("D3");
        }
    }
}
