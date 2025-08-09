using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        bool flage = true;
 bool isnumber (string text) // دالة تتحقق من الرقم المدخل هو رقم  ام لا
        {
            bool b=false;
            for(int i=0; i<text.Length; i++)
            {
                if((text[i] < '0'||text[i]>'9'))
                    b=true;
                if (b == true)
                    return false;
              

            }
            return true;

        }
        public Form2()
        {
           
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
  public double x, y, z;    int c = 0;

        bool dot1=false;
    
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar < 48 || e.KeyChar > 58)&&(! (c == 0 && e.KeyChar == 45))&&(e.KeyChar==46 && dot1==true)&&(e.KeyChar!=34)&&(e.KeyChar!=8))
            {
              
                e.Handled = true;
             
            }
           c++;
            if (e.KeyChar == 46)
               dot1 =true;
        }
        int cc = 0;
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 58) && (!(cc == 0 && e.KeyChar == 45)) && (e.KeyChar != 46) && (e.KeyChar != 34) && (e.KeyChar != 8))
            {

                e.Handled = true;

            }
            cc++;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            //if (!isnumber(textBox1.Text) || textBox1.Text == "")
            //{


            //    MessageBox.Show("ادخل الرقم الاول ");
            //    textBox1.Focus();
            //}
            //else if (!isnumber(textBox2.Text) || textBox2.Text == "")
            //{
            //    MessageBox.Show("ادخل الرقم الثاني ");
            //    textBox2.Focus();
            //}
            //else
            //{
            try{
                x = Convert.ToDouble(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               try 
            {y = Convert.ToDouble(textBox2.Text); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                z = x + y;
                textBox3.Text = z.ToString();
            Form4 f=new Form4();
            f.textbxshow.Text=z.ToString();
            f.Show();
            // }
           

        }
    }
}

