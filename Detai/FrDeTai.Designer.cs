namespace Detai
{
    partial class FrDeTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrDeTai));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTongso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtthoigian = new System.Windows.Forms.TextBox();
            this.cbMaLoaiDT = new System.Windows.Forms.ComboBox();
            this.tblMaLoaiDeTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDT = new Detai.QLDT1();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmatg = new System.Windows.Forms.ComboBox();
            this.tbTacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
            this.txttendetai = new System.Windows.Forms.TextBox();
            this.txtdetai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgHienthi = new System.Windows.Forms.DataGridView();
            this.maDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDeTaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbDeTaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChihsua = new System.Windows.Forms.Button();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tbDeTaiTableAdapter = new Detai.QLDT1TableAdapters.tbDeTaiTableAdapter();
            this.tblMaLoaiDeTaiTableAdapter = new Detai.QLDT1TableAdapters.tblMaLoaiDeTaiTableAdapter();
            this.tbTacGiaTableAdapter = new Detai.QLDT1TableAdapters.tbTacGiaTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblMaLoaiBaiBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMaLoaiBaiBaoTableAdapter = new Detai.QLDT1TableAdapters.tblMaLoaiBaiBaoTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaLoaiDeTaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTacGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeTaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeTaiBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaLoaiBaiBaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTroLai);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1090, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(344, 136);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::Detai.Properties.Resources.arrow_refresh;
            this.btnTroLai.Location = new System.Drawing.Point(173, 75);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(160, 46);
            this.btnTroLai.TabIndex = 10;
            this.btnTroLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnTroLai, "Refresh");
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(328, 33);
            this.txtTimKiem.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtTimKiem, "Nhập từ cần tìm kiếm");
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::Detai.Properties.Resources.folder_search;
            this.btnTimKiem.Location = new System.Drawing.Point(8, 75);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 46);
            this.btnTimKiem.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm kiếm");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTongso
            // 
            this.lblTongso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongso.AutoSize = true;
            this.lblTongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongso.Location = new System.Drawing.Point(161, 352);
            this.lblTongso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongso.Name = "lblTongso";
            this.lblTongso.Size = new System.Drawing.Size(0, 20);
            this.lblTongso.TabIndex = 30;
            this.lblTongso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtthoigian);
            this.groupBox1.Controls.Add(this.cbMaLoaiDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbmatg);
            this.groupBox1.Controls.Add(this.dtpthoigian);
            this.groupBox1.Controls.Add(this.lblTongso);
            this.groupBox1.Controls.Add(this.txttendetai);
            this.groupBox1.Controls.Add(this.txtdetai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(712, 245);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đề tài";
            // 
            // txtthoigian
            // 
            this.txtthoigian.Location = new System.Drawing.Point(171, 116);
            this.txtthoigian.Margin = new System.Windows.Forms.Padding(4);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.ReadOnly = true;
            this.txtthoigian.Size = new System.Drawing.Size(341, 33);
            this.txtthoigian.TabIndex = 38;
            // 
            // cbMaLoaiDT
            // 
            this.cbMaLoaiDT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMaLoaiDeTaiBindingSource, "MaloaiDeTai", true));
            this.cbMaLoaiDT.DataSource = this.tblMaLoaiDeTaiBindingSource;
            this.cbMaLoaiDT.DisplayMember = "TenLoai";
            this.cbMaLoaiDT.Enabled = false;
            this.cbMaLoaiDT.FormattingEnabled = true;
            this.cbMaLoaiDT.Location = new System.Drawing.Point(171, 157);
            this.cbMaLoaiDT.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaLoaiDT.Name = "cbMaLoaiDT";
            this.cbMaLoaiDT.Size = new System.Drawing.Size(341, 33);
            this.cbMaLoaiDT.TabIndex = 37;
            this.cbMaLoaiDT.ValueMember = "MaloaiDeTai";
            // 
            // tblMaLoaiDeTaiBindingSource
            // 
            this.tblMaLoaiDeTaiBindingSource.DataMember = "tblMaLoaiDeTai";
            this.tblMaLoaiDeTaiBindingSource.DataSource = this.qLDT;
            this.tblMaLoaiDeTaiBindingSource.CurrentChanged += new System.EventHandler(this.tblMaLoaiDeTaiBindingSource_CurrentChanged);
            // 
            // qLDT
            // 
            this.qLDT.DataSetName = "QLDT";
            this.qLDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mã tác giả";
            // 
            // cbmatg
            // 
            this.cbmatg.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTacGiaBindingSource, "MaTacGia", true));
            this.cbmatg.DataSource = this.tbTacGiaBindingSource;
            this.cbmatg.DisplayMember = "MaTacGia";
            this.cbmatg.Enabled = false;
            this.cbmatg.FormattingEnabled = true;
            this.cbmatg.Location = new System.Drawing.Point(171, 198);
            this.cbmatg.Margin = new System.Windows.Forms.Padding(4);
            this.cbmatg.Name = "cbmatg";
            this.cbmatg.Size = new System.Drawing.Size(341, 33);
            this.cbmatg.TabIndex = 35;
            this.cbmatg.ValueMember = "MaTacGia";
            // 
            // tbTacGiaBindingSource
            // 
            this.tbTacGiaBindingSource.DataMember = "tbTacGia";
            this.tbTacGiaBindingSource.DataSource = this.qLDT;
            this.tbTacGiaBindingSource.CurrentChanged += new System.EventHandler(this.tbTacGiaBindingSource_CurrentChanged);
            // 
            // dtpthoigian
            // 
            this.dtpthoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpthoigian.Location = new System.Drawing.Point(171, 116);
            this.dtpthoigian.Margin = new System.Windows.Forms.Padding(4);
            this.dtpthoigian.Name = "dtpthoigian";
            this.dtpthoigian.Size = new System.Drawing.Size(295, 33);
            this.dtpthoigian.TabIndex = 34;
            this.toolTip1.SetToolTip(this.dtpthoigian, "Nhập theo định dạng Tháng/Ngày/Năm");
            this.dtpthoigian.Visible = false;
            // 
            // txttendetai
            // 
            this.txttendetai.Location = new System.Drawing.Point(171, 75);
            this.txttendetai.Margin = new System.Windows.Forms.Padding(4);
            this.txttendetai.Name = "txttendetai";
            this.txttendetai.ReadOnly = true;
            this.txttendetai.Size = new System.Drawing.Size(533, 33);
            this.txttendetai.TabIndex = 2;
            // 
            // txtdetai
            // 
            this.txtdetai.Location = new System.Drawing.Point(171, 34);
            this.txtdetai.Margin = new System.Windows.Forms.Padding(4);
            this.txtdetai.Name = "txtdetai";
            this.txtdetai.ReadOnly = true;
            this.txtdetai.Size = new System.Drawing.Size(341, 33);
            this.txtdetai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã loại đề tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đề tài";
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
            this.maDeTaiDataGridViewTextBoxColumn,
            this.tenDeTaiDataGridViewTextBoxColumn,
            this.thoigianDataGridViewTextBoxColumn,
            this.maLoaiDeTaiDataGridViewTextBoxColumn,
            this.maTacGiaDataGridViewTextBoxColumn});
            this.dtgHienthi.DataSource = this.tbDeTaiBindingSource1;
            this.dtgHienthi.Location = new System.Drawing.Point(26, 266);
            this.dtgHienthi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgHienthi.MultiSelect = false;
            this.dtgHienthi.Name = "dtgHienthi";
            this.dtgHienthi.ReadOnly = true;
            this.dtgHienthi.RowHeadersWidth = 51;
            this.dtgHienthi.Size = new System.Drawing.Size(1408, 419);
            this.dtgHienthi.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dtgHienthi, "Bảng hiển thị học viên");
            // 
            // maDeTaiDataGridViewTextBoxColumn
            // 
            this.maDeTaiDataGridViewTextBoxColumn.DataPropertyName = "MaDeTai";
            this.maDeTaiDataGridViewTextBoxColumn.HeaderText = "Mã đề tài";
            this.maDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDeTaiDataGridViewTextBoxColumn.Name = "maDeTaiDataGridViewTextBoxColumn";
            this.maDeTaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDeTaiDataGridViewTextBoxColumn
            // 
            this.tenDeTaiDataGridViewTextBoxColumn.DataPropertyName = "TenDeTai";
            this.tenDeTaiDataGridViewTextBoxColumn.HeaderText = "Tên đề tài";
            this.tenDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDeTaiDataGridViewTextBoxColumn.Name = "tenDeTaiDataGridViewTextBoxColumn";
            this.tenDeTaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoigianDataGridViewTextBoxColumn
            // 
            this.thoigianDataGridViewTextBoxColumn.DataPropertyName = "Thoigian";
            this.thoigianDataGridViewTextBoxColumn.HeaderText = "Thời gian hoàn thành";
            this.thoigianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoigianDataGridViewTextBoxColumn.Name = "thoigianDataGridViewTextBoxColumn";
            this.thoigianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiDeTaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDeTaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiDeTai";
            this.maLoaiDeTaiDataGridViewTextBoxColumn.HeaderText = "Loại đề tài";
            this.maLoaiDeTaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiDeTaiDataGridViewTextBoxColumn.Name = "maLoaiDeTaiDataGridViewTextBoxColumn";
            this.maLoaiDeTaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTacGiaDataGridViewTextBoxColumn
            // 
            this.maTacGiaDataGridViewTextBoxColumn.DataPropertyName = "MaTacGia";
            this.maTacGiaDataGridViewTextBoxColumn.HeaderText = "Tác giả";
            this.maTacGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTacGiaDataGridViewTextBoxColumn.Name = "maTacGiaDataGridViewTextBoxColumn";
            this.maTacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbDeTaiBindingSource1
            // 
            this.tbDeTaiBindingSource1.DataMember = "tbDeTai";
            this.tbDeTaiBindingSource1.DataSource = this.qLDT;
            // 
            // tbDeTaiBindingSource
            // 
            this.tbDeTaiBindingSource.DataMember = "tbDeTai";
            this.tbDeTaiBindingSource.DataSource = this.qLDT;
            this.tbDeTaiBindingSource.CurrentChanged += new System.EventHandler(this.tbDeTaiBindingSource_CurrentChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::Detai.Properties.Resources.folder_go;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(176, 142);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btnExit, "Thoát");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Detai.Properties.Resources.textfield_clear;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(176, 36);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 46);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Detai.Properties.Resources.folder_delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(8, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 46);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.toolTip1.SetToolTip(this.btnDelete, "Xoá 1 học viên");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.toolTip1.SetToolTip(this.btnThemMoi, "Thêm mới 1 học viên");
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btnChihsua
            // 
            this.btnChihsua.Image = global::Detai.Properties.Resources.folder_edit;
            this.btnChihsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChihsua.Location = new System.Drawing.Point(8, 88);
            this.btnChihsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnChihsua.Name = "btnChihsua";
            this.btnChihsua.Size = new System.Drawing.Size(160, 46);
            this.btnChihsua.TabIndex = 34;
            this.btnChihsua.Text = "Chỉnh Sửa";
            this.toolTip1.SetToolTip(this.btnChihsua, "Chỉnh sửa");
            this.btnChihsua.UseVisualStyleBackColor = true;
            this.btnChihsua.Click += new System.EventHandler(this.btnChihsua_Click);
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
            this.btnOk2.Text = "Ok ";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Image = global::Detai.Properties.Resources.tick;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(176, 90);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(160, 46);
            this.buttonOK.TabIndex = 35;
            this.buttonOK.Text = "Ok ";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // tbDeTaiTableAdapter
            // 
            this.tbDeTaiTableAdapter.ClearBeforeFill = true;
            // 
            // tblMaLoaiDeTaiTableAdapter
            // 
            this.tblMaLoaiDeTaiTableAdapter.ClearBeforeFill = true;
            // 
            // tbTacGiaTableAdapter
            // 
            this.tbTacGiaTableAdapter.ClearBeforeFill = true;
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
            this.groupBox3.Location = new System.Drawing.Point(733, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(349, 245);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(-21, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 30;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1181, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tblMaLoaiBaiBaoBindingSource
            // 
            this.tblMaLoaiBaiBaoBindingSource.DataMember = "tblMaLoaiBaiBao";
            this.tblMaLoaiBaiBaoBindingSource.DataSource = this.qLDT;
            // 
            // tblMaLoaiBaiBaoTableAdapter
            // 
            this.tblMaLoaiBaiBaoTableAdapter.ClearBeforeFill = true;
            // 
            // FrDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1452, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgHienthi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrDeTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đề tài của sinh viên khoa CNTT";
            this.Load += new System.EventHandler(this.FrDeTai_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaLoaiDeTaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTacGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeTaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeTaiBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMaLoaiBaiBaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTongso;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttendetai;
        private System.Windows.Forms.TextBox txtdetai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHienthi;
        private System.Windows.Forms.DateTimePicker dtpthoigian;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmatg;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.ComboBox cbMaLoaiDT;
        private System.Windows.Forms.TextBox txtthoigian;
        private System.Windows.Forms.Button btnChihsua;
        private System.Windows.Forms.Button buttonOK;
        private QLDT1 qLDT;
        private System.Windows.Forms.BindingSource tbDeTaiBindingSource;
        private QLDT1TableAdapters.tbDeTaiTableAdapter tbDeTaiTableAdapter;
        private System.Windows.Forms.BindingSource tblMaLoaiDeTaiBindingSource;
        private QLDT1TableAdapters.tblMaLoaiDeTaiTableAdapter tblMaLoaiDeTaiTableAdapter;
        private System.Windows.Forms.BindingSource tbTacGiaBindingSource;
        private QLDT1TableAdapters.tbTacGiaTableAdapter tbTacGiaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbDeTaiBindingSource1;
        private System.Windows.Forms.BindingSource tblMaLoaiBaiBaoBindingSource;
        private QLDT1TableAdapters.tblMaLoaiBaiBaoTableAdapter tblMaLoaiBaiBaoTableAdapter;
    }
}