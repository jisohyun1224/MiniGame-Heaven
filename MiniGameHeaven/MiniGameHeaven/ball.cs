using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Media;
using System.Threading;
using System.Resources;

namespace MiniGameHeaven
{
    public partial class Ball : Form
    {
 
        public Ball()
        {
            InitializeComponent();

            Assembly assem = this.GetType().Assembly; //주인공 캐릭터, 공 그림, 게임오버 그림 
            hero = new Bitmap(Properties.Resources.ball_hero);
            gong = new Bitmap(Properties.Resources.gong);                        
        }



        public class DoubleBufferPanel : Panel
        {
            public DoubleBufferPanel()
            {
                this.SetStyle(ControlStyles.DoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.UpdateStyles();
            }
        }

        //// 공용 변수들 선언 ////

        //String sound_directory; // 효과음의 경로
        //SoundPlayer ball_sound; // 공의 효과음 이름 선언

        Thread thread;

        public Bitmap hero;
        public Bitmap gong;

        public int level = 8; //난이도. 공의 갯수 결정.
        
        public int hero_x = 200, hero_y = 200;             // 주인공 시작 위치

        public int hero_size_x = 20, hero_size_y = 30;     // 주인공 크기

        public int field_size_x , field_size_y; // 필드 크기

        public int gong_size = 15;
        public int size = 0;                  // 공크기
    
        public int i, score = 0 , bonus = 1; // 점수
                        
        //공 위치
        public int[] gong_x = new int [30];
        public int[] gong_y = new int [30];

        //공 움직이는 기울기
        public int[] j = new int[30];
        public int[] k = new int[30];
                

        //// 공용 변수 선언 끝 ////


        public void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);

            field_size_x = this.panel2.Size.Width;
            field_size_y = this.panel2.Size.Height;

            String Program_dir = Environment.CurrentDirectory.ToString();   // 지정된 현재 위치 불러오기; 
                                                                            //sound_directory = Program_dir + @"\sound\";  // 효과음 경로 설정

            init(); // 게임 시작전 기본 변수들 초기화

            Graphics g = this.CreateGraphics();

            Cursor.Current = Cursors.Default;
            Cursor.Hide(); //커서 숨김


            thread = new Thread(upGong);
            thread.Start();

            i = 1;
            timer1.Enabled = true; //게임 시작을 위해 타이머1 시작
            timer1_Tick(sender, e);
        }

        //시간이 지나면서 공이 추가 됨
        public void upGong()
        {
            int i = 0;
            while (i < 20)
            {
                Thread.Sleep(3000);
                level++;
                i++;
            }
        }

        ////스타트 버튼 누르면 커서 사라지면서 게임 시작 ////                                                     
        public void start_Click(object sender, EventArgs e)
        {
        }

