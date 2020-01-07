using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;
using System.IO;

namespace MiniGameHeaven
{
    public partial class Form1 : Form
    {
        /*스레드를 이용하여 아이콘 애니메이션*/
        public Thread packmanIconThread;
        public Thread ballIconThread;
        public Label ID_label;
        /*폼 선언*/
        public pac_man Pman;
        public Ball ballGame;

        public PrivateFontCollection privateFonts = new PrivateFontCollection();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*라벨, 버튼 등의 스타일 정의*/
            privateFonts.AddFontFile("Resources/Sabo-Filled.ttf");
            Font font = new Font(privateFonts.Families[0], 50f);
            Font font2 = new Font(privateFonts.Families[0], 30f);
            Font font3 = new Font(privateFonts.Families[0], 20f);
            Font font4 = new Font(privateFonts.Families[0], 50f);

            Start.Font = font2;
            RankBtn.Font = font2;
            NameBox.Font = font2;
            OK.Font = font2;
            RankLa.Font = font2;
            BackToFirst.Font = font3;

            /*랭킹을 저장할 디렉토리 생성*/
            if (!Directory.Exists("./saveDir"))
            {
                Directory.CreateDirectory("./saveDir");
                File.Create("./saveDir/Rank.txt");
            }
        }

        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.ForeColor = Color.Red;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.ForeColor = Color.Black;
        }

        private void Lank_MouseEnter(object sender, EventArgs e)
        {
            RankBtn.ForeColor = Color.Red;
        }

        private void Lank_MouseLeave(object sender, EventArgs e)
        {
            RankBtn.ForeColor = Color.Black;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            RankPanel.Visible = false;
            selectPanel.Visible = false;

            NamePanel.Visible = true;
            BackToFirst.Visible = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (NameBox.TextLength != 3)
            {
                MessageBox.Show("사용자이름은 알파벳 3글자로 이용해 주세요.");
            }
            else
            {
                MainPanel.Visible = false;
                RankPanel.Visible = false;
                NamePanel.Visible = false;

                PrivateFontCollection privateFonts = new PrivateFontCollection();

                privateFonts.AddFontFile("Resources/Sabo-Filled.ttf");
                Font font2 = new Font(privateFonts.Families[0], 25f);
                selectPanel.Visible = true;
                ID_label = new Label();
                ID_label.AutoSize = true;
                ID_label.BackColor = Color.Transparent;
                ID_label.Font = font2;
                ID_label.Text = NameBox.Text;
                this.Controls.Add(ID_label);
                ID_label.Location = new System.Drawing.Point(450, 5);
                ID_label.BringToFront();

            }
        }

        private void PackManBtn_MouseEnter(object sender, EventArgs e)
        {
            Arrow1.Visible = true;
            packmanIconThread = new Thread(PackMove);
            packmanIconThread.Start();
        }
        private void PackMove()
        {
            while (true)
            {
                Thread.Sleep(300);
                PackManBtn1.BringToFront();
                Thread.Sleep(300);
                PackManBtn.BringToFront();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PackManBtn_MouseLeave(object sender, EventArgs e)
        {
            Arrow1.Visible = false;
            packmanIconThread.Abort();
        }

        private void ballMove()
        {
            while (true)
            {
                Thread.Sleep(300);
                BallIBtn1.BringToFront();
                Thread.Sleep(300);
                BallBtn.BringToFront();
            }
        }

        private void BallIBtn1_MouseEnter(object sender, EventArgs e)
        {
            Arrow2.Visible = true;
            ballIconThread = new Thread(ballMove);
            ballIconThread.Start();
        }

        private void BallIBtn1_MouseLeave(object sender, EventArgs e)
        {
            ballIconThread.Abort();
            Arrow2.Visible = false;
        }

        private void RankBtn_Click(object sender, EventArgs e)
        {
            selectPanel.Visible = false;
            MainPanel.Visible = false;
            titlePanel.Visible = false;
            NamePanel.Visible = false;

            RankPanel.Visible = true;

            RankPanel.Controls.Clear();
            Label[] userID, pScore, bScore;

            userID = new Label[10];
            pScore = new Label[10];
            bScore = new Label[10];

            Font font = new Font(privateFonts.Families[0], 20f);

            StreamReader sr = new System.IO.StreamReader("./saveDir/Rank.txt");
            String readString;

            RankPanel.Controls.Add(RankLa);
            for (int i = 0; i < 10; i++)
            {
                readString = sr.ReadLine();
                if (readString == null)
                {
                    sr.Close();
                    break;
                }
                else
                {
                    userID[i] = new Label();
                    pScore[i] = new Label();
                    bScore[i] = new Label();

                    String[] splits = readString.Split('$');
                    userID[i].Text = (i + 1).ToString() + ". " + splits[1];
                    pScore[i].Text = "PAC: " + splits[2];
                    bScore[i].Text = "BALL: " + splits[3];

                    userID[i].Font = font;
                    userID[i].Size = new System.Drawing.Size(115,50);
                    pScore[i].Font = font;
                    pScore[i].Size = new System.Drawing.Size(195, 50);
                    bScore[i].Font = font;
                    bScore[i].Size = new System.Drawing.Size(220, 50);

                    userID[i].Location = new System.Drawing.Point(5, 55 + i * 45);
                    pScore[i].Location = new System.Drawing.Point(125, 55 + i * 45);
                    bScore[i].Location = new System.Drawing.Point(315, 55+ i * 45);

                    RankPanel.Controls.Add(userID[i]);
                    RankPanel.Controls.Add(pScore[i]);
                    RankPanel.Controls.Add(bScore[i]);
                }
            }
            BackToFirst.Visible = true;
        }

        private void BackToFirst_Click(object sender, EventArgs e)
        {
            selectPanel.Visible = false;
            RankPanel.Visible = false;
            NamePanel.Visible = false;

            MainPanel.Visible = true;
            titlePanel.Visible = true;
            BackToFirst.Visible = false;
        }

        private void BackToFirst_MouseEnter(object sender, EventArgs e)
        {
            BackToFirst.ForeColor = Color.Red;
        }

        private void BackToFirst_MouseLeave(object sender, EventArgs e)
        {
            BackToFirst.ForeColor = Color.Black;
        }

        private void PackManBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Pman.Close();
            }
            catch (Exception) { };
            Pman = new pac_man();
            Pman.Show();
        }

        private void BallBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ballGame.Close();
            }
            catch (Exception) { };
            ballGame = new Ball();
            ballGame.Show();
        }
    }
}
