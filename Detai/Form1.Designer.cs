namespace Detai
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tccChinhSua = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bnttacgia = new System.Windows.Forms.Button();
            this.bntBaiBao = new System.Windows.Forms.Button();
            this.bntDeTai = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTTBaiBao = new System.Windows.Forms.Button();
            this.btnTTDeTai = new System.Windows.Forms.Button();
            this.CongCU = new System.Windows.Forms.TabPage();
            this.brnDoimk = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tccChinhSua.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.CongCU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tccChinhSua
            // 
            this.tccChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tccChinhSua.Controls.Add(this.tabPage1);
            this.tccChinhSua.Controls.Add(this.tabPage2);
            this.tccChinhSua.Controls.Add(this.CongCU);
            this.tccChinhSua.Location = new System.Drawing.Point(15, 185);
            this.tccChinhSua.Margin = new System.Windows.Forms.Padding(6);
            this.tccChinhSua.Name = "tccChinhSua";
            this.tccChinhSua.SelectedIndex = 0;
            this.tccChinhSua.Size = new System.Drawing.Size(1422, 513);
            this.tccChinhSua.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.bntExit);
            this.tabPage1.Controls.Add(this.btnAbout);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.bnttacgia);
            this.tabPage1.Controls.Add(this.bntBaiBao);
            this.tabPage1.Controls.Add(this.bntDeTai);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1414, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1388, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // bntExit
            // 
            this.bntExit.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Image = global::Detai.Properties.Resources.icons8_exit_sign_50;
            this.bntExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExit.Location = new System.Drawing.Point(1074, 398);
            this.bntExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(170, 66);
            this.bntExit.TabIndex = 16;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.BtnExi_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAbout.Image = global::Detai.Properties.Resources._71;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(1244, 12);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(158, 93);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Detai.Properties.Resources.icons8_logout_rounded_down_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(172, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 66);
            this.button1.TabIndex = 15;
            this.button1.Text = "Đăng xuất";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // bnttacgia
            // 
            this.bnttacgia.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bnttacgia.Image = ((System.Drawing.Image)(resources.GetObject("bnttacgia.Image")));
            this.bnttacgia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnttacgia.Location = new System.Drawing.Point(1074, 12);
            this.bnttacgia.Margin = new System.Windows.Forms.Padding(6);
            this.bnttacgia.Name = "bnttacgia";
            this.bnttacgia.Size = new System.Drawing.Size(158, 93);
            this.bnttacgia.TabIndex = 5;
            this.bnttacgia.Text = "Tác giả";
            this.bnttacgia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnttacgia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.bnttacgia, "Thông tin tác giả");
            this.bnttacgia.UseVisualStyleBackColor = true;
            this.bnttacgia.Click += new System.EventHandler(this.bnttacgia_Click);
            // 
            // bntBaiBao
            // 
            this.bntBaiBao.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntBaiBao.Image = global::Detai.Properties.Resources._76;
            this.bntBaiBao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntBaiBao.Location = new System.Drawing.Point(184, 15);
            this.bntBaiBao.Margin = new System.Windows.Forms.Padding(6);
            this.bntBaiBao.Name = "bntBaiBao";
            this.bntBaiBao.Size = new System.Drawing.Size(158, 93);
            this.bntBaiBao.TabIndex = 2;
            this.bntBaiBao.Text = "Bài báo ";
            this.bntBaiBao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntBaiBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.bntBaiBao, "Bài báo nghiên cứu khoa học");
            this.bntBaiBao.UseVisualStyleBackColor = true;
            this.bntBaiBao.Click += new System.EventHandler(this.btnBaiBao_Click);
            // 
            // bntDeTai
            // 
            this.bntDeTai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntDeTai.Image = global::Detai.Properties.Resources._64;
            this.bntDeTai.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntDeTai.Location = new System.Drawing.Point(14, 13);
            this.bntDeTai.Margin = new System.Windows.Forms.Padding(6);
            this.bntDeTai.Name = "bntDeTai";
            this.bntDeTai.Size = new System.Drawing.Size(158, 93);
            this.bntDeTai.TabIndex = 0;
            this.bntDeTai.Text = "Đề tài";
            this.bntDeTai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntDeTai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.bntDeTai, "Đề tài");
            this.bntDeTai.UseVisualStyleBackColor = true;
            this.bntDeTai.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTTBaiBao);
            this.tabPage2.Controls.Add(this.btnTTDeTai);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1414, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông Tin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTTBaiBao
            // 
            this.btnTTBaiBao.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTTBaiBao.Image = global::Detai.Properties.Resources._59;
            this.btnTTBaiBao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTTBaiBao.Location = new System.Drawing.Point(674, 104);
            this.btnTTBaiBao.Margin = new System.Windows.Forms.Padding(6);
            this.btnTTBaiBao.Name = "btnTTBaiBao";
            this.btnTTBaiBao.Size = new System.Drawing.Size(350, 150);
            this.btnTTBaiBao.TabIndex = 7;
            this.btnTTBaiBao.Text = "Thông tin bài báo khoa học";
            this.toolTip1.SetToolTip(this.btnTTBaiBao, "Thông tin bài báo khoa học");
            this.btnTTBaiBao.UseVisualStyleBackColor = true;
            this.btnTTBaiBao.Click += new System.EventHandler(this.btnNienKhoa_Click);
            // 
            // btnTTDeTai
            // 
            this.btnTTDeTai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTTDeTai.Image = global::Detai.Properties.Resources._49;
            this.btnTTDeTai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTTDeTai.Location = new System.Drawing.Point(312, 104);
            this.btnTTDeTai.Margin = new System.Windows.Forms.Padding(6);
            this.btnTTDeTai.Name = "btnTTDeTai";
            this.btnTTDeTai.Size = new System.Drawing.Size(350, 150);
            this.btnTTDeTai.TabIndex = 6;
            this.btnTTDeTai.Text = "Thông tin đề tài khoa CNTT";
            this.toolTip1.SetToolTip(this.btnTTDeTai, "Thông tin đề tài khoa CNTT");
            this.btnTTDeTai.UseVisualStyleBackColor = true;
            this.btnTTDeTai.Click += new System.EventHandler(this.btnXemDeTai_Click);
            // 
            // CongCU
            // 
            this.CongCU.Controls.Add(this.brnDoimk);
            this.CongCU.Controls.Add(this.btnAddAcc);
            this.CongCU.Location = new System.Drawing.Point(4, 34);
            this.CongCU.Margin = new System.Windows.Forms.Padding(6);
            this.CongCU.Name = "CongCU";
            this.CongCU.Padding = new System.Windows.Forms.Padding(6);
            this.CongCU.Size = new System.Drawing.Size(1414, 475);
            this.CongCU.TabIndex = 2;
            this.CongCU.Text = "Công Cụ";
            this.CongCU.UseVisualStyleBackColor = true;
            // 
            // brnDoimk
            // 
            this.brnDoimk.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDoimk.Image = global::Detai.Properties.Resources._7;
            this.brnDoimk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brnDoimk.Location = new System.Drawing.Point(317, 100);
            this.brnDoimk.Margin = new System.Windows.Forms.Padding(6);
            this.brnDoimk.Name = "brnDoimk";
            this.brnDoimk.Size = new System.Drawing.Size(350, 150);
            this.brnDoimk.TabIndex = 11;
            this.brnDoimk.Text = "\nĐổi Mật Khẩu ";
            this.toolTip1.SetToolTip(this.brnDoimk, "Thêm tài khoản hặc dổi mật khẩu");
            this.brnDoimk.UseVisualStyleBackColor = true;
            this.brnDoimk.Click += new System.EventHandler(this.brnDoimk_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.Image = global::Detai.Properties.Resources._83;
            this.btnAddAcc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAcc.Location = new System.Drawing.Point(679, 100);
            this.btnAddAcc.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(350, 150);
            this.btnAddAcc.TabIndex = 12;
            this.btnAddAcc.Text = "Quản lý tài khoản";
            this.toolTip1.SetToolTip(this.btnAddAcc, "Quản lý tài khoản");
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.BtnAddAcc_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1422, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 713);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tccChinhSua);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khoa học cho khoa CNTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tccChinhSua.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.CongCU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tccChinhSua;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bntDeTai;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTTBaiBao;
        private System.Windows.Forms.Button bntBaiBao;
        private System.Windows.Forms.Button btnTTDeTai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage CongCU;
        private System.Windows.Forms.Button brnDoimk;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bnttacgia;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntExit;
    }
}