        public void init()  //초기 값들 초기화
        {
            this.panel2.BackgroundImage = global::MiniGameHeaven.Properties.Resources.ball_back;//바닥 초기화

            //공의 위치 초기화
            for (int count_loc=0; count_loc < level; count_loc++){
                gong_x[count_loc] = count_loc * 30;
                gong_y[count_loc] = 0;
                k[count_loc] = -1;
                j[count_loc] = -2;
            }


            
            timer1.Enabled = false;     // 공의 이동 타이머
            timer2.Enabled = false;     // 로딩 타이머
            i = 0;                      
            score = 0;                  // 점수 초기화
            gong_size = 20;             // 공의 크기 초기화
            size = 1;                   // 공의 사이즈 초기화          
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0) this.timer1.Enabled = false;
            else
            {
                this.timer1.Enabled = true;
    
            }
            score = score + bonus;  // 점수계산
            size++;
            this.timer1.Interval = 10;
            Refresh();
        }

        public void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);

            Graphics g = e.Graphics;
            if (i == 0) { }
            else if (i == 1)
            {

                //랜덤 배열
                Random Rnd = new Random();

                int[] rnd_x = new int[30];
                int[] rnd_y = new int[30];

                for (int count11 = 0; count11 < level; count11++)
                {
                    rnd_x[count11] = Rnd.Next(1, 6);
                    rnd_y[count11] = Rnd.Next(1, 6);
                }
                ////랜덤 배열 끝//
                gong_size = 15;
                gong_size = gong_size + (size / 100);


                g.DrawImage(hero, hero_x, hero_y, hero_size_x, hero_size_y);
                // 마우스 좌표에 따라 움직이는 케릭의 위치와 크기

                //공 그리기
                for (int draw = 0; draw < level; draw++)
                {
                    g.DrawImage(gong, gong_x[draw], gong_y[draw], gong_size, gong_size);
                }
                
                if (hero_x + hero_size_x > field_size_x)
                {
                    hero_x = this.panel2.Width - 10;
                }
                if (hero_y + hero_size_y > field_size_y)
                {
                    hero_y = this.panel2.Height - 10;
                }
                //// 충돌체크 끝 ////

                // 공이 벽에 부딪쳤을때 방향 바뀜 ////
                for (int count = 0; count < level; count++)
                {
                    
                    if (gong_x[count] < 0) //왼쪽벽에 부딪혔을 때
                    {
                        k[count] = rnd_x[count]; //X축 방향 반대로
                        //ball_sound.Play();  // 공의 효과음 발생
                    }
                    if (gong_x[count] > field_size_x - gong_size) //오른쪽벽에 부딪혔을 때
                    {
                        k[count] = -rnd_x[count]; //X축 방향 반대로
                        //ball_sound.Play();  // 공의 효과음 발생
                    }
                    if (gong_y[count] < 0) //위쪽벽에 부딪혔을 때
                    {
                        j[count] = rnd_y[count]; //Y축 방향 반대로
                        //ball_sound.Play();  // 공의 효과음 발생
                    }
                    if (gong_y[count] > field_size_y - gong_size) //아래쪽 벽에 부딪혔을 때
                    {
                        j[count] = -rnd_y[count]; //Y축 방향 반대로
                        //ball_sound.Play();  // 공의 효과음 발생
                    }

                    //주인공과 공의 충돌체크
                    if ((gong_x[count] <= hero_x && gong_x[count] + (gong_size - 8) >= hero_x) || (gong_x[count] <= hero_x + (hero_size_x - 8) && gong_x[count] >= hero_x))
                    {
                        if ((gong_y[count] <= hero_y && gong_y[count] + (gong_size - 9) >= hero_y) || (gong_y[count] <= hero_y + (hero_size_y - 7) && gong_y[count] >= hero_y))
                        {
                            i = 2; //게임 끝!!
                        }
                    }


                    gong_x[count] = gong_x[count] + k[count];
                    gong_y[count] = gong_y[count] + j[count];

                }
                //주인공,벽,공 충돌 배열 끝//
                
                //공끼리 충돌체크 - 부딪히면 반대각으로 움직인다.
                //공1이 왼쪽 공2가 오른쪽에서 부딪힐 때
                for (int count1 = 0; count1 < level; count1++)
                {
                    for (int count2 = count1 + 1; count2 < level; count2++)
                    {
                        //X축 충돌
                        //공2가 오른쪽 공1이 왼쪽에서 부딪힐때.
                        if (gong_x[count1] <= gong_x[count2] && gong_x[count1] + gong_size + 2 >= gong_x[count2])
                        {
                            //X축 좌표만 비교하면 실질적인 충돌을 알수 없기 때문에 Y축 좌표도 비교해야 한다.
                            if (gong_y[count1] <= gong_y[count2] && gong_y[count1] + gong_size >= gong_y[count2] || gong_y[count2] <= gong_y[count1] && gong_y[count2] + gong_size >= gong_y[count1])
                            {
                                //부딪혔다면 X축 진행방향만 이전과 반대로 바꾼다.
                                k[count1] = -rnd_x[count1];
                                k[count2] = rnd_x[count2];
                                //ball_sound.Play();  // 공의 효과음 발생
                            }
                        }

                        //공2가 왼쪽 공1이 오른쪽에서 부딪힐때
                        if (gong_x[count1] >= gong_x[count2] && gong_x[count1] <= gong_x[count2] + gong_size + 2)
                        {
                            //X축 좌표만 비교하면 실질적인 충돌을 알수 없기 때문에 Y축 좌표도 비교해야 한다.
                            if (gong_y[count1] <= gong_y[count2] && gong_y[count1] + gong_size >= gong_y[count2] || gong_y[count2] <= gong_y[count1] && gong_y[count2] + gong_size >= gong_y[count1])
                            {
                                //부딪혔다면 X축 진행방향만 이전과 반대로 바꾼다.
                                k[count1] = rnd_x[count1];
                                k[count2] = -rnd_x[count2];
                                //ball_sound.Play();  // 공의 효과음 발생
                            }
                        }
                        //X축 충돌 끝

                        //y축 충돌
                        //공1이 위쪽 공2가 아래쪽에서 부딪힐 때.
                        if (gong_y[count1] <= gong_y[count2] && gong_y[count1] + gong_size - 2 >= gong_y[count2])
                        {
                            //y축 좌표만 비교하면 실질적인 충돌을 알수 없기 때문에 X축 좌표도 비교해야 한다.
                            if (gong_x[count1] <= gong_x[count2] && gong_x[count1] + gong_size >= gong_x[count2] || gong_x[count2] <= gong_x[count1] && gong_x[count2] + gong_size >= gong_x[count1])
                            {
                                //부딪혔다면 Y축 진행방향만 이전과 반대로 바꾼다.
                                j[count1] = -rnd_y[count1];
                                j[count2] = rnd_y[count2];
                                //ball_sound.Play();  // 공의 효과음 발생
                            }
                        }
                        //공1이 아래쪽 공2가 위쪽에서 부딪힐 때.
                        if (gong_y[count1] >= gong_y[count2] && gong_y[count1] <= gong_y[count2] + gong_size - 2)
                        {
                            //y축 좌표만 비교하면 실질적인 충돌을 알수 없기 때문에 X축 좌표도 비교해야 한다.
                            if (gong_x[count1] <= gong_x[count2] && gong_x[count1] + gong_size >= gong_x[count2] || gong_x[count2] <= gong_x[count1] && gong_x[count2] + gong_size >= gong_x[count1])
                            {
                                //부딪혔다면 Y축 진행방향만 이전과 반대로 바꾼다.
                                j[count1] = rnd_y[count1];
                                j[count2] = -rnd_y[count2];
                                //ball_sound.Play();  // 공의 효과음 발생
                            }
                        }
                    }
                }
            }
            else
            {
                Cursor.Show();
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!!!\r\n" + "당신의 점수는 " + score + "점 입니다");   // 게임 종료 메시지박스 표시

                init();     // 게임 초기화
            }
        }
            

        //// 마우스의 위치를 받아 온다 ////
        public void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            hero_x = e.X;
            hero_y = e.Y;
        }

        public void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //scoretable st = new scoretable();   // 순위표를 보이기 위해 ScoreTable 클래스를 선언
        }
    }
}