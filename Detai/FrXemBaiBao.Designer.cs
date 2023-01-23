namespace Detai
{
    partial class FrXemBaiBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrXemBaiBao));
            this.brnDoimk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgHienthi = new System.Windows.Forms.DataGridView();
            this.maBaiBaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBaiBaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDT = new Detai.QLDT1();
            this.view_3TableAdapter = new Detai.QLDT1TableAdapters.View_3TableAdapter();
            this.bntIn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).BeginInit();
            this.SuspendLayout();
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
            this.brnDoimk.TabIndex = 56;
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
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(13, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 72);
            this.button1.TabIndex = 54;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox2.TabIndex = 53;
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
            this.maBaiBaoDataGridViewTextBoxColumn,
            this.tenBaiBaoDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.tenTacGiaDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn});
            this.dtgHienthi.DataSource = this.view3BindingSource;
            this.dtgHienthi.Location = new System.Drawing.Point(402, 13);
            this.dtgHienthi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgHienthi.MultiSelect = false;
            this.dtgHienthi.Name = "dtgHienthi";
            this.dtgHienthi.ReadOnly = true;
            this.dtgHienthi.RowHeadersWidth = 51;
            this.dtgHienthi.Size = new System.Drawing.Size(1142, 712);
            this.dtgHienthi.TabIndex = 52;
            // 
            // maBaiBaoDataGridViewTextBoxColumn
            // 
            this.maBaiBaoDataGridViewTextBoxColumn.DataPropertyName = "MaBaiBao";
            this.maBaiBaoDataGridViewTextBoxColumn.HeaderText = "Mã bài báo";
            this.maBaiBaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maBaiBaoDataGridViewTextBoxColumn.Name = "maBaiBaoDataGridViewTextBoxColumn";
            this.maBaiBaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenBaiBaoDataGridViewTextBoxColumn
            // 
            this.tenBaiBaoDataGridViewTextBoxColumn.DataPropertyName = "TenBaiBao";
            this.tenBaiBaoDataGridViewTextBoxColumn.HeaderText = "Tên bài báo";
            this.tenBaiBaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenBaiBaoDataGridViewTextBoxColumn.Name = "tenBaiBaoDataGridViewTextBoxColumn";
            this.tenBaiBaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.thoiGianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiBaiBaoDataGridViewTextBoxColumn
            // 
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiBaiBao";
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn.HeaderText = "Loại bài báo";
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn.Name = "tenLoaiBaiBaoDataGridViewTextBoxColumn";
            this.tenLoaiBaiBaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
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
            // view3BindingSource
            // 
            this.view3BindingSource.DataMember = "View_3";
            this.view3BindingSource.DataSource = this.qLDT;
            // 
            // qLDT
            // 
            this.qLDT.DataSetName = "QLDT";
            this.qLDT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_3TableAdapter
            // 
            this.view_3TableAdapter.ClearBeforeFill = true;
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
            this.bntIn.TabIndex = 58;
            this.bntIn.Text = "In thông tin";
            this.bntIn.UseVisualStyleBackColor = true;
            this.bntIn.Click += new System.EventHandler(this.bntIn_Click);
            // 
            // FrXemBaiBao
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
            this.Name = "FrXemBaiBao";
            this.Text = "FrXemBaiBao";
            this.Load += new System.EventHandler(this.FrXemBaiBao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button brnDoimk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgHienthi;
        private QLDT1 qLDT;
        private System.Windows.Forms.BindingSource view3BindingSource;
        private QLDT1TableAdapters.View_3TableAdapter view_3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBaiBaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBaiBaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiBaiBaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bntIn;
    }
}