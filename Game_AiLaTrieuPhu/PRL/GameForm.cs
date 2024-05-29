using Game_AiLaTrieuPhu.BUS;
using Game_AiLaTrieuPhu.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_AiLaTrieuPhu.PRL
{
    public partial class GameForm : Form
    {
        GameServices services = new GameServices();
        List<int> selectedQuestions = new List<int>();
        int selectID;
        int[] questionMoney = new int[15] { 1000000, 2000000, 3000000, 5000000, 10000000, 15000000, 23000000, 40000000, 60000000, 100000000, 250000000, 400000000, 650000000, 800000000, 900000000 };
        int selecteIndex = 0;
        bool isGameOver = false;
        int lever = 1;

        int timeLimit = 30;
        public GameForm()
        {
            InitializeComponent();

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            ptb_5050.Visible = true; ptb_Change.Visible = true;
            ptb_Viewer.Visible = true; ptb_Pro.Visible = true;
            time_limit.Start();
            selectedQuestions.Clear();
            selectID = 0;
            selecteIndex = 0;
            isGameOver = false;
            grb_CauHoi.Enabled = true;
            lb_Money.Text = "0";


            btn_1.BackColor = Color.LightBlue;
            btn_Start.Enabled = false;
            RandomQuestionShow();


        }
        private void time_limit_Tick(object sender, EventArgs e)
        {
            // khi bắt đầu  trò chơi hặc câu hỏi mới
            timeLimit--;
            time_limit.Interval = 1000;
            lb_Time.Text = timeLimit.ToString();

            if (lb_Time.Text == "0")
            {
                time_limit.Stop();
                MessageBox.Show($"Hết thời gian chơi" +
                    $"Bạn gia về số tiền là : {lb_Money.Text} VND");
                btn_Start.Enabled = true;
            }
        }

        public void RandomQuestionShow()
        {
            lb_Time.Text = "30";
            timeLimit = 30;
            while (selectedQuestions.Count < services.CountQuestionLever(lever))
            {

                var question = services.RandomQuestion(lever);
                if (!selectedQuestions.Contains(question.Id))
                {
                    tbt_Question.Text = $"Câu hỏi số {selecteIndex + 1}: " + question.QuestionText;
                    btn_A.Text = question.AnswerA;
                    btn_B.Text = question.AnswerB;
                    btn_C.Text = question.AnswerC;
                    btn_D.Text = question.AnswerD;
                    selectedQuestions.Add(question.Id);
                    selectID = question.Id;
                    break;

                }
                else continue;
            }
        }

        public void CheckTrue(string answer)
        {
            if (isGameOver)
            {
                return; // Nếu trò chơi đã kết thúc, không xử lý nữa
            }

            if (services.CheckTrueAnswer(selectID, answer))
            {
                MessageBox.Show("Đúng");

                if (selecteIndex < questionMoney.Length)
                {
                    lb_Money.Text = questionMoney[selecteIndex].ToString();
                    selecteIndex++;
                    if (selecteIndex == 10) { lever = 3; selectedQuestions.Clear(); }
                    else if (selecteIndex == 5) { lever = 2; selectedQuestions.Clear(); }
                    if (selecteIndex == 10)
                    { MessageBox.Show("Chúc mừng, bạn đã hoàn thành mốc 10 của trò chơi!"); }
                    else if (selecteIndex == 5)
                    {

                        MessageBox.Show("Chúc mừng, bạn đã hoàn thành mốc 5 của trò chơi!");
                    }
                    // Kiểm tra xem selecteIndex có vượt quá giới hạn không

                    // Kích hoạt mục tiêu tiếp theo
                    ActivateTargetAt(selecteIndex);
                    if (selecteIndex >= questionMoney.Length)
                    {
                        // Khi người chơi đã trả lời hết câu hỏi, thông báo kết thúc trò chơi
                        MessageBox.Show($"Chúc mừng, bạn đã hoàn thành trò chơi. {lb_Money.Text} ");
                        isGameOver = true; // Đánh dấu trò chơi đã kết thúc
                        time_limit.Stop();
                        selecteIndex = 0;
                        btn_Start.Enabled = true;
                    }
                    else
                    {
                        RandomQuestionShow();
                    }
                }
            }
            else
            {
                time_limit.Stop();
                MessageBox.Show($"Bạn ra về với số tiền {lb_Money.Text}");
                grb_CauHoi.Enabled = false;
                isGameOver = true; // Đánh dấu trò chơi đã kết thúc
                btn_Start.Enabled = true;
            }
        }
                private void ResetTargetButtonColors()
        {
            // Đặt lại màu của các nút mục tiêu (btn_1, btn_2, ...)
            for (int i = 1; i <= 15; i++)
            {
                Control[] controls = grb_Moc.Controls.Find("btn_" + i, true);
                if (controls.Length > 0 && controls[0] is Button)
                {
                    Button targetButton = (Button)controls[0];
                    targetButton.BackColor = DefaultBackColor; // Đặt lại màu mặc định
                }
            }
        }
        private void ActivateTargetAt(int index)
        {
            // Xóa màu nền của tất cả các nút
            foreach (Control control in grb_Moc.Controls)
            {
                if (control is Button)
                {
                    (control as Button).BackColor = SystemColors.Control; // Màu nền mặc định
                }
            }

            // Đảm bảo index nằm trong khoảng hợp lệ (tùy thuộc vào số lượng nút)
            if (index >= 0 && index < grb_Moc.Controls.Count)
            {
                // Tìm nút tại vị trí index và đặt màu nền
                if (grb_Moc.Controls[index] is Button)
                {
                    (grb_Moc.Controls[index] as Button).BackColor = Color.LightBlue;
                    selecteIndex = index;
                }
            }
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            CheckTrue("A");
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            CheckTrue("C");
        }

        private void bt_B_Click(object sender, EventArgs e)
        {
            CheckTrue("B");
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            CheckTrue("D");
        }

        private void ptb_Viewer_Click(object sender, EventArgs e)
        {
            string trueAnswer = services.GetTrueAnswer(selectID);
            Random r = new Random();
            int r1 = r.Next(0, 30);
            int r2 = r.Next(0, 30);
            int r3 = r.Next(0, 30);
            int rTrue = 100 - r1 - r2 - r3;
            string show;
            if (trueAnswer == "A")
            {
                show = $"A: {rTrue}\nB: {r1}\nC: {r2}\nD: {r3}";
            }
            else if (trueAnswer == "A")
            {
                show = $"A: {r1}\nB: {rTrue}\nC: {r2}\nD: {r3}";
            }
            else if (trueAnswer == "A")
            {
                show = $"A: {r1}\nB: {r2}\nC: {rTrue}\nD: {r3}";
            }
            else
            {
                show = $"A: {r1}\nB: {r2}\nC: {r3}\nD: {rTrue}";
            }
            MessageBox.Show(show);
            ptb_Viewer.Visible = false;
        }

        private void ptb_5050_Click(object sender, EventArgs e)
        {
            string trueAnswer = services.GetTrueAnswer(selectID);
            Random r = new Random();
            int next = r.Next(3);
            if (trueAnswer == "A")
            {
                if (next == 1)
                {
                    btn_C.Text = ""; btn_D.Text = "";
                }
                else if (next == 2)
                {
                    btn_B.Text = ""; btn_D.Text = "";
                }
                else
                {
                    btn_C.Text = ""; btn_B.Text = "";
                }
            }
            else if (trueAnswer == "B")
            {
                if (next == 1)
                {
                    btn_C.Text = ""; btn_D.Text = "";
                }
                else if (next == 2)
                {
                    btn_A.Text = ""; btn_D.Text = "";
                }
                else
                {
                    btn_C.Text = ""; btn_A.Text = "";
                }
            }
            else if (trueAnswer == "C")
            {
                if (next == 1)
                {
                    btn_A.Text = ""; btn_D.Text = "";
                }
                else if (next == 2)
                {
                    btn_A.Text = ""; btn_B.Text = "";
                }
                else
                {
                    btn_C.Text = ""; btn_B.Text = "";
                }
            }
            else
            {
                if (next == 1)
                {
                    btn_A.Text = ""; btn_C.Text = "";
                }
                else if (next == 2)
                {
                    btn_A.Text = ""; btn_B.Text = "";
                }
                else
                {
                    btn_C.Text = ""; btn_B.Text = "";
                }
            }
            // aanr khi chọn xong
            ptb_5050.Visible = false;
        }

        private void ptb_Pro_Click(object sender, EventArgs e)
        {
            string trueAnswer = services.GetTrueAnswer(selectID);
            MessageBox.Show("Ban nen chon dap an " + trueAnswer);
            ptb_Pro.Visible = false;

        }

        private void ptb_Change_Click(object sender, EventArgs e)
        {
            RandomQuestionShow();



            ptb_Change.Visible = false;

        }


    }
}
