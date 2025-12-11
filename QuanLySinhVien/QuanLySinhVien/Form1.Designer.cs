namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbo_CNganh = new ComboBox();
            rdo_Nu = new RadioButton();
            rdo_Nam = new RadioButton();
            txt_DiemTB = new TextBox();
            txt_HoTen = new TextBox();
            txt_MSSV = new TextBox();
            label6 = new Label();
            lbl_DiemTB = new Label();
            label4 = new Label();
            lbl_HoTen = new Label();
            lbl_MSSV = new Label();
            btn_them = new Button();
            btn_Xoa = new Button();
            dgv_SinhVien = new DataGridView();
            lbl_nam = new Label();
            txt_SLNam = new TextBox();
            lbl_nu = new Label();
            txt_SLNu = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 20);
            label1.Name = "label1";
            label1.Size = new Size(298, 28);
            label1.TabIndex = 0;
            label1.Text = "QUAN LY THONG TIN SINH VIEN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbo_CNganh);
            groupBox1.Controls.Add(rdo_Nu);
            groupBox1.Controls.Add(rdo_Nam);
            groupBox1.Controls.Add(txt_DiemTB);
            groupBox1.Controls.Add(txt_HoTen);
            groupBox1.Controls.Add(txt_MSSV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbl_DiemTB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbl_HoTen);
            groupBox1.Controls.Add(lbl_MSSV);
            groupBox1.Location = new Point(41, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 258);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin SV";
            // 
            // cbo_CNganh
            // 
            cbo_CNganh.FormattingEnabled = true;
            cbo_CNganh.Location = new Point(117, 213);
            cbo_CNganh.Name = "cbo_CNganh";
            cbo_CNganh.Size = new Size(206, 28);
            cbo_CNganh.TabIndex = 11;
            // 
            // rdo_Nu
            // 
            rdo_Nu.AutoSize = true;
            rdo_Nu.Location = new Point(205, 123);
            rdo_Nu.Name = "rdo_Nu";
            rdo_Nu.Size = new Size(49, 24);
            rdo_Nu.TabIndex = 10;
            rdo_Nu.TabStop = true;
            rdo_Nu.Text = "Nu";
            rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            rdo_Nam.AutoSize = true;
            rdo_Nam.Location = new Point(117, 123);
            rdo_Nam.Name = "rdo_Nam";
            rdo_Nam.Size = new Size(62, 24);
            rdo_Nam.TabIndex = 9;
            rdo_Nam.TabStop = true;
            rdo_Nam.Text = "Nam";
            rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_DiemTB
            // 
            txt_DiemTB.Location = new Point(117, 170);
            txt_DiemTB.Name = "txt_DiemTB";
            txt_DiemTB.Size = new Size(206, 27);
            txt_DiemTB.TabIndex = 8;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(117, 74);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(206, 27);
            txt_HoTen.TabIndex = 6;
            // 
            // txt_MSSV
            // 
            txt_MSSV.Location = new Point(117, 29);
            txt_MSSV.Name = "txt_MSSV";
            txt_MSSV.Size = new Size(206, 27);
            txt_MSSV.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 216);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 4;
            label6.Text = "Chuyen Nganh";
            // 
            // lbl_DiemTB
            // 
            lbl_DiemTB.AutoSize = true;
            lbl_DiemTB.Location = new Point(6, 173);
            lbl_DiemTB.Name = "lbl_DiemTB";
            lbl_DiemTB.Size = new Size(66, 20);
            lbl_DiemTB.TabIndex = 3;
            lbl_DiemTB.Text = "Diem TB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 123);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 2;
            label4.Text = "Gioi Tinh";
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(6, 77);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(56, 20);
            lbl_HoTen.TabIndex = 1;
            lbl_HoTen.Text = "Ho Ten";
            // 
            // lbl_MSSV
            // 
            lbl_MSSV.AutoSize = true;
            lbl_MSSV.Location = new Point(6, 32);
            lbl_MSSV.Name = "lbl_MSSV";
            lbl_MSSV.Size = new Size(47, 20);
            lbl_MSSV.TabIndex = 0;
            lbl_MSSV.Text = "MSSV";
            // 
            // btn_them
            // 
            btn_them.Location = new Point(84, 389);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 2;
            btn_them.Text = "Them/Sua";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(235, 389);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 3;
            btn_Xoa.Text = "Xoa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // dgv_SinhVien
            // 
            dgv_SinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SinhVien.Location = new Point(382, 101);
            dgv_SinhVien.Name = "dgv_SinhVien";
            dgv_SinhVien.RowHeadersWidth = 51;
            dgv_SinhVien.Size = new Size(536, 258);
            dgv_SinhVien.TabIndex = 4;
            dgv_SinhVien.CellClick += dgv_SinhVien_CellClick;
            // 
            // lbl_nam
            // 
            lbl_nam.AutoSize = true;
            lbl_nam.Location = new Point(416, 393);
            lbl_nam.Name = "lbl_nam";
            lbl_nam.Size = new Size(76, 20);
            lbl_nam.TabIndex = 5;
            lbl_nam.Text = "So sv nam";
            // 
            // txt_SLNam
            // 
            txt_SLNam.Location = new Point(498, 390);
            txt_SLNam.Name = "txt_SLNam";
            txt_SLNam.ReadOnly = true;
            txt_SLNam.Size = new Size(53, 27);
            txt_SLNam.TabIndex = 6;
            // 
            // lbl_nu
            // 
            lbl_nu.AutoSize = true;
            lbl_nu.Location = new Point(557, 394);
            lbl_nu.Name = "lbl_nu";
            lbl_nu.Size = new Size(63, 20);
            lbl_nu.TabIndex = 7;
            lbl_nu.Text = "So sv nu";
            // 
            // txt_SLNu
            // 
            txt_SLNu.Location = new Point(626, 390);
            txt_SLNu.Name = "txt_SLNu";
            txt_SLNu.ReadOnly = true;
            txt_SLNu.Size = new Size(53, 27);
            txt_SLNu.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(txt_SLNu);
            Controls.Add(lbl_nu);
            Controls.Add(txt_SLNam);
            Controls.Add(lbl_nam);
            Controls.Add(dgv_SinhVien);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_them);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label lbl_DiemTB;
        private Label label4;
        private Label lbl_HoTen;
        private Label lbl_MSSV;
        private TextBox txt_DiemTB;
        private TextBox txt_HoTen;
        private TextBox txt_MSSV;
        private ComboBox cbo_CNganh;
        private RadioButton rdo_Nu;
        private RadioButton rdo_Nam;
        private Button btn_them;
        private Button btn_Xoa;
        private DataGridView dgv_SinhVien;
        private Label lbl_nam;
        private TextBox txt_SLNam;
        private Label lbl_nu;
        private TextBox txt_SLNu;
    }
}
