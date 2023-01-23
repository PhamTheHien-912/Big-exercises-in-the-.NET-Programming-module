namespace Detai
{
    partial class FrXemDeTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrXemDeTai));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgHienthi = new System.Windows.Forms.DataGridView();
            this.maDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDeTaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDT = new Detai.QLDT1();
            this.view_2TableAdapter = new Detai.QLDT1TableAdapters.View_2TableAdapter();
            this.brnDoimk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bntIn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTroLai);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(381, 174);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::Detai.Properties.Resources.arrow_refresh;
            this.btnTroLai.Location = new System.Drawing.Point(191, 75);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(175, 72);
            this.btnTroLai.TabIndex = 10;
            this.btnTroLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(358, 33);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::Detai.Properties.Resources.folder_search;
            this.btnTimKiem.Location = new System.Drawing.Point(8, 75);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 72);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.tenTacGiaDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dtgHienthi.DataSource = this.view2BindingSource;
            this.dtgHienthi.Location = new System.Drawing.Point(402, 13);
            this.dtgHienthi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgHienthi.MultiSelect = false;
            this.dtgHienthi.Name = "dtgHienthi";
            this.dtgHienthi.ReadOnly = true;
            this.dtgHienthi.RowHeadersWidth = 51;
            this.dtgHienthi.Size = new System.Drawing.Size(1246, 737);
            this.dtgHienthi.TabIndex = 46;
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
            this.thoigianDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.thoigianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoigianDataGridViewTextBoxColumn.Name = "thoigianDataGridViewTextBoxColumn";
            this.thoigianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTacGiaDataGridViewTextBoxColumn
            // 
            this.tenTacGiaDataGridViewTextBoxColumn.DataPropertyName = "TenTacGia";
            this.tenTacGiaDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            this.tenTacGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTacGiaDataGridViewTextBoxColumn.Name = "tenTacGiaDataGridViewTextBoxColumn";
            this.tenTacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.donViDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            this.donViDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.dienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            this.dienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "Tên loại đề tài";
            this.tenLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            this.tenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View_2";
            this.view2BindingSource.DataSource = this.qLDT;
            // 
            // qLDT
            // 
            this.qLDT.DataSetName = "QLDT";
            this.qLDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // brnDoimk
            // 
            this.brnDoimk.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDoimk.Image = ((System.Drawing.Image)(resources.GetObject("brnDoimk.Image")));
            this.brnDoimk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brnDoimk.Location = new System.Drawing.Point(204, 195);
            this.brnDoimk.Margin = new System.Windows.Forms.Padding(4);
            this.brnDoimk.Name = "brnDoimk";
            this.brnDoimk.Size = new System.Drawing.Size(175, 72);
            this.brnDoimk.TabIndex = 50;
            this.brnDoimk.Text = "\nĐổi Mật Khẩu ";
            this.brnDoimk.UseVisualStyleBackColor = true;
            this.brnDoimk.Click += new System.EventHandler(this.brnDoimk_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Detai.Properties.Resources.folder_go;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(204, 275);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 72);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(21, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 72);
            this.button1.TabIndex = 48;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntIn
            // 
            this.bntIn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIn.Image = ((System.Drawing.Image)(resources.GetObject("bntIn.Image")));
            this.bntIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntIn.Location = new System.Drawing.Point(21, 275);
            this.bntIn.Margin = new System.Windows.Forms.Padding(4);
            this.bntIn.Name = "bntIn";
            this.bntIn.Size = new System.Drawing.Size(175, 72);
            this.bntIn.TabIndex = 52;
            this.bntIn.Text = "In thông tin";
            this.bntIn.UseVisualStyleBackColor = true;
            this.bntIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrXemDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 738);
            this.Controls.Add(this.bntIn);
            this.Controls.Add(this.brnDoimk);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgHienthi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrXemDeTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin chi tiết đề tài khoa học, đề tài tốt nghiệp của Khoa CNTT";
            this.Load += new System.EventHandler(this.FrXemDeTai_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgHienthi;
        private QLDT1 qLDT;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private QLDT1TableAdapters.View_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button brnDoimk;
        private System.Windows.Forms.Button bntIn;
    }
}