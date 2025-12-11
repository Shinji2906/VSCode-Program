namespace QLySV_T36S4.GUI
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_MaKhoa = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_TenKhoa = new System.Windows.Forms.Label();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.txt_TenKhoa = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.dgv_gs = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.txt_TenKhoa);
            this.groupBox1.Controls.Add(this.txt_MaKhoa);
            this.groupBox1.Controls.Add(this.lbl_TenKhoa);
            this.groupBox1.Controls.Add(this.lbl_SoLuong);
            this.groupBox1.Controls.Add(this.lbl_MaKhoa);
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin khoa";
            // 
            // lbl_MaKhoa
            // 
            this.lbl_MaKhoa.AutoSize = true;
            this.lbl_MaKhoa.Location = new System.Drawing.Point(37, 74);
            this.lbl_MaKhoa.Name = "lbl_MaKhoa";
            this.lbl_MaKhoa.Size = new System.Drawing.Size(59, 16);
            this.lbl_MaKhoa.TabIndex = 0;
            this.lbl_MaKhoa.Text = "Ma khoa";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(37, 204);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(82, 16);
            this.lbl_SoLuong.TabIndex = 1;
            this.lbl_SoLuong.Text = "So luong GS";
            // 
            // lbl_TenKhoa
            // 
            this.lbl_TenKhoa.AutoSize = true;
            this.lbl_TenKhoa.Location = new System.Drawing.Point(37, 134);
            this.lbl_TenKhoa.Name = "lbl_TenKhoa";
            this.lbl_TenKhoa.Size = new System.Drawing.Size(65, 16);
            this.lbl_TenKhoa.TabIndex = 2;
            this.lbl_TenKhoa.Text = "Ten Khoa";
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(135, 71);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(166, 22);
            this.txt_MaKhoa.TabIndex = 3;
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.Location = new System.Drawing.Point(135, 131);
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Size = new System.Drawing.Size(166, 22);
            this.txt_TenKhoa.TabIndex = 4;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(135, 198);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(166, 22);
            this.txt_SoLuong.TabIndex = 5;
            // 
            // dgv_gs
            // 
            this.dgv_gs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gs.Location = new System.Drawing.Point(393, 52);
            this.dgv_gs.Name = "dgv_gs";
            this.dgv_gs.RowHeadersWidth = 51;
            this.dgv_gs.RowTemplate.Height = 24;
            this.dgv_gs.Size = new System.Drawing.Size(589, 415);
            this.dgv_gs.TabIndex = 1;
            this.dgv_gs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gs_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(177, 391);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Then/Sua";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(293, 391);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(907, 500);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 549);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_gs);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenKhoa;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.Label lbl_TenKhoa;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_MaKhoa;
        private System.Windows.Forms.DataGridView dgv_gs;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_exit;
    }
}