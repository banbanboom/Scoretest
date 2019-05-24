namespace ScoreTest
{
    partial class UserControlTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btn_4thweek = new System.Windows.Forms.Button();
            this.btn_3rdweek = new System.Windows.Forms.Button();
            this.btn_2ndweek = new System.Windows.Forms.Button();
            this.btn_1stweek = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(185, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 348);
            this.panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(389, 366);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 60);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存する";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(557, 366);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(129, 60);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "表示画面へ";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            this.btn_check.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelWelcome);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.btn_4thweek);
            this.panel2.Controls.Add(this.btn_3rdweek);
            this.panel2.Controls.Add(this.btn_2ndweek);
            this.panel2.Controls.Add(this.btn_1stweek);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 455);
            this.panel2.TabIndex = 3;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(26, 25);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 22);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "ようこそ";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelSlide.ForeColor = System.Drawing.SystemColors.Control;
            this.panelSlide.Location = new System.Drawing.Point(172, 70);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(7, 70);
            this.panelSlide.TabIndex = 4;
            // 
            // btn_4thweek
            // 
            this.btn_4thweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4thweek.Image = ((System.Drawing.Image)(resources.GetObject("btn_4thweek.Image")));
            this.btn_4thweek.Location = new System.Drawing.Point(0, 378);
            this.btn_4thweek.Name = "btn_4thweek";
            this.btn_4thweek.Size = new System.Drawing.Size(175, 71);
            this.btn_4thweek.TabIndex = 4;
            this.btn_4thweek.Text = "研修4週目";
            this.btn_4thweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_4thweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_4thweek.UseVisualStyleBackColor = true;
            this.btn_4thweek.Click += new System.EventHandler(this.btn_week_click);
            // 
            // btn_3rdweek
            // 
            this.btn_3rdweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3rdweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3rdweek.Image = ((System.Drawing.Image)(resources.GetObject("btn_3rdweek.Image")));
            this.btn_3rdweek.Location = new System.Drawing.Point(0, 301);
            this.btn_3rdweek.Name = "btn_3rdweek";
            this.btn_3rdweek.Size = new System.Drawing.Size(175, 71);
            this.btn_3rdweek.TabIndex = 3;
            this.btn_3rdweek.Text = "研修3週目";
            this.btn_3rdweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_3rdweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_3rdweek.UseVisualStyleBackColor = true;
            this.btn_3rdweek.Click += new System.EventHandler(this.btn_week_click);
            // 
            // btn_2ndweek
            // 
            this.btn_2ndweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2ndweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2ndweek.Image = ((System.Drawing.Image)(resources.GetObject("btn_2ndweek.Image")));
            this.btn_2ndweek.Location = new System.Drawing.Point(0, 224);
            this.btn_2ndweek.Name = "btn_2ndweek";
            this.btn_2ndweek.Size = new System.Drawing.Size(175, 71);
            this.btn_2ndweek.TabIndex = 2;
            this.btn_2ndweek.Text = "研修2週目";
            this.btn_2ndweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_2ndweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_2ndweek.UseVisualStyleBackColor = true;
            this.btn_2ndweek.Click += new System.EventHandler(this.btn_week_click);
            // 
            // btn_1stweek
            // 
            this.btn_1stweek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1stweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1stweek.Image = ((System.Drawing.Image)(resources.GetObject("btn_1stweek.Image")));
            this.btn_1stweek.Location = new System.Drawing.Point(0, 147);
            this.btn_1stweek.Name = "btn_1stweek";
            this.btn_1stweek.Size = new System.Drawing.Size(175, 71);
            this.btn_1stweek.TabIndex = 1;
            this.btn_1stweek.Text = "研修1週目";
            this.btn_1stweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_1stweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_1stweek.UseVisualStyleBackColor = true;
            this.btn_1stweek.Click += new System.EventHandler(this.btn_week_click);
            // 
            // btn_login
            // 
            this.btn_login.CausesValidation = false;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(0, 70);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(175, 71);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "ログイン";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // UserControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlTest";
            this.Text = "UserControlTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserControlTest_FormClosing);
            this.Load += new System.EventHandler(this.UserControlTest_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_4thweek;
        private System.Windows.Forms.Button btn_3rdweek;
        private System.Windows.Forms.Button btn_2ndweek;
        private System.Windows.Forms.Button btn_1stweek;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelWelcome;
    }
}