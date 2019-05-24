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
    public partial class AdminUCForm : Form
    {
        private const int gap = 2;
        private int count;
        private int weekno = 1;

        public static string selectedName = "";
        public static int selectedId = 0;

        public AdminUCForm()
        {
            InitializeComponent();
        }

        private void AdminUCForm_Load(object sender, EventArgs e)
        {
            loadRadioBox();
            loadTextbox();
            welcomeUser();

        }

        private void AdminUCForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Form1 form1 = (Form1)this.Owner;
                form1.Show();
            }
        }

        private void loadRadioBox()
        {
            string query = "select * from login where login.status != 'admin'";

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
            SqlCommand scmd = new SqlCommand(query,scn);
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                
                    //controls作成
                    var UCRadio = new AdminUserControl(dt);
                    
                    //var a = UCRadio.Controls["groupBox1"].Controls;

                    panel1.Controls.Add(UCRadio);
                    count++;

                //var checkedbutton = panel1.Controls.OfType<RadioButton>()
                //                      .FirstOrDefault(r => r.Checked);
                //if (checkedbutton.Checked)
                //{
                //    var a = checkedbutton.Name;
                //    var b = checkedbutton.Text;
                //    var c = "";
                //}

                //渡したClickEventを取得する
                UCRadio.RadioButtonClick += new EventHandler(checkSelectedUser);

            }

            //var UCRows = new UserControlT();

        }

        //取得したClickEventでどこのButtonをcheckedしたのかを確認する
        protected void checkSelectedUser(object sender,EventArgs e)
        {
            var rd = (RadioButton)sender;
            if (rd.Checked)
            {
                //dataQuery_admin-->Checkedユーザの評価を取得 / queryData-->textboxとlabelを取得(panel2)
                //dataQuery_admin(rd.Text,Convert.ToInt32(rd.Name));
                //queryData(rd.Text, Convert.ToInt32(rd.Name));
                
                //選択したユーザのnameとIDを取得
                AdminUCForm.selectedName = rd.Text;
                AdminUCForm.selectedId = Convert.ToInt32(rd.Name);

                dataShow2();
            }
            else
            {
                MessageBox.Show("ユーザを選択してください","ユーザ選択");
            }

        }

        //dataQuery_admin is not used BUT query_data is used
        //protected void dataQuery_admin(string selectedName, int selectedId)
        //{
        //    string querySelectedUserData = "select Table_3.*" + " " +
        //                                   "from Table_3" + " " +
        //                                   "INNER JOIN login on login.userkey = Table_3.userkey where login.userkey =@usrId";
        //    SqlConnection scn = new SqlConnection();
        //    scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //    SqlCommand scmd = new SqlCommand(querySelectedUserData, scn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(scmd);


        //    scmd.Parameters.Clear();
        //    scmd.Parameters.AddWithValue("@usrId", selectedId);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);

        //    //選択したユーザのnameとIDを取得
        //    AdminUCForm.selectedName = selectedName;
        //    AdminUCForm.selectedId = selectedId;

        //    //var a = panel1.Controls["groupBox1"].Controls[1];
        //   // var b = "";

        //    /*
        //    for (int i = 0; i < panel1.Controls["groupBox1"].Controls.Count; i++)
        //    {
        //        var rd = panel1.Controls["groupBox1"].Controls;
        //        string name = "A001101_" + (i+1);
        //        rd[i].Text = Convert.ToString(dt.Columns[name]);
        //    }
        //    */
          

        //}
        

        //private void queryData(String selectedName,int selectedId)
        //{
        //    //選択したユーザのnameとIDを取得
        //    AdminUCForm.selectedName = selectedName;
        //    AdminUCForm.selectedId = selectedId;

        //    string query = "Select * from Table_4";


        //    SqlConnection scn = new SqlConnection();
        //    scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //    SqlCommand scmd = new SqlCommand(query, scn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(scmd);
        //    DataTable dt = new DataTable();

        //    scmd.Parameters.Clear();
        //    adapter.Fill(dt);

           
        //    //Table_3data
        //    DataTable dt2 = new DataTable();
        //    dt2 = showScoreSet();
            
        //    if (dt.Rows.Count != 0)
        //    {
        //        //panel2のtxtboxとlabelをloadする前全部削除する 
        //        panel2.Controls.Clear();
        //        count = 0;

        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            //dtから値でtxtboxnameとlabel.textを設定する
        //            string txtname = Convert.ToString(dt.Rows[i].ItemArray[0]);
        //            string labelvalue = Convert.ToString(dt.Rows[i].ItemArray[1]);

                    
        //                //controls作成
        //                var UCRow = new UserControlT(txtname, labelvalue);
        //                //var UCRow = new UserControlT();
        //                UCRow.Top = count * (UCRow.Height + gap);


        //                //controlのtxtboxの値を設定する
        //                UCRow.Controls[1].Text = Convert.ToString(dt2.Rows[0][txtname]);

        //                panel2.Controls.Add(UCRow);
        //                count++;

        //        }

        //    }

        //}


        //private void queryData(String selectedName, int selectedId)
        //{
        //    //選択したユーザのnameとIDを取得
        //    AdminUCForm.selectedName = selectedName;
        //    AdminUCForm.selectedId = selectedId;

        //    string query = "Select * from Table_4";


        //    SqlConnection scn = new SqlConnection();
        //    scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //    SqlCommand scmd = new SqlCommand(query, scn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(scmd);
        //    DataTable dt = new DataTable();

        //    scmd.Parameters.Clear();
        //    adapter.Fill(dt);


        //    //Table_3data
        //    DataTable dt2 = new DataTable();
        //    dt2 = showScoreSet();

        //    dataShow(dt,dt2);

            

        //}


        //private void dataShow(DataTable dt,DataTable dt2)
        //{
        //    if (dt.Rows.Count != 0)
        //    {
        //        //panel2のtxtboxとlabelをloadする前全部削除する 
        //        panel2.Controls.Clear();
        //        count = 0;

        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            //dtから値でtxtboxnameとlabel.textを設定する
        //            string txtname = Convert.ToString(dt.Rows[i].ItemArray[0]);
        //            string labelvalue = Convert.ToString(dt.Rows[i].ItemArray[1]);


        //            //controls作成
        //            var UCRow = new UserControlT(txtname, labelvalue);
        //            //var UCRow = new UserControlT();
        //            UCRow.Top = count * (UCRow.Height + gap);


        //            //controlのtxtboxの値を設定する
        //            UCRow.Controls[1].Text = Convert.ToString(dt2.Rows[0][txtname]);

        //            panel2.Controls.Add(UCRow);
        //            count++;

        //        }

        //    }
        //}


        //private DataTable showScoreSet()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        string query = "select " +
        //                   "* from Table_3 " +
        //                   "INNER JOIN login on Table_3.userkey = login.userkey " +
        //                   "where login.username=@usr and login.userkey=@id";

        //        SqlConnection scn = new SqlConnection();
        //        scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //        SqlCommand scmd = new SqlCommand(query, scn);
        //        SqlDataAdapter adapter = new SqlDataAdapter(scmd);

        //        scmd.Parameters.Clear();
        //        scmd.Parameters.AddWithValue("@usr", selectedName);
        //        scmd.Parameters.AddWithValue("@id", selectedId);

                
        //        adapter.Fill(dt);
        //        dt.Columns.Remove("userkey");
        //        return dt;

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(Convert.ToString(e));
        //        return dt;
        //    }
           
        //}

        //selecteduserの評価を取得    
        private DataTable showScoreSet()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select *" +" "+
                           "from Table_6 " +
                           "INNER JOIN login on Table_6.userkey = login.userkey and weekno=@weekno" +" "+
                           "where login.username=@usr and login.userkey=@id";

                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
                SqlCommand scmd = new SqlCommand(query, scn);
                SqlDataAdapter adapter = new SqlDataAdapter(scmd);

                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", selectedName);
                scmd.Parameters.AddWithValue("@id", selectedId);
                scmd.Parameters.AddWithValue("@weekno", this.weekno);


                adapter.Fill(dt);
                dt = DTmordify(dt);
                //dt.Columns.Remove("userkey");
                return dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
                return dt;
            }

        }

        //DTをROWをCOLにする
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

        //txtboxを取得Textにnullを設定
        private void loadTextbox()
        {
            
            string query = "Select * from Table_4";


            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
            SqlCommand scmd = new SqlCommand(query, scn);
            SqlDataAdapter adapter = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();

            scmd.Parameters.Clear();
            adapter.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                //panel2のtxtboxとlabelをloadする前全部削除する 
                panel2.Controls.Clear();
                count = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dtから値でtxtboxnameとlabel.textを設定する
                    string txtname = Convert.ToString(dt.Rows[i].ItemArray[0]);
                    string labelvalue = Convert.ToString(dt.Rows[i].ItemArray[1]);


                    //controls作成
                    var UCRow = new UserControlT(txtname, labelvalue);
                    //var UCRow = new UserControlT();
                    UCRow.Top = count * (UCRow.Height + gap);


                    //controlのtxtboxの値を設定する
                    UCRow.Controls[1].Text = "";

                    panel2.Controls.Add(UCRow);
                    count++;

                }

            }


        }

        //評価をtxtboxに設定
        private void dataShow2()
        {
            //check selected user
            if (AdminUCForm.selectedName != "" && AdminUCForm.selectedId != 0)
            {
                //Table_6data
                DataTable dt2 = new DataTable();
                dt2 = showScoreSet();
                setScore(dt2);
            }
            else
            {
                MessageBox.Show("ユーザを選択してください", "ユーザ選択");
            }
        }

        //DataTableの評価データをtxtboxに設定
        private void setScore(DataTable dt)
        {
            for (int i = 0; i < panel2.Controls.Count; i++)
            {
                string tbname = panel2.Controls[i].Controls[1].Name;
                panel2.Controls[i].Controls[1].Text = Convert.ToString(dt.Rows[0][tbname]);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dataSave();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            CheckForm cf = new CheckForm();
            cf.Owner = this;
            cf.Show();
            this.Hide();
        }

        //private void dataSave()
        //{

        //    try
        //    {
        //        for (int i = 0; i < panel2.Controls.Count; i++)
        //        {
        //            //txtboxnameとcolumnnameは同じ
        //            string var = panel2.Controls[i].Controls[1].Name;

        //            String query = "UPDATE" + " " +
        //                                   "Table_3 SET" + " " +
        //                                   var + "=" + "@value" + " " +
        //                                   //"A001101_1=@A001101_1,A001101_2=@A001101_2,A001101_3=@A001101_3,A001101_4=@A001101_4" + " " +
        //                                   "where userkey=@id";

        //            SqlConnection scn = new SqlConnection();
        //            scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //            SqlCommand scmd = new SqlCommand(query, scn);
        //            SqlDataAdapter adapter = new SqlDataAdapter(scmd);


        //            scmd.Parameters.Clear();
        //            scmd.Parameters.AddWithValue("@value", panel2.Controls[i].Controls[var].Text);
        //            scmd.Parameters.AddWithValue("@id", AdminUCForm.selectedId);

        //            scn.Open();
        //            scmd.ExecuteNonQuery();
        //            scn.Close();

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(Convert.ToString(e), "ERROR!!at saving data");
        //    }

        //}

        private void dataSave()
        {

            try
            {
                for (int i = 0; i < panel2.Controls.Count; i++)
                {
                    //txtboxnameとcolumnnameは同じ
                    string var = panel2.Controls[i].Controls[1].Name;

                    String query = "UPDATE" + " " +
                                           "Table_6 SET" + " " +
                                           "score_value" + "=" + "@value" + " " +
                                           //"A001101_1=@A001101_1,A001101_2=@A001101_2,A001101_3=@A001101_3,A001101_4=@A001101_4" + " " +
                                           "where userkey=@id and weekno=@weekno and score_code=@score_code";

                    SqlConnection scn = new SqlConnection();
                    scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
                    SqlCommand scmd = new SqlCommand(query, scn);
                    SqlDataAdapter adapter = new SqlDataAdapter(scmd);


                    scmd.Parameters.Clear();
                    scmd.Parameters.AddWithValue("@value", panel2.Controls[i].Controls[var].Text);
                    scmd.Parameters.AddWithValue("@id", AdminUCForm.selectedId);
                    scmd.Parameters.AddWithValue("@weekno", this.weekno);
                    scmd.Parameters.AddWithValue("@score_code", var);

                    scn.Open();
                    scmd.ExecuteNonQuery();
                    scn.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e), "ERROR!!at saving data");
            }

        }

        private void btn_week_Click(object sender, EventArgs e)
        {
            movePanelSlide(sender, e);

            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_1stweek":
                    weekno = 1;
                    dataShow2();
                    break;
                case "btn_2ndweek":
                    weekno = 2;
                    dataShow2();
                    break;
                case "btn_3rdweek":
                    weekno = 3;
                    dataShow2();
                    break;
                case "btn_4thweek":
                    weekno = 4;
                    dataShow2();
                    break;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            movePanelSlide(sender, e);

            Form1 form1 = (Form1)this.Owner;
            form1.Show();
            this.Hide();
        }

        private void welcomeUser()
        {
            this.labelWelcome.Text = "ようこそ " + Form1.username + " さん";
        }

        private void movePanelSlide(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            panelSlide.Height = btn.Height;
            panelSlide.Top = btn.Top;
        }

        private void btn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            GraphicsPath gp = new GraphicsPath();
            Rectangle newRectangle = btn.ClientRectangle;

            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            gp.AddEllipse(newRectangle);
            btn.Region = new Region(gp);
            gp.Dispose();
        }
    }
}
