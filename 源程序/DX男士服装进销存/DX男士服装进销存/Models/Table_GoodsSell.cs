using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_GoodsSell
    {
        public string SellID { get; set; }
        public string KcID { get; set; }
        public string GoodsID { get; set; }
        public string ID { get; set; }
        public string GoodsName { get; set; }
        public int SellGoodsNumber { get; set; }
        public System.DateTime SellGoodsTime { get; set; }
        public decimal SellPrice { get; set; }
        public decimal SellShouldPay { get; set; }
        public decimal SellRealPay { get; set; }
        public string SellRemark { get; set; }
        public Nullable<bool> Sellflage { get; set; }
        public virtual Table_UserMessage Table_UserMessage { get; set; }
    }
}
