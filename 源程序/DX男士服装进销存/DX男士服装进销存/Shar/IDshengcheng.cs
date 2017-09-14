using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DX男士服装进销存.Shar;

namespace DX男士服装进销存.Shar
{
    class IDshengcheng
    {
        public static String VIPID()//VIP
        {
            return ("VIP" + Time.Get_rili());
        }
         public static String GoodsIDS()//商品
        {
           return ("GOODS" + Time.Get_rili());
        }
        public static String JinhuoDan()//进货单
        {
             return ("BUY" + Time.Get_rili()+"X");
        }
        public static String ShouHuoDan()//卖货单
        {
            return ("SELL" + Time.Get_rili()+"Y");
        }
        public static String UserID()//管理员、员工
        {
            return ("MR" + Time.Get_rili());
        }
        public static String StorID(String a)//仓库ID
        {
            if(a=="第一仓库")
            {
                return("ST000001");
            }
            if (a == "第二仓库")
            {
                return ("ST000002");
            }
            if (a == "第三仓库")
            {
                return ("ST000003");
            }
            else
            {
                return ("ST"+Time.Get_rili());
            }
         
        }
        public static String GongyingshangID()
        {
            return ("GHS" + Time.Get_rili());
        }
        public static  String TuihuoDan()
        {
            return ("BKGS"+Time.Get_rili());
        }

    }
}
