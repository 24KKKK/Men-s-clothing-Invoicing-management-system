using System;
using System.Collections.Generic;

namespace DX男士服装进销存.Models
{
    public partial class Table_Supplier
    {
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDirector { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyReMark { get; set; }
        public System.DateTime InDateTime { get; set; }
        public bool IsUsed { get; set; }
    }
}
