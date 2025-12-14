namespace QLyCafe.GUI
{
    partial class Form_QLDanhMuc
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.dgv_Category_Deleted = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category_Deleted)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAN LY DANH MUC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Message);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_CategoryName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_CategoryID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.Location = new System.Drawing.Point(78, 33);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.Size = new System.Drawing.Size(100, 22);
            this.txt_CategoryID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ten";
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Location = new System.Drawing.Point(279, 36);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(214, 22);
            this.txt_CategoryName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thong Bao";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xoa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Khoi Phuc";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_Message.Location = new System.Drawing.Point(41, 102);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 16);
            this.lbl_Message.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(43, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 331);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Category);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh muc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Category_Deleted);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh muc da xoa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Category
            // 
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Location = new System.Drawing.Point(0, 0);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.RowHeadersWidth = 51;
            this.dgv_Category.RowTemplate.Height = 24;
            this.dgv_Category.Size = new System.Drawing.Size(928, 306);
            this.dgv_Category.TabIndex = 0;
            this.dgv_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Category_CellClick);
            // 
            // dgv_Category_Deleted
            // 
            this.dgv_Category_Deleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category_Deleted.Location = new System.Drawing.Point(3, 0);
            this.dgv_Category_Deleted.Name = "dgv_Category_Deleted";
            this.dgv_Category_Deleted.RowHeadersWidth = 51;
            this.dgv_Category_Deleted.RowTemplate.Height = 24;
            this.dgv_Category_Deleted.Size = new System.Drawing.Size(922, 302);
            this.dgv_Category_Deleted.TabIndex = 0;
            this.dgv_Category_Deleted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Category_Deleted_CellClick);
            // 
            // Form_QLDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_QLDanhMuc";
            this.Text = "Form_QLDanhMuc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QLDanhMuc_FormClosed);
            this.Load += new System.EventHandler(this.Form_QLDanhMuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category_Deleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.DataGridView dgv_Category_Deleted;
    }
}