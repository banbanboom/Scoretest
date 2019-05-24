namespace ScoreTest
{
    partial class AdminUCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUCForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btn_4thweek = new System.Windows.Forms.Button();
            this.btn_3rdweek = new System.Windows.Forms.Button();
            this.btn_2ndweek = new System.Windows.Forms.Button();
            this.btn_1stweek = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(199, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 192);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(371, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 364);
            this.panel2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(444, 416);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(158, 61);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存する";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(625, 416);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(158, 61);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = "表示画面へ";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            this.btn_show.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Controls.Add(this.btn_4thweek);
            this.panel3.Controls.Add(this.btn_3rdweek);
            this.panel3.Controls.Add(this.btn_2ndweek);
            this.panel3.Controls.Add(this.btn_1stweek);
            this.panel3.Controls.Add(this.btn_login);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 503);
            this.panel3.TabIndex = 4;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 41);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 22);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "ようこそ";
            // 
            // btn_4thweek
            // 
            this.btn_4thweek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_4thweek.BackgroundImage")));
            this.btn_4thweek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_4thweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4thweek.Location = new System.Drawing.Point(5, 400);
            this.btn_4thweek.Name = "btn_4thweek";
            this.btn_4thweek.Size = new System.Drawing.Size(175, 71);
            this.btn_4thweek.TabIndex = 4;
            this.btn_4thweek.Text = "研修4週目";
            this.btn_4thweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_4thweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_4thweek.UseVisualStyleBackColor = true;
            this.btn_4thweek.Click += new System.EventHandler(this.btn_week_Click);
            // 
            // btn_3rdweek
            // 
            this.btn_3rdweek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_3rdweek.BackgroundImage")));
            this.btn_3rdweek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_3rdweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3rdweek.Location = new System.Drawing.Point(5, 323);
            this.btn_3rdweek.Name = "btn_3rdweek";
            this.btn_3rdweek.Size = new System.Drawing.Size(175, 71);
            this.btn_3rdweek.TabIndex = 3;
            this.btn_3rdweek.Text = "研修3週目";
            this.btn_3rdweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_3rdweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_3rdweek.UseVisualStyleBackColor = true;
            this.btn_3rdweek.Click += new System.EventHandler(this.btn_week_Click);
            // 
            // btn_2ndweek
            // 
            this.btn_2ndweek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_2ndweek.BackgroundImage")));
            this.btn_2ndweek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_2ndweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2ndweek.Location = new System.Drawing.Point(5, 246);
            this.btn_2ndweek.Name = "btn_2ndweek";
            this.btn_2ndweek.Size = new System.Drawing.Size(175, 71);
            this.btn_2ndweek.TabIndex = 2;
            this.btn_2ndweek.Text = "研修2週目";
            this.btn_2ndweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_2ndweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_2ndweek.UseVisualStyleBackColor = true;
            this.btn_2ndweek.Click += new System.EventHandler(this.btn_week_Click);
            // 
            // btn_1stweek
            // 
            this.btn_1stweek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1stweek.BackgroundImage")));
            this.btn_1stweek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_1stweek.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1stweek.Location = new System.Drawing.Point(5, 169);
            this.btn_1stweek.Name = "btn_1stweek";
            this.btn_1stweek.Size = new System.Drawing.Size(175, 71);
            this.btn_1stweek.TabIndex = 1;
            this.btn_1stweek.Text = "研修1週目";
            this.btn_1stweek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_1stweek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_1stweek.UseVisualStyleBackColor = true;
            this.btn_1stweek.Click += new System.EventHandler(this.btn_week_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(5, 92);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(175, 71);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "ログイン";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelSlide.Location = new System.Drawing.Point(186, 92);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(7, 72);
            this.panelSlide.TabIndex = 5;
            // 
            // AdminUCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 503);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminUCForm";
            this.Text = "AdminUCForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUCForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminUCForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_4thweek;
        private System.Windows.Forms.Button btn_3rdweek;
        private System.Windows.Forms.Button btn_2ndweek;
        private System.Windows.Forms.Button btn_1stweek;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelSlide;
    }
}