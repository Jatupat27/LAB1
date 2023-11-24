using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatupat
{
    public partial class t : Form
    {
        public t()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
          
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxinput.Text = string.Empty;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;   
            textBoxinput.Text = userinput+"cis kku";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput +"0";
        }
        string number1 ;
        string operation  ;
        private void buttonplus_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "+";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string number2 = textBoxinput.Text;
            int num1 = int.Parse(number1);      
            int num2 = int.Parse(number2);
            //operation
            if ( operation == "+")
            {
                textBoxinput.Text = String.Format("{0}", num1 + num2);
            }
            else if (operation == "-")
            {
                textBoxinput.Text = String.Format("{0}",num1 - num2);
            }
            else if (operation == "/")
            {
                textBoxinput.Text = String.Format("{0}", num1 / num2);
            }
            else if (operation == "*")
            {
                textBoxinput.Text = String.Format("{0}", num1 * num2);
            }    
        }
        string number3 = string.Empty;
        private void buttongo_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "-";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "*";
        }
    }
}
