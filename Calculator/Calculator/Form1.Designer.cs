namespace Calculator
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
            txt_Number1 = new TextBox();
            label2 = new Label();
            txt_Number2 = new TextBox();
            btn_Cong = new Button();
            btn_Tru = new Button();
            btn_Nhan = new Button();
            btn_Chia = new Button();
            label3 = new Label();
            txt_Answer = new TextBox();
            lbl_ErrorMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // txt_Number1
            // 
            txt_Number1.Location = new Point(121, 23);
            txt_Number1.Name = "txt_Number1";
            txt_Number1.Size = new Size(237, 27);
            txt_Number1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Number 2";
            // 
            // txt_Number2
            // 
            txt_Number2.Location = new Point(121, 61);
            txt_Number2.Name = "txt_Number2";
            txt_Number2.Size = new Size(237, 27);
            txt_Number2.TabIndex = 3;
            // 
            // btn_Cong
            // 
            btn_Cong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cong.Location = new Point(121, 110);
            btn_Cong.Name = "btn_Cong";
            btn_Cong.Size = new Size(40, 36);
            btn_Cong.TabIndex = 4;
            btn_Cong.Text = "+";
            btn_Cong.UseVisualStyleBackColor = true;
            btn_Cong.Click += btn_Cong_Click;
            // 
            // btn_Tru
            // 
            btn_Tru.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Tru.Location = new Point(185, 110);
            btn_Tru.Name = "btn_Tru";
            btn_Tru.Size = new Size(40, 36);
            btn_Tru.TabIndex = 5;
            btn_Tru.Text = "-";
            btn_Tru.UseVisualStyleBackColor = true;
            btn_Tru.Click += btn_Tru_Click;
            // 
            // btn_Nhan
            // 
            btn_Nhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Nhan.Location = new Point(252, 110);
            btn_Nhan.Name = "btn_Nhan";
            btn_Nhan.Size = new Size(40, 36);
            btn_Nhan.TabIndex = 6;
            btn_Nhan.Text = "*";
            btn_Nhan.UseVisualStyleBackColor = true;
            btn_Nhan.Click += btn_Nhan_Click;
            // 
            // btn_Chia
            // 
            btn_Chia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Chia.Location = new Point(318, 110);
            btn_Chia.Name = "btn_Chia";
            btn_Chia.Size = new Size(40, 36);
            btn_Chia.TabIndex = 7;
            btn_Chia.Text = "/";
            btn_Chia.UseVisualStyleBackColor = true;
            btn_Chia.Click += btn_Chia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 176);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            // 
            // txt_Answer
            // 
            txt_Answer.Location = new Point(121, 173);
            txt_Answer.Name = "txt_Answer";
            txt_Answer.Size = new Size(237, 27);
            txt_Answer.TabIndex = 9;
            // 
            // lbl_ErrorMessage
            // 
            lbl_ErrorMessage.AutoSize = true;
            lbl_ErrorMessage.ForeColor = Color.Red;
            lbl_ErrorMessage.Location = new Point(74, 275);
            lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            lbl_ErrorMessage.Size = new Size(0, 20);
            lbl_ErrorMessage.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ErrorMessage);
            Controls.Add(txt_Answer);
            Controls.Add(label3);
            Controls.Add(btn_Chia);
            Controls.Add(btn_Nhan);
            Controls.Add(btn_Tru);
            Controls.Add(btn_Cong);
            Controls.Add(txt_Number2);
            Controls.Add(label2);
            Controls.Add(txt_Number1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Number1;
        private Label label2;
        private TextBox txt_Number2;
        private Button btn_Cong;
        private Button btn_Tru;
        private Button btn_Nhan;
        private Button btn_Chia;
        private Label label3;
        private TextBox txt_Answer;
        private Label lbl_ErrorMessage;
    }
}
