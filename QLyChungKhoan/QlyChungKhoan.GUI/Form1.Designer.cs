namespace QlyChungKhoan.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_MaCK = new System.Windows.Forms.ComboBox();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.lbl_SoTien = new System.Windows.Forms.Label();
            this.lbl_MaCK = new System.Windows.Forms.Label();
            this.lbl_Gioi = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.dgv_ChungKhoan = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_nhapkhachhang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChungKhoan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan ly chung khoan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MaCK);
            this.groupBox1.Controls.Add(this.txt_SoTien);
            this.groupBox1.Controls.Add(this.rdo_Nu);
            this.groupBox1.Controls.Add(this.rdo_nam);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.lbl_SoTien);
            this.groupBox1.Controls.Add(this.lbl_MaCK);
            this.groupBox1.Controls.Add(this.lbl_Gioi);
            this.groupBox1.Controls.Add(this.lbl_TenKH);
            this.groupBox1.Controls.Add(this.lbl_MaKH);
            this.groupBox1.Location = new System.Drawing.Point(33, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quan ly khach hang";
            // 
            // cb_MaCK
            // 
            this.cb_MaCK.FormattingEnabled = true;
            this.cb_MaCK.Location = new System.Drawing.Point(139, 204);
            this.cb_MaCK.Name = "cb_MaCK";
            this.cb_MaCK.Size = new System.Drawing.Size(169, 24);
            this.cb_MaCK.TabIndex = 9;
            this.cb_MaCK.SelectedIndexChanged += new System.EventHandler(this.cb_MaCK_SelectedIndexChanged);
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Location = new System.Drawing.Point(139, 253);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(169, 22);
            this.txt_SoTien.TabIndex = 8;
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Location = new System.Drawing.Point(190, 149);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(45, 20);
            this.rdo_Nu.TabIndex = 7;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nu";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(84, 149);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(57, 20);
            this.rdo_nam.TabIndex = 6;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(139, 94);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(169, 22);
            this.txt_TenKH.TabIndex = 5;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(139, 43);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(169, 22);
            this.txt_MaKH.TabIndex = 4;
            // 
            // lbl_SoTien
            // 
            this.lbl_SoTien.AutoSize = true;
            this.lbl_SoTien.Location = new System.Drawing.Point(6, 259);
            this.lbl_SoTien.Name = "lbl_SoTien";
            this.lbl_SoTien.Size = new System.Drawing.Size(105, 16);
            this.lbl_SoTien.TabIndex = 2;
            this.lbl_SoTien.Text = "So tien tai khoan";
            // 
            // lbl_MaCK
            // 
            this.lbl_MaCK.AutoSize = true;
            this.lbl_MaCK.Location = new System.Drawing.Point(6, 204);
            this.lbl_MaCK.Name = "lbl_MaCK";
            this.lbl_MaCK.Size = new System.Drawing.Size(108, 16);
            this.lbl_MaCK.TabIndex = 3;
            this.lbl_MaCK.Text = "Ma Chung Khoan";
            // 
            // lbl_Gioi
            // 
            this.lbl_Gioi.AutoSize = true;
            this.lbl_Gioi.Location = new System.Drawing.Point(6, 149);
            this.lbl_Gioi.Name = "lbl_Gioi";
            this.lbl_Gioi.Size = new System.Drawing.Size(31, 16);
            this.lbl_Gioi.TabIndex = 2;
            this.lbl_Gioi.Text = "Gioi";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Location = new System.Drawing.Point(6, 97);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(107, 16);
            this.lbl_TenKH.TabIndex = 1;
            this.lbl_TenKH.Text = "Ten Khach Hang";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Location = new System.Drawing.Point(6, 43);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(102, 16);
            this.lbl_MaKH.TabIndex = 0;
            this.lbl_MaKH.Text = "Ma Khach Hang";
            // 
            // dgv_ChungKhoan
            // 
            this.dgv_ChungKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChungKhoan.Location = new System.Drawing.Point(386, 70);
            this.dgv_ChungKhoan.Name = "dgv_ChungKhoan";
            this.dgv_ChungKhoan.RowHeadersWidth = 51;
            this.dgv_ChungKhoan.RowTemplate.Height = 24;
            this.dgv_ChungKhoan.Size = new System.Drawing.Size(621, 379);
            this.dgv_ChungKhoan.TabIndex = 2;
            this.dgv_ChungKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChungKhoan_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(33, 419);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(76, 39);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(196, 419);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(77, 39);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(115, 419);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 39);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(932, 467);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChucNang
            // 
            this.ChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyKhoaToolStripMenuItem});
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Size = new System.Drawing.Size(95, 24);
            this.ChucNang.Text = "Chuc Nang";
            // 
            // quanLyKhoaToolStripMenuItem
            // 
            this.quanLyKhoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quanLyKhoaToolStripMenuItem.Image")));
            this.quanLyKhoaToolStripMenuItem.Name = "quanLyKhoaToolStripMenuItem";
            this.quanLyKhoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.quanLyKhoaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.quanLyKhoaToolStripMenuItem.Text = "Quan Ly Khoa";
            this.quanLyKhoaToolStripMenuItem.Click += new System.EventHandler(this.quanLyKhoaToolStripMenuItem_Click);
            // 
            // btn_nhapkhachhang
            // 
            this.btn_nhapkhachhang.Location = new System.Drawing.Point(755, 41);
            this.btn_nhapkhachhang.Name = "btn_nhapkhachhang";
            this.btn_nhapkhachhang.Size = new System.Drawing.Size(140, 23);
            this.btn_nhapkhachhang.TabIndex = 9;
            this.btn_nhapkhachhang.Text = "Nhap khach hang";
            this.btn_nhapkhachhang.UseVisualStyleBackColor = true;
            this.btn_nhapkhachhang.Click += new System.EventHandler(this.btn_nhapkhachhang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 519);
            this.Controls.Add(this.btn_nhapkhachhang);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_ChungKhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cb_MaCK_SelectedIndexChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChungKhoan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MaCK;
        private System.Windows.Forms.Label lbl_Gioi;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label lbl_SoTien;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.ComboBox cb_MaCK;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.DataGridView dgv_ChungKhoan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChucNang;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhoaToolStripMenuItem;
        private System.Windows.Forms.Button btn_nhapkhachhang;
    }
}

