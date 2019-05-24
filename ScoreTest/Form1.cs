using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScoreTest
{
    public partial class Form1 : Form
    {
        public static string username = "";
        public static string password = "";
        public static int id = 0;
        public static string status = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from login where login.username=@usr and login.password=@pwd";

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
            SqlCommand scmd = new SqlCommand(query, scn);
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            

            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", txtUserName.Text);
            scmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
            
            adapter.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                username = txtUserName.Text;
                password = txtPassword.Text;

                var value = dt.Rows[0].ItemArray[0];
                id = Convert.ToInt32(value);
                status = Convert.ToString(dt.Rows[0].ItemArray[3]);

                switch (status)
                {
                    case "user":
                        UserControlTest uct = new UserControlTest();
                        uct.Owner = this;
                        uct.Show();
                        text_clear();
                        this.Hide();
                        break;
                    case "admin":
                        
                        AdminUCForm aucf = new AdminUCForm();
                        aucf.Owner = this;
                        aucf.Show();
                        text_clear();
                        this.Hide();
               
                        break;
                }


            }
            else
            {
                MessageBox.Show("ログイン情報が正しくないか、ユーザが登録されていないです。","ログイン不正！！");
            }

        }

        private void text_clear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.BurlyWood;
        }

        
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Control;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.BurlyWood;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle newRectangle = button2.ClientRectangle;

            newRectangle.Inflate(-10,-10);
            e.Graphics.DrawEllipse(Pens.Red,newRectangle);

            newRectangle.Inflate(1,1);

            buttonPath.AddEllipse(newRectangle);
            button2.Region = new Region(buttonPath);

            button2.Text = "";
            e.Graphics.DrawString(
                "終了",
                new Font("MS UI Gothic",9, FontStyle.Regular),
                Brushes.Silver, 
                (button2.Width/2)-15, (button2.Height/2)-5
                );

            e.Graphics.DrawString(
                "終了",
                new Font("MS UI Gothic", 9, FontStyle.Regular),
                Brushes.Black,
                (button2.Width / 2) - 14.5f, (button2.Height / 2) - 4.5f
                );
        }
    }
}
