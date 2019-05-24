using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTest
{
    public partial class CheckFormUserControl : UserControl
    {
        public CheckFormUserControl(string txtname,string lablevalue)
        {
            InitializeComponent();

            //labelの値を設定と txtboxのname設定 columnName_user_A
            this.label1.Text = lablevalue;
            this.textBox1.Name = txtname + "_" + "user" + "_" + "A";
            this.textBox2.Name = txtname + "_" + "user" + "_" + "B";
            this.textBox3.Name = txtname + "_" + "user" + "_" + "C";

            this.textBox4.Name = txtname + "_" + "admin" + "_" + "A";
            this.textBox5.Name = txtname + "_" + "admin" + "_" + "B";
            this.textBox6.Name = txtname + "_" + "admin" + "_" + "C";
        }

        private void CheckFormUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
