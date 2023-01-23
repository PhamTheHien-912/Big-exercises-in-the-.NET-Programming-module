namespace Detai
{
    partial class FrTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrTaiKhoan));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChihsua = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbquyen = new System.Windows.Forms.ComboBox();
            this.lblTongso = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgHienthi = new System.Windows.Forms.DataGridView();
            this.tenDangnhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDT = new Detai.QLDT1();
            this.button1 = new System.Windows.Forms.Button();
            this.tblDangNhapTableAdapter = new Detai.QLDT1TableAdapters.tblDangNhapTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnOk2);
            this.groupBox3.Controls.Add(this.buttonOK);
            this.groupBox3.Controls.Add(this.btnThemMoi);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnChihsua);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(537, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(513, 172);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(61, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 30;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk2
            // 
            this.btnOk2.Enabled = false;
            this.btnOk2.Image = global::Detai.Properties.Resources.tick;
            this.btnOk2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk2.Location = new System.Drawing.Point(176, 88);
            this.btnOk2.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(160, 46);
            this.btnOk2.TabIndex = 33;
            this.btnOk2.Text = "Ok";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Image = global::Detai.Properties.Resources.tick;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(176, 88);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(160, 46);
            this.buttonOK.TabIndex = 35;
            this.buttonOK.Text = "Ok ";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = global::Detai.Properties.Resources.folder_add;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(8, 34);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(160, 46);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::Detai.Properties.Resources.folder_go;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(344, 88);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChihsua
            // 
            this.btnChihsua.Image = global::Detai.Properties.Resources.folder_edit;
            this.btnChihsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChihsua.Location = new System.Drawing.Point(176, 34);
            this.btnChihsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChihsua.Name = "btnChihsua";
            this.btnChihsua.Size = new System.Drawing.Size(160, 46);
            this.btnChihsua.TabIndex = 34;
            this.btnChihsua.Text = "Chỉnh Sửa";
            this.btnChihsua.UseVisualStyleBackColor = true;
            this.btnChihsua.Click += new System.EventHandler(this.btnChihsua_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Detai.Properties.Resources.folder_delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(344, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 46);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Detai.Properties.Resources.textfield_clear;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(8, 88);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 46);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTroLai);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1058, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(348, 134);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::Detai.Properties.Resources.arrow_refresh;
            this.btnTroLai.Location = new System.Drawing.Point(176, 75);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(160, 46);
            this.btnTroLai.TabIndex = 10;
            this.btnTroLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(8, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(328, 33);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::Detai.Properties.Resources.folder_search;
            this.btnTimKiem.Location = new System.Drawing.Point(8, 75);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 46);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cbquyen);
            this.groupBox1.Controls.Add(this.lblTongso);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttendn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(516, 172);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản hệ thống phần mềm";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Cán bộ",
            "Học viên"});
            this.comboBox1.Location = new System.Drawing.Point(165, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 33);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Visible = false;
            // 
            // cbquyen
            // 
            this.cbquyen.Enabled = false;
            this.cbquyen.FormattingEnabled = true;
            this.cbquyen.Items.AddRange(new object[] {
            "Admin",
            "Cán bộ",
            "Học viên"});
            this.cbquyen.Location = new System.Drawing.Point(165, 116);
            this.cbquyen.Margin = new System.Windows.Forms.Padding(4);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Size = new System.Drawing.Size(341, 33);
            this.cbquyen.TabIndex = 31;
            this.cbquyen.SelectedValueChanged += new System.EventHandler(this.cbquyen_SelectedValueChanged);
            this.cbquyen.TextChanged += new System.EventHandler(this.cbquyen_TextChanged);
            // 
            // lblTongso
            // 
            this.lblTongso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongso.AutoSize = true;
            this.lblTongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongso.Location = new System.Drawing.Point(63, 352);
            this.lblTongso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongso.Name = "lblTongso";
            this.lblTongso.Size = new System.Drawing.Size(0, 20);
            this.lblTongso.TabIndex = 30;
            this.lblTongso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(165, 75);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4);
            this.txtmk.Name = "txtmk";
            this.txtmk.ReadOnly = true;
            this.txtmk.Size = new System.Drawing.Size(341, 33);
            this.txtmk.TabIndex = 2;
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(165, 34);
            this.txttendn.Margin = new System.Windows.Forms.Padding(4);
            this.txttendn.Name = "txttendn";
            this.txttendn.ReadOnly = true;
            this.txttendn.Size = new System.Drawing.Size(341, 33);
            this.txttendn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // dtgHienthi
            // 
            this.dtgHienthi.AllowUserToAddRows = false;
            this.dtgHienthi.AllowUserToDeleteRows = false;
            this.dtgHienthi.AllowUserToResizeColumns = false;
            this.dtgHienthi.AllowUserToResizeRows = false;
            this.dtgHienthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHienthi.AutoGenerateColumns = false;
            this.dtgHienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHienthi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgHienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangnhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dtgHienthi.DataSource = this.tblDangNhapBindingSource;
            this.dtgHienthi.Location = new System.Drawing.Point(13, 209);
            this.dtgHienthi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgHienthi.MultiSelect = false;
            this.dtgHienthi.Name = "dtgHienthi";
            this.dtgHienthi.ReadOnly = true;
            this.dtgHienthi.RowHeadersWidth = 51;
            this.dtgHienthi.Size = new System.Drawing.Size(1426, 476);
            this.dtgHienthi.TabIndex = 47;
            // 
            // tenDangnhapDataGridViewTextBoxColumn
            // 
            this.tenDangnhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangnhap";
            this.tenDangnhapDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenDangnhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDangnhapDataGridViewTextBoxColumn.Name = "tenDangnhapDataGridViewTextBoxColumn";
            this.tenDangnhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblDangNhapBindingSource
            // 
            this.tblDangNhapBindingSource.DataMember = "tblDangNhap";
            this.tblDangNhapBindingSource.DataSource = this.qLDT;
            // 
            // qLDT
            // 
            this.qLDT.DataSetName = "QLDT";
            this.qLDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1151, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 50;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblDangNhapTableAdapter
            // 
            this.tblDangNhapTableAdapter.ClearBeforeFill = true;
            // 
            // FrTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgHienthi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin quản lý tài khoản";
            this.Load += new System.EventHandler(this.FrTaiKhoan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChihsua;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTongso;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHienthi;
        private QLDT1 qLDT;
        private System.Windows.Forms.BindingSource tblDangNhapBindingSource;
        private QLDT1TableAdapters.tblDangNhapTableAdapter tblDangNhapTableAdapter;
        private System.Windows.Forms.ComboBox cbquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangnhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}