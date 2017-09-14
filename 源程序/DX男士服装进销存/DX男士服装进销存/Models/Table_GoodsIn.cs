using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_GoodsIn
    {
        public string GoodsID { get; set; }
        public string ID { get; set; }
        public string CompanyName { get; set; }
        public string StroName { get; set; }
        public string GoodsName { get; set; }
        public int GoodsNum { get; set; }
        public string GoodsUnit { get; set; }
        public decimal GoodsInPrice { get; set; }
        public decimal GoodsSellPrice { get; set; }
        public decimal GoodsShouldPay { get; set; }
        public decimal GoodsRealPay { get; set; }
        public string GoodsRemark { get; set; }
        public System.DateTime GoodsInDateTime { get; set; }
        public bool Flage { get; set; }
        public string GoodsColor { get; set; }
        public string GoodsSize { get; set; }
        public string GoodsLeibie { get; set; }
        public string GoodsShouldJijie { get; set; }
        public string GoodsPinpai { get; set; }
        public virtual Table_UserMessage Table_UserMessage { get; set; }
    }
}
