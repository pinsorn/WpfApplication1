using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public static class DataPage_Tranfer
    {
        static public dynamic Data = "" ;
        static public dynamic SendData(dynamic DataToSend)
        {
            DataPage_Tranfer.Data = DataToSend;
            return null;
        }
        static public dynamic ReceiveData()
        {

            return DataPage_Tranfer.Data;
        }

    }
}
