using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_Stor
    {
        public string KcID { get; set; }
        public string GoodsID { get; set; }
        public string CompanyName { get; set; }
        public string KcName { get; set; }
        public string KcGoodsName { get; set; }
        public int KcNumber { get; set; }
        public Nullable<int> KcJingGaoNumber { get; set; }
        public System.DateTime KcDataTime { get; set; }
        public string KcUnit { get; set; }
        public decimal KcGoodsPrice { get; set; }
        public decimal KcGoodsSellPrice { get; set; }
        public string KcRemark { get; set; }
    }
}
