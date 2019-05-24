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
    public partial class AdminUserControl : UserControl
    {
        public static string checkedBtnName;
        public static int checkedBtnId;

        public event EventHandler RadioButtonClick;

        public AdminUserControl(DataTable dt)
        {
            InitializeComponent();

            //this.radioButton1.Name = radioname;
            //this.radioButton1.Text = radiotxt;
            

            addRadioButton(dt);
            
        }

        private void addRadioButton(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count ; i++)
            {
                //dtから値でradioboxのname=idとtext=usernameにする
                string radioname = Convert.ToString(dt.Rows[i].ItemArray[0]);
                string radiotxt = Convert.ToString(dt.Rows[i].ItemArray[1]);

                RadioButton rd = new RadioButton();
                rd.Name = radioname;
                rd.Text = radiotxt;
                //(25,18)(25,33)
                rd.Location = new Point((25), (18 * (i + 1)+i));
                //Checkedを確認する
                rd.Click += Rd_Click;
                /*
                rd.CheckedChanged += delegate (object sender, EventArgs e)
                {
                    checkRadioButton(rd);
                };
                */

                this.groupBox1.Controls.Add(rd);
            }
        }

        protected void Rd_Click(object sender, EventArgs e)
        {
            //checkRadioButton((RadioButton)sender);

            var rd = (RadioButton)sender;
            checkedBtnName = rd.Text;
            checkedBtnId = Convert.ToInt32(rd.Name);

            //ClickEventをAdminUCFormに渡す
            if (this.RadioButtonClick != null)
            {
                this.RadioButtonClick(rd,e);
            }
            
        }

        /*
        private void checkRadioButton(RadioButton rd)
        {

            if (rd.Checked)
            {
                checkedBtnName = rd.Text;
                checkedBtnId = Convert.ToInt32(rd.Name);

            }


        }
        */

        


    }
}
