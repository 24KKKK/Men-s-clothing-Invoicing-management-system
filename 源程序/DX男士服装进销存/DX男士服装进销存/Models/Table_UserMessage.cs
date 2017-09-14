using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_UserMessage
    {
        public Table_UserMessage()
        {
            this.Table_GoodsIn = new List<Table_GoodsIn>();
            this.Table_GoodsSell = new List<Table_GoodsSell>();
        }

        public string ID { get; set; }
        public string LoginName { get; set; }
        public string LoginPassWord { get; set; }
        public string LoginPassWord2 { get; set; }
        public string RealName { get; set; }
        public string PhoneNumber { get; set; }
        public string Level { get; set; }
        public string Address { get; set; }
        public string ReMark { get; set; }
        public Nullable<bool> IsCanuse { get; set; }
        public virtual ICollection<Table_GoodsIn> Table_GoodsIn { get; set; }
        public virtual ICollection<Table_GoodsSell> Table_GoodsSell { get; set; }
        public virtual Table_UserMessage Table_UserMessage1 { get; set; }
        public virtual Table_UserMessage Table_UserMessage2 { get; set; }
    }
}
