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
    public partial class CheckForm : Form
    {
        public static List<string> colname = new List<string>();
        private const int gap = 5;
        private int count = 0;
        private int weekno = 1;

        public CheckForm()
        {
            InitializeComponent();
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {
            //usercontorlsをload
            queryData();
            //評価を入れる
            dataShow();
        }

        private void CheckForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Form1 form1 = (Form1)this.Owner.Owner;
                form1.Show();
            }
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

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dtから値でtxtboxnameとlabel.textを設定する
                    string txtname = Convert.ToString(dt.Rows[i].ItemArray[0]);
                    string labelvalue = Convert.ToString(dt.Rows[i].ItemArray[1]);

                    //controls作成
                    var UCRow = new CheckFormUserControl(txtname, labelvalue);

                    UCRow.Top = count * (UCRow.Height + gap);

                    panel1.Controls.Add(UCRow);
                    count++;


                }

            }

        }

        //private void dataShow()
        //{
        //    string query = "";

        //    switch (Form1.status)
        //    {
        //        case "user":
        //            query = "select Table_2.*," +
        //                   "Table_3.*" + " " +
        //                   "from Table_2" + " " +
        //                   "INNER JOIN Table_3 on Table_2.userkey = Table_3.userkey" + " " +
        //                   "INNER JOIN login on Table_2.userkey = login.userkey where login.username =@usr and login.password =@pwd";

        //            dataQuery_user(query);
        //            break;

        //        case "admin":
        //            query = "select Table_2.*," +
        //                    "Table_3.*" + " " +
        //                    "from Table_3" + " " +
        //                    "INNER JOIN Table_2 on Table_3.userkey = Table_2.userkey" + " " +
        //                    "INNER JOIN login on Table_2.userkey = login.userkey where login.username =@usr and login.userkey =@id";

        //            dataQuery_admin(query);
        //            break;
        //    }
        //}

        private void dataShow()
        {
            string query = "";

            switch (Form1.status)
            {
                case "user":
                    query = "select Table_5.*," +
                           "Table_6.*" + " " +
                           "from Table_5" + " " +
                           "INNER JOIN Table_6 on Table_5.userkey = Table_6.userkey"+" "+
                           "and Table_5.weekno = Table_6.weekno and Table_5.score_code = Table_6.score_code"+ " " +
                           "INNER JOIN login on Table_5.userkey = login.userkey where login.username =@usr and login.password =@pwd" +" "+
                           "and Table_5.weekno=@weekno";

                    dataQuery_user(query);
                    break;

                case "admin":
                    query = "select Table_5.*," +
                            "Table_6.*" + " " +
                            "from Table_6" + " " +
                            "INNER JOIN Table_5 on Table_6.userkey = Table_5.userkey and Table_6.weekno = Table_5.weekno and Table_6.score_code = Table_5.score_code" + " " +
                            "INNER JOIN login on Table_5.userkey = login.userkey" +" "+
                            "where login.username =@usr and login.userkey =@id and Table_6.weekno=@weekno";

                    dataQuery_admin(query);
                    break;
            }
        }

        //private void dataQuery_user(string query)
        //{
        //    try
        //    {
        //        SqlConnection scn = new SqlConnection();
        //        scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
        //        SqlCommand scmd = new SqlCommand(query, scn);
        //        SqlDataAdapter adapter = new SqlDataAdapter(scmd);


        //        scmd.Parameters.Clear();
        //        scmd.Parameters.AddWithValue("@usr", Form1.username);
        //        scmd.Parameters.AddWithValue("@pwd", Form1.password);

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        //colnameをcolumnname_userと変更
        //        dt = changeDTColumnName(dt);
        //        displayScore(dt);


        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(Convert.ToString(e));
        //    }
        //}

        private void dataQuery_user(string query)
        {
            try
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

                DataTable dt2 = new DataTable();

                //DB_queryを変更しcolnameをcolumnname_userと変更
                dt2 = DTmordify(dt);
                
                //colnameをcolumnname_userと変更
                //dt = changeDTColumnName(dt2);
                displayScore(dt2);


            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void dataQuery_admin(string query)
        {
            try
            {
                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"Data Source=localhost;Initial Catalog=hyokaDB;Integrated Security=True";
                SqlCommand scmd = new SqlCommand(query, scn);
                SqlDataAdapter adapter = new SqlDataAdapter(scmd);


                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", AdminUCForm.selectedName);
                scmd.Parameters.AddWithValue("@id", AdminUCForm.selectedId);
                scmd.Parameters.AddWithValue("@weekno", this.weekno);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //DB_queryを変更しcolnameをcolumnname_userと変更
                DataTable dt2 = new DataTable();
                dt2 = DTmordify(dt);

                //colnameをcolumnname_adminと変更
                //dt = changeDTColumnName(dt);

                displayScore(dt2);

            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }

        }

        //not call
        private DataTable changeDTColumnName(DataTable dt)
        {
            dt.Columns.Remove("userkey");
            dt.Columns.Remove("userkey1");

            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Columns.Count / 2; i++)
                {
                    //columnnameを取得
                    colname.Add(dt.Columns[i].ColumnName);

                    //col0-5をcol_name_user    col6-11をcol_name_admin
                    dt.Columns[i].ColumnName = colname[i] + "_" + "user";
                    dt.Columns[i + 6].ColumnName = colname[i] + "_" + "admin";

                }
                colname.Clear();
            }

            return dt;
        }

        //DataTableのrowをcolumnにする
        private DataTable DTmordify(DataTable dt)
        {
            string colname_user = "";
            string colname_admin = "";
            int count = 0;

            DataTable dt2 = new DataTable();
            DataColumn dtcolumn;
            DataRow dtrow;

            dtrow = dt2.NewRow();
            dt2.Rows.Add(dtrow);

            if (dt.Rows.Count != 0)//if original query does not fail
            {
                while (count < 2)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //userのcolumn作成
                        if (count == 0)
                        {
                            dtcolumn = new DataColumn();
                            colname_user = Convert.ToString(dt.Rows[i]["score_code"]) + "_user";
                            dtcolumn.ColumnName = colname_user;
                            dt2.Columns.Add(dtcolumn);
                            dt2.Rows[0][colname_user] = Convert.ToString(dt.Rows[i]["score_value"]);
                        }
                        //adminのcolumn作成
                        else if (count == 1)
                        {
                            dtcolumn = new DataColumn();
                            colname_admin = Convert.ToString(dt.Rows[i]["score_code1"]) + "_admin";
                            dtcolumn.ColumnName = colname_admin;
                            dt2.Columns.Add(dtcolumn);
                            dt2.Rows[0][colname_admin] = Convert.ToString(dt.Rows[i]["score_value1"]);
                        }


                    }
                    count++;
                }
            }
            else
            {
                MessageBox.Show("データを見つけていません","query fail!!");
            }

            
            
            return dt2;
        }

        //private void displayScore(DataTable datatable)
        //{
        //    TextBox tb;
        //    string searchName,strValue,baseName;

        //    for (int i =0; i < datatable.Columns.Count/2;i++)
        //    {
        //        //自己評価
        //        baseName = datatable.Columns[i].ColumnName;
        //        strValue = Convert.ToString(datatable.Rows[0][baseName]);
        //        searchName = baseName + "_" + strValue;

        //        tb = this.Controls.Find(searchName,true).FirstOrDefault() as TextBox;
        //        tb.Text = "〇";

        //        //企業評価
        //        baseName = datatable.Columns[i+6].ColumnName;
        //        strValue = Convert.ToString(datatable.Rows[0][baseName]);
        //        searchName = baseName + "_" + strValue;

        //        tb = this.Controls.Find(searchName, true).FirstOrDefault() as TextBox;
        //        tb.Text = "〇";

        //    }

        //}


        private void displayScore(DataTable datatable)
        {
            TextBox tb;
            string searchName, strValue, baseName;

            for (int i = 0; i < datatable.Columns.Count / 2; i++)
            {
                
                
                //自己評価
                baseName = datatable.Columns[i].ColumnName;
                strValue = Convert.ToString(datatable.Rows[0][baseName]);
                searchName = baseName + "_" + strValue;

                TextBoxClear(baseName);
                tb = this.Controls.Find(searchName, true).FirstOrDefault() as TextBox;
                tb.Text = "〇";
                
                

                //企業評価
                baseName = datatable.Columns[i + (datatable.Columns.Count/2)].ColumnName;
                strValue = Convert.ToString(datatable.Rows[0][baseName]);
                searchName = baseName + "_" + strValue;

                TextBoxClear(baseName);
                tb = this.Controls.Find(searchName, true).FirstOrDefault() as TextBox;
                tb.Text = "〇";

            }

        }

        private void TextBoxClear(String basename)
        {
            TextBox tb;
            string searchName;
            int count = 0;

            while (count < 3)
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    switch (count)
                    {
                        case 0:
                            searchName = basename + "_A";
                            tb = this.Controls.Find(searchName, true).FirstOrDefault() as TextBox;
                            //var a = tb.Text;
                            //var b = "";
                            if (!string.IsNullOrWhiteSpace(tb.Text))
                            {
                                tb.Text = "";
                            }
                            break;
                        case 1:
                            searchName = basename + "_B";
                            tb = this.Controls.Find(searchName, true).FirstOrDefault() as TextBox;
                            //var a = tb.Text;
                            //var b = "";
                            if (!string.IsNullOrWhiteSpace(tb.Text))
                            {
                                tb.Text = "";
                            }
                            break;
                        case 2:
                            searchName = basename + "_C";
                            tb = this.Controls.Find(searchName, true).FirstOrDefault() as TextBox;
                            if (!string.IsNullOrWhiteSpace(tb.Text))
                            {
                                tb.Text = "";
                            }
                            break;
                    }
                    

                }
                count++;
            }

            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            switch (Form1.status)
            {
                case "user":
                    UserControlTest uct = (UserControlTest)this.Owner;
                    Form1 login_user = (Form1)this.Owner.Owner;
                    this.Close();
                    login_user.Hide();
                    uct.Show();
                    break;
                case "admin":
                    AdminUCForm aucf = (AdminUCForm)this.Owner;
                    Form1 login_admin = (Form1)this.Owner.Owner;
                    this.Close();
                    login_admin.Hide();
                    aucf.Show();
                    break;
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_week_Click(object sender, EventArgs e)
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

        private void btn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            GraphicsPath gp = new GraphicsPath();
            Rectangle newRectangle = btn.ClientRectangle;

            newRectangle.Inflate(-10,-10);
            e.Graphics.DrawEllipse(Pens.Black,newRectangle);
            newRectangle.Inflate(1,1);
            gp.AddEllipse(newRectangle);
            btn.Region = new Region(gp);
            gp.Dispose();

            
        }
    }
}
