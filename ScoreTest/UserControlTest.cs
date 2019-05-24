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
    public partial class UserControlTest : Form
    {
        private const int gap = 5;
        private int count = 0;

        private int weekno = 1;

        public UserControlTest()
        {
            InitializeComponent();
        }

        private void UserControlTest_Load(object sender, EventArgs e)
        {
            queryData();
            welcomeUser();
        }

        private void UserControlTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Form1 form1 = (Form1)this.Owner;
                form1.Show();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                dataSave();
                dataShow();
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            CheckForm cf = new CheckForm();
            cf.Owner = this;
            cf.Show();
            this.Hide();
        }

        private void queryData()
        {
            string query = "Select * from Table_4";

       
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
            SqlCommand scmd = new SqlCommand(query, scn);
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            
            scmd.Parameters.Clear();
            adapter.Fill(dt);

            //Table_2data
            DataTable dt2 = new DataTable();
            dt2 = showScoreSet();

            if (dt.Rows.Count != 0)
            {
                for (int i=0; i< dt.Rows.Count;i++)
                {
                    //dtから値でtxtboxnameとlabel.textを設定する
                    string txtname = Convert.ToString(dt.Rows[i].ItemArray[0]);
                    string labelvalue = Convert.ToString(dt.Rows[i].ItemArray[1]); 

                    //controls作成
                    var UCRow = new UserControlT(txtname,labelvalue);
                    //var UCRow = new UserControlT();
                    UCRow.Top = count * (UCRow.Height + gap);

                    
                    //controlのtxtboxの値を設定する
                    UCRow.Controls[1].Text= Convert.ToString(dt2.Rows[0][txtname]);
                    
                    panel1.Controls.Add(UCRow);
                    count++;
                    
                    
                }
                
            }

            


        }

        //private DataTable showScoreSet()
        //{
        //    string query = "select " +
        //                   "* from Table_2 " +
        //                   "INNER JOIN login on Table_2.userkey = login.userkey " +
        //                   "where login.username=@usr and login.password=@pwd";

        //    SqlConnection scn = new SqlConnection();
        //    scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //    SqlCommand scmd = new SqlCommand(query,scn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(scmd);

        //    scmd.Parameters.Clear();
        //    scmd.Parameters.AddWithValue("@usr",Form1.username);
        //    scmd.Parameters.AddWithValue("@pwd",Form1.password);

        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    dt.Columns.Remove("userkey");

        //    return dt;

        //}

        private DataTable showScoreSet()
        {
            string query = "select " +
                           "* from Table_5 " +
                           "INNER JOIN login on Table_5.userkey = login.userkey " +
                           "where login.username=@usr and login.password=@pwd and Table_5.weekno=@weekno" +" "+
                           "ORDER BY score_code ASC";

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
            SqlCommand scmd = new SqlCommand(query, scn);
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);

            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", Form1.username);
            scmd.Parameters.AddWithValue("@pwd", Form1.password);
            scmd.Parameters.AddWithValue("@weekno", this.weekno);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataTable dt2 = DTmordify(dt);
           

            return dt2;

        }

        private void dataSave()
        {

            try
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    //txtboxnameとcolumnnameは同じ
                    string var = panel1.Controls[i].Controls[1].Name;

                    String query = "UPDATE" + " " +
                                           "Table_5 SET" + " " +
                                           "score_value" + "=" + "@value" + " " +
                                           //"A001101_1=@A001101_1,A001101_2=@A001101_2,A001101_3=@A001101_3,A001101_4=@A001101_4" + " " +
                                           "where userkey=@id and weekno=@weekno and score_code=@score_code";

                    SqlConnection scn = new SqlConnection();
                    scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
                    SqlCommand scmd = new SqlCommand(query, scn);
                    SqlDataAdapter adapter = new SqlDataAdapter(scmd);


                    scmd.Parameters.Clear();
                    scmd.Parameters.AddWithValue("@value", panel1.Controls[i].Controls[var].Text);
                    scmd.Parameters.AddWithValue("@id", Form1.id);
                    scmd.Parameters.AddWithValue("@weekno", this.weekno);
                    scmd.Parameters.AddWithValue("@score_code", var);

                    scn.Open();
                    scmd.ExecuteNonQuery();
                    scn.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e),"ERROR!!at saving data");
            }

        }

        //private void dataShow()
        //{
        //    string status = Form1.status;
        //    string query = "";
        //    switch (status)
        //    {
        //        case "user":
        //            query = "select *" + " " +
        //                           "from Table_2" + " " +
        //                           "INNER JOIN login on Table_2.userkey = login.userkey where login.username =@usr and login.password =@pwd";

        //            dataQuery_user(query);

        //            break;

        //        //case "admin":
        //        //    query = "Select userkey ,username From login where status != 'admin'";

        //        //    //dataQuery_registeredUser(query);

        //        //    if (selectedId == 0)
        //        //    {
        //        //        MessageBox.Show("ユーザを選択ください", "ユーザを選択");
        //        //    }

        //            break;

        //    }
        //}

        private void dataShow()
        {
            string status = Form1.status;
            string query = "";
            switch (status)
            {
                case "user":
                     query = "select " +
                           "* from Table_5 " +
                           "INNER JOIN login on Table_5.userkey = login.userkey " +
                           "where login.username=@usr and login.password=@pwd and Table_5.weekno=@weekno" + " " +
                           "ORDER BY score_code ASC";

                    dataQuery_user(query);

                    break;

                    //case "admin":
                    //    query = "Select userkey ,username From login where status != 'admin'";

                    //    //dataQuery_registeredUser(query);

                    //    if (selectedId == 0)
                    //    {
                    //        MessageBox.Show("ユーザを選択ください", "ユーザを選択");
                    //    }

                    break;

            }
        }

        private void dataQuery_user(string query)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
            SqlCommand scmd = new SqlCommand(query, scn);
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);


            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", Form1.username);
            scmd.Parameters.AddWithValue("@pwd", Form1.password);
            scmd.Parameters.AddWithValue("@weekno", this.weekno);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dt = DTmordify(dt);

            for (int i = 0; i < panel1.Controls.Count;i++)
            {
                string tbname = panel1.Controls[i].Controls[1].Name;
                panel1.Controls[i].Controls[1].Text = Convert.ToString(dt.Rows[0][tbname]) ; 
            }
        }

        private DataTable DTmordify(DataTable dt)
        {
            DataTable dt2 = new DataTable();
            DataColumn dtcolumn;
            DataRow dtrow;

            dtrow = dt2.NewRow();
            dt2.Rows.Add(dtrow);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                dtcolumn = new DataColumn();
                dtcolumn.ColumnName = Convert.ToString(dt.Rows[i]["score_code"]);
                dt2.Columns.Add(dtcolumn);
                dt2.Rows[0][Convert.ToString(dt.Rows[i]["score_code"])] = Convert.ToString(dt.Rows[i]["score_value"]);

            }


            return dt2;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            movePanelSlide(sender,e);
           
            
            Form1 form1 = (Form1)this.Owner;
            form1.Show();
            this.Hide();
        }

        private void btn_week_click(object sender, EventArgs e)
        {
            movePanelSlide(sender, e);

            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_1stweek":
                    weekno = 1;
                    dataShow();
                    break;
                case "btn_2ndweek":
                    weekno = 2;
                    dataShow();
                    break;
                case "btn_3rdweek":
                    weekno = 3;
                    dataShow();
                    break;
                case "btn_4thweek":
                    weekno = 4;
                    dataShow();
                    break;
            }

        }

        private void movePanelSlide(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            panelSlide.Height = btn.Height;
            panelSlide.Top = btn.Top;
        }

        private void welcomeUser()
        {
            this.labelWelcome.Text = "ようこそ " + Form1.username +" さん";
        }

        private void btn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(162,85);

            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle newRectangle = btn.ClientRectangle;

            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(Pens.Black, newRectangle);

            newRectangle.Inflate(1, 1);

            buttonPath.AddEllipse(newRectangle);
            btn.Region = new Region(buttonPath);

        }
    }
}
