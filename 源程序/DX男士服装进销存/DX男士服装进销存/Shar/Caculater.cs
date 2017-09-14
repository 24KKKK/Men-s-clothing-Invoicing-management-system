using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX男士服装进销存.Shar
{
    class Caculater
    {
        public static double Jisuan(String number, String price)//数量在前，价格在后
        {
            try
            {
                if (number != "" && price != "")
                {
                    int numbers = Int32.Parse(number);
                    decimal prices = decimal.Parse(price);
                    return double .Parse((numbers * prices).ToString());
                }
                else
                {
                    return  0;
                }
                
              
            }
            catch
            {
                MessageBox.Show("您输入的数据格式有误！");
                return 0;
               
            }
            
 
        }
    }
}
