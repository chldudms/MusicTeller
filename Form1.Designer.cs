namespace MusicTeller
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.energyLevel = new System.Windows.Forms.ComboBox();
            this.genre = new System.Windows.Forms.ComboBox();
            this.mood = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.TextBox();
            this.goal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.createMusic = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테마바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.언어선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicTeller정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.energyLevel);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.mood);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.goal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 정보 입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // energyLevel
            // 
            this.energyLevel.FormattingEnabled = true;
            this.energyLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.energyLevel.Location = new System.Drawing.Point(29, 181);
            this.energyLevel.Name = "energyLevel";
            this.energyLevel.Size = new System.Drawing.Size(121, 23);
            this.energyLevel.TabIndex = 11;
            this.energyLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // genre
            // 
            this.genre.FormattingEnabled = true;
            this.genre.Items.AddRange(new object[] {
            "팝송",
            "트로트",
            "힙합",
            "재즈",
            "발라드",
            "댄스",
            "록큰롤"});
            this.genre.Location = new System.Drawing.Point(29, 261);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(121, 23);
            this.genre.TabIndex = 10;
            this.genre.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // mood
            // 
            this.mood.FormattingEnabled = true;
            this.mood.Items.AddRange(new object[] {
            "기쁨",
            "슬픔",
            "짜증",
            "분노",
            "우울",
            "설렘",
            "감동",
            "황당",
            "피곤"});
            this.mood.Location = new System.Drawing.Point(29, 108);
            this.mood.Name = "mood";
            this.mood.Size = new System.Drawing.Size(121, 23);
            this.mood.TabIndex = 9;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(26, 318);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 25);
            this.username.TabIndex = 7;
            // 
            // goal
            // 
            this.goal.Location = new System.Drawing.Point(29, 52);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(100, 25);
            this.goal.TabIndex = 5;
            this.goal.TextChanged += new System.EventHandler(this.goal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "사용자 이름을 입력해주세요";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 230);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(182, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "노래 장르를 선택해주세요";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "에너지 레벨을 선택해주세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "현재 기분을 선택해주세요";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "오늘의 목표 1가지를 적어주세요\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultText);
            this.groupBox2.Location = new System.Drawing.Point(413, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과보기";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(26, 52);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(287, 291);
            this.resultText.TabIndex = 4;
            this.resultText.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // createMusic
            // 
            this.createMusic.Location = new System.Drawing.Point(337, 406);
            this.createMusic.Name = "createMusic";
            this.createMusic.Size = new System.Drawing.Size(113, 32);
            this.createMusic.TabIndex = 2;
            this.createMusic.Text = "노래 생성하기";
            this.createMusic.UseVisualStyleBackColor = true;
            this.createMusic.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyBtn,
            this.저장하기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // historyBtn
            // 
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(224, 26);
            this.historyBtn.Text = "내역 불러오기";
            this.historyBtn.Click += new System.EventHandler(this.이전에ToolStripMenuItem_Click);
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.저장하기ToolStripMenuItem.Text = "현재 내용 저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테마바꾸기ToolStripMenuItem,
            this.언어선택ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 테마바꾸기ToolStripMenuItem
            // 
            this.테마바꾸기ToolStripMenuItem.Name = "테마바꾸기ToolStripMenuItem";
            this.테마바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.테마바꾸기ToolStripMenuItem.Text = "테마 바꾸기";
            // 
            // 언어선택ToolStripMenuItem
            // 
            this.언어선택ToolStripMenuItem.Name = "언어선택ToolStripMenuItem";
            this.언어선택ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.언어선택ToolStripMenuItem.Text = "언어 선택";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicTeller정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // musicTeller정보ToolStripMenuItem
            // 
            this.musicTeller정보ToolStripMenuItem.Name = "musicTeller정보ToolStripMenuItem";
            this.musicTeller정보ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.musicTeller정보ToolStripMenuItem.Text = "musicTeller정보";
            this.musicTeller정보ToolStripMenuItem.Click += new System.EventHandler(this.musicTeller정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createMusic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MusicTeller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox goal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mood;
        private System.Windows.Forms.Button createMusic;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyBtn;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 테마바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 언어선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ComboBox energyLevel;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicTeller정보ToolStripMenuItem;
    }
}

