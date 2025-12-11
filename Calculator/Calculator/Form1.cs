using System.Linq.Expressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            //lay gia tri tu hai o nhap lieu va doi sang kieu so thuc
            //thuc hien phep cong
            //hien thi ket qua len o ket qua
            float a, b;
            try
            {
                LayDuLieu(out a, out b);
            }
            catch (Exception ex)
            {
                lbl_ErrorMessage.Text = ex.Message;
                return;
            }
            float kq = a + b;
            txt_Answer.Text = kq.ToString();

        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            float a, b;
            LayDuLieu(out a, out b);
            float kqtru = a - b;
            txt_Answer.Text = kqtru.ToString();
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            float a, b;
            LayDuLieu(out a, out b);
            float kqnhan = a * b;
            txt_Answer.Text = kqnhan.ToString();
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            float a, b;
            LayDuLieu(out a, out b);
            float kqchia = a / b;
            txt_Answer.Text = kqchia.ToString();
            if (b == 0)
            {
                lbl_ErrorMessage.Text = "Number 2 phai khac 0";
                return;
            }
        }

        private void LayDuLieu(out float a, out float b)
        {
            //replace sua loi co khoang trang
            string s1 = txt_Number1.Text.Replace(" ", "");
            if (!float.TryParse(s1, out a))
            {
                throw new Exception("Number 1 nhap khong dung dinh dang");
            }
            a = float.Parse(s1);
            string s2 = txt_Number2.Text.Replace(" ", "");
            b = float.Parse(s2);
        }

    }
}
