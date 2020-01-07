namespace MiniGameHeaven
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RankBtn = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.Arrow2 = new System.Windows.Forms.PictureBox();
            this.Arrow1 = new System.Windows.Forms.PictureBox();
            this.BallBtn = new System.Windows.Forms.PictureBox();
            this.PackManBtn = new System.Windows.Forms.PictureBox();
            this.PackManBtn1 = new System.Windows.Forms.PictureBox();
            this.BallIBtn1 = new System.Windows.Forms.PictureBox();
            this.RankPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RankLa = new System.Windows.Forms.Label();
            this.BackToFirst = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackManBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackManBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallIBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.RankBtn);
            this.MainPanel.Controls.Add(this.Start);
            this.MainPanel.Location = new System.Drawing.Point(12, 226);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(598, 395);
            this.MainPanel.TabIndex = 1;
            // 
            // RankBtn
            // 
            this.RankBtn.AutoSize = true;
            this.RankBtn.Font = new System.Drawing.Font("굴림", 40F);
            this.RankBtn.Location = new System.Drawing.Point(214, 284);
            this.RankBtn.Name = "RankBtn";
            this.RankBtn.Size = new System.Drawing.Size(185, 67);
            this.RankBtn.TabIndex = 1;
            this.RankBtn.Text = "Rank";
            this.RankBtn.Click += new System.EventHandler(this.RankBtn_Click);
            this.RankBtn.MouseEnter += new System.EventHandler(this.Lank_MouseEnter);
            this.RankBtn.MouseLeave += new System.EventHandler(this.Lank_MouseLeave);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("굴림", 40F);
            this.Start.Location = new System.Drawing.Point(196, 217);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(173, 67);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.Transparent;
            this.NamePanel.Controls.Add(this.OK);
            this.NamePanel.Controls.Add(this.NameBox);
            this.NamePanel.Controls.Add(this.pictureBox1);
            this.NamePanel.Location = new System.Drawing.Point(12, 226);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(598, 395);
            this.NamePanel.TabIndex = 2;
            this.NamePanel.Visible = false;
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Font = new System.Drawing.Font("굴림", 30F);
            this.OK.Location = new System.Drawing.Point(320, 135);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(109, 50);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK!";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("굴림", 35F);
            this.NameBox.Location = new System.Drawing.Point(218, 115);
            this.NameBox.MaxLength = 3;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(101, 67);
            this.NameBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniGameHeaven.Properties.Resources.nameBox1;
            this.pictureBox1.Location = new System.Drawing.Point(218, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.Transparent;
            this.selectPanel.Controls.Add(this.Arrow2);
            this.selectPanel.Controls.Add(this.Arrow1);
            this.selectPanel.Controls.Add(this.PackManBtn);
            this.selectPanel.Controls.Add(this.PackManBtn1);
            this.selectPanel.Controls.Add(this.BallIBtn1);
            this.selectPanel.Controls.Add(this.BallBtn);
            this.selectPanel.Location = new System.Drawing.Point(12, 226);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(598, 395);
            this.selectPanel.TabIndex = 3;
            this.selectPanel.Visible = false;
            // 
            // Arrow2
            // 
            this.Arrow2.Image = global::MiniGameHeaven.Properties.Resources.Arrow;
            this.Arrow2.Location = new System.Drawing.Point(378, 131);
            this.Arrow2.Name = "Arrow2";
            this.Arrow2.Size = new System.Drawing.Size(51, 51);
            this.Arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arrow2.TabIndex = 6;
            this.Arrow2.TabStop = false;
            this.Arrow2.Visible = false;
            // 
            // Arrow1
            // 
            this.Arrow1.Image = global::MiniGameHeaven.Properties.Resources.Arrow;
            this.Arrow1.Location = new System.Drawing.Point(180, 131);
            this.Arrow1.Name = "Arrow1";
            this.Arrow1.Size = new System.Drawing.Size(51, 51);
            this.Arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arrow1.TabIndex = 5;
            this.Arrow1.TabStop = false;
            this.Arrow1.Visible = false;
            // 
            // BallBtn
            // 
            this.BallBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BallBtn.Image = global::MiniGameHeaven.Properties.Resources.ballIcon;
            this.BallBtn.Location = new System.Drawing.Point(344, 17);
            this.BallBtn.Name = "BallBtn";
            this.BallBtn.Size = new System.Drawing.Size(122, 112);
            this.BallBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallBtn.TabIndex = 2;
            this.BallBtn.TabStop = false;
            this.BallBtn.Click += new System.EventHandler(this.BallBtn_Click);
            this.BallBtn.MouseEnter += new System.EventHandler(this.BallIBtn1_MouseEnter);
            this.BallBtn.MouseLeave += new System.EventHandler(this.BallIBtn1_MouseLeave);
            // 
            // PackManBtn
            // 
            this.PackManBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PackManBtn.Image = global::MiniGameHeaven.Properties.Resources.PackManIcon;
            this.PackManBtn.Location = new System.Drawing.Point(143, 17);
            this.PackManBtn.Name = "PackManBtn";
            this.PackManBtn.Size = new System.Drawing.Size(122, 112);
            this.PackManBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PackManBtn.TabIndex = 1;
            this.PackManBtn.TabStop = false;
            this.PackManBtn.Click += new System.EventHandler(this.PackManBtn_Click);
            this.PackManBtn.MouseEnter += new System.EventHandler(this.PackManBtn_MouseEnter);
            this.PackManBtn.MouseLeave += new System.EventHandler(this.PackManBtn_MouseLeave);
            // 
            // PackManBtn1
            // 
            this.PackManBtn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PackManBtn1.Image = global::MiniGameHeaven.Properties.Resources.PackManIcon1;
            this.PackManBtn1.Location = new System.Drawing.Point(143, 17);
            this.PackManBtn1.Name = "PackManBtn1";
            this.PackManBtn1.Size = new System.Drawing.Size(122, 112);
            this.PackManBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PackManBtn1.TabIndex = 3;
            this.PackManBtn1.TabStop = false;
            this.PackManBtn1.Click += new System.EventHandler(this.PackManBtn_Click);
            this.PackManBtn1.MouseEnter += new System.EventHandler(this.PackManBtn_MouseEnter);
            this.PackManBtn1.MouseLeave += new System.EventHandler(this.PackManBtn_MouseLeave);
            // 
            // BallIBtn1
            // 
            this.BallIBtn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BallIBtn1.Image = global::MiniGameHeaven.Properties.Resources.ballIcon1;
            this.BallIBtn1.Location = new System.Drawing.Point(344, 17);
            this.BallIBtn1.Name = "BallIBtn1";
            this.BallIBtn1.Size = new System.Drawing.Size(122, 112);
            this.BallIBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallIBtn1.TabIndex = 4;
            this.BallIBtn1.TabStop = false;
            this.BallIBtn1.Click += new System.EventHandler(this.BallBtn_Click);
            this.BallIBtn1.MouseEnter += new System.EventHandler(this.BallIBtn1_MouseEnter);
            this.BallIBtn1.MouseLeave += new System.EventHandler(this.BallIBtn1_MouseLeave);
            // 
            // RankPanel
            // 
            this.RankPanel.BackColor = System.Drawing.Color.Transparent;
            this.RankPanel.Location = new System.Drawing.Point(12, 12);
            this.RankPanel.Name = "RankPanel";
            this.RankPanel.Size = new System.Drawing.Size(598, 609);
            this.RankPanel.TabIndex = 4;
            this.RankPanel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniGameHeaven.Properties.Resources.title_final;
            this.pictureBox2.Location = new System.Drawing.Point(9, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // RankLa
            // 
            this.RankLa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RankLa.AutoSize = true;
            this.RankLa.Font = new System.Drawing.Font("굴림", 30F);
            this.RankLa.Location = new System.Drawing.Point(209, 3);
            this.RankLa.Name = "RankLa";
            this.RankLa.Size = new System.Drawing.Size(154, 50);
            this.RankLa.TabIndex = 0;
            this.RankLa.Text = "RANK";
            // 
            // BackToFirst
            // 
            this.BackToFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToFirst.AutoSize = true;
            this.BackToFirst.BackColor = System.Drawing.Color.Transparent;
            this.BackToFirst.Font = new System.Drawing.Font("굴림", 20F);
            this.BackToFirst.Location = new System.Drawing.Point(0, 3);
            this.BackToFirst.Name = "BackToFirst";
            this.BackToFirst.Size = new System.Drawing.Size(93, 34);
            this.BackToFirst.TabIndex = 1;
            this.BackToFirst.Text = "Back";
            this.BackToFirst.Visible = false;
            this.BackToFirst.Click += new System.EventHandler(this.BackToFirst_Click);
            this.BackToFirst.MouseEnter += new System.EventHandler(this.BackToFirst_MouseEnter);
            this.BackToFirst.MouseLeave += new System.EventHandler(this.BackToFirst_MouseLeave);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Transparent;
            this.titlePanel.Controls.Add(this.pictureBox2);
            this.titlePanel.Location = new System.Drawing.Point(12, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(598, 208);
            this.titlePanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniGameHeaven.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 633);
            this.Controls.Add(this.BackToFirst);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.selectPanel);
            this.Controls.Add(this.RankPanel);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.selectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackManBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackManBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallIBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label RankBtn;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OK;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.PictureBox BallBtn;
        private System.Windows.Forms.PictureBox PackManBtn;
        private System.Windows.Forms.PictureBox PackManBtn1;
        private System.Windows.Forms.PictureBox BallIBtn1;
        private System.Windows.Forms.PictureBox Arrow1;
        private System.Windows.Forms.PictureBox Arrow2;
        private System.Windows.Forms.Panel RankPanel;
        private System.Windows.Forms.Label RankLa;
        private System.Windows.Forms.Label BackToFirst;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel titlePanel;
    }
}

