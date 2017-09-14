using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_GoodsBack
    {
        public string ThGoodsID { get; set; }
        public string KcID { get; set; }
        public string GoodsID { get; set; }
        public string SellID { get; set; }
        public string ID { get; set; }
        public string ThGoodsName { get; set; }
        public int ThGoodsNumber { get; set; }
        public System.DateTime ThGoodsTime { get; set; }
        public decimal ThGoodsPrice { get; set; }
        public decimal ThRealPay { get; set; }
        public decimal ThHasPay { get; set; }
        public string ThRemark { get; set; }
    }
}
