using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ScoreTest
{
    public partial class UserControlT : UserControl
    {
        private DataTable pdt = new DataTable();

        public UserControlT()
        {
            InitializeComponent();
            
        }


        public UserControlT(string txtname,string labelvalue)
        {
            InitializeComponent();

            ////dtから値でtxtboxnameとlabel.textを設定する
            this.textBox1.Name = txtname;
            this.label1.Text = labelvalue;
        }

        private void UserControlT_Load(object sender, EventArgs e)
        {
            /*
            if (pdt.Rows.Count != 0)
            {
                for (int i =0;  i < pdt.Rows.Count;i++ )
                {
                    this.textBox1.Name = Convert.ToString(pdt.Rows[i].ItemArray[0]);
                    this.label1.Text = Convert.ToString(pdt.Rows[i].ItemArray[1]);
                }
            }
            */

            


        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[^a-zA-Z]*(A|B|C)[^a-zA-Z]*$");
            MatchCollection matches = regex.Matches(textBox1.Text);

            if (matches.Count == 0)
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "only A B C are allowed");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }
    }
}
