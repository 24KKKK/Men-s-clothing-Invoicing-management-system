using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_VIPMessage
    {
        public string VIPID { get; set; }
        public string VIPName { get; set; }
        public string VIPPhone { get; set; }
        public string VIPAddress { get; set; }
        public decimal VIPZhekou { get; set; }
        public bool Flage { get; set; }
        public string VIPRemrk { get; set; }
        public System.DateTime VIPBirtheDay { get; set; }
    }
}
