using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX男士服装进销存
{
    public partial class FormLogin : Form
    {
       public  bool mark = false;
        public FormLogin()
        {
            InitializeComponent();
        }

         public  void  Bt解锁_Click(object sender, EventArgs e)
        {

            if ( FormLogin二级密码文本框.Text == "123456")
            { 
                mark= true;
            }
            else
            {
                mark= false;
            }
            this.Close();
        }

         private void FormLogin_Load(object sender, EventArgs e)
         {
             this.FormLogin二级密码文本框.Focus();
             this.FormLogin二级密码文本框.Text = "";
         }

         private void labelControl_Click(object sender, EventArgs e)
         {

         }

    
    }
}
