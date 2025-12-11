namespace QuanLySach.GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TheLoai = new System.Windows.Forms.ComboBox();
            this.txt_GioiThieu = new System.Windows.Forms.TextBox();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.lbl_TheLoai = new System.Windows.Forms.Label();
            this.lbl_GioiThieu = new System.Windows.Forms.Label();
            this.lbl_TacGia = new System.Windows.Forms.Label();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan Ly Sach";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_TheLoai);
            this.groupBox1.Controls.Add(this.txt_GioiThieu);
            this.groupBox1.Controls.Add(this.txt_TacGia);
            this.groupBox1.Controls.Add(this.txt_TenSach);
            this.groupBox1.Controls.Add(this.txt_MaSach);
            this.groupBox1.Controls.Add(this.lbl_TheLoai);
            this.groupBox1.Controls.Add(this.lbl_GioiThieu);
            this.groupBox1.Controls.Add(this.lbl_TacGia);
            this.groupBox1.Controls.Add(this.lbl_TenSach);
            this.groupBox1.Controls.Add(this.lbl_MaSach);
            this.groupBox1.Location = new System.Drawing.Point(29, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sach";
            // 
            // cb_TheLoai
            // 
            this.cb_TheLoai.FormattingEnabled = true;
            this.cb_TheLoai.Location = new System.Drawing.Point(127, 266);
            this.cb_TheLoai.Name = "cb_TheLoai";
            this.cb_TheLoai.Size = new System.Drawing.Size(275, 24);
            this.cb_TheLoai.TabIndex = 9;
            this.cb_TheLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_GioiThieu
            // 
            this.txt_GioiThieu.Location = new System.Drawing.Point(127, 212);
            this.txt_GioiThieu.Name = "txt_GioiThieu";
            this.txt_GioiThieu.Size = new System.Drawing.Size(275, 22);
            this.txt_GioiThieu.TabIndex = 8;
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Location = new System.Drawing.Point(127, 154);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(275, 22);
            this.txt_TacGia.TabIndex = 7;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(127, 103);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(275, 22);
            this.txt_TenSach.TabIndex = 6;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(127, 49);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(275, 22);
            this.txt_MaSach.TabIndex = 5;
            // 
            // lbl_TheLoai
            // 
            this.lbl_TheLoai.AutoSize = true;
            this.lbl_TheLoai.Location = new System.Drawing.Point(28, 269);
            this.lbl_TheLoai.Name = "lbl_TheLoai";
            this.lbl_TheLoai.Size = new System.Drawing.Size(60, 16);
            this.lbl_TheLoai.TabIndex = 3;
            this.lbl_TheLoai.Text = "The Loai";
            // 
            // lbl_GioiThieu
            // 
            this.lbl_GioiThieu.AutoSize = true;
            this.lbl_GioiThieu.Location = new System.Drawing.Point(25, 218);
            this.lbl_GioiThieu.Name = "lbl_GioiThieu";
            this.lbl_GioiThieu.Size = new System.Drawing.Size(68, 16);
            this.lbl_GioiThieu.TabIndex = 4;
            this.lbl_GioiThieu.Text = "Gioi Thieu";
            // 
            // lbl_TacGia
            // 
            this.lbl_TacGia.AutoSize = true;
            this.lbl_TacGia.Location = new System.Drawing.Point(28, 160);
            this.lbl_TacGia.Name = "lbl_TacGia";
            this.lbl_TacGia.Size = new System.Drawing.Size(53, 16);
            this.lbl_TacGia.TabIndex = 3;
            this.lbl_TacGia.Text = "Tac gia";
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Location = new System.Drawing.Point(23, 106);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(65, 16);
            this.lbl_TenSach.TabIndex = 2;
            this.lbl_TenSach.Text = "Ten Sach";
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Location = new System.Drawing.Point(28, 52);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(60, 16);
            this.lbl_MaSach.TabIndex = 0;
            this.lbl_MaSach.Text = "Ma Sach";
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(471, 91);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.RowTemplate.Height = 24;
            this.dgv_Sach.Size = new System.Drawing.Size(583, 405);
            this.dgv_Sach.TabIndex = 2;
            this.dgv_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(60, 461);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(332, 461);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(191, 461);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(969, 518);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoat";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 553);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_Sach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TacGia;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.ComboBox cb_TheLoai;
        private System.Windows.Forms.TextBox txt_GioiThieu;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label lbl_TheLoai;
        private System.Windows.Forms.Label lbl_GioiThieu;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

