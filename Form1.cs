using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;


namespace MusicTeller
{
    public partial class Form1 : Form
    {

       public string songResult;


        public Form1()
        {
            InitializeComponent();


            resultText.Multiline = true;           // 여러 줄 입력 
            resultText.ScrollBars = ScrollBars.Vertical;  // 길면 스크롤
            resultText.WordWrap = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string goal = this.goal.Text;
            string genre = this.genre.SelectedItem?.ToString() ?? "";
            string mood = this.mood.SelectedItem?.ToString() ?? "";
            string energyLevel = this.energyLevel.SelectedItem?.ToString() ?? "";
            string username = this.username.Text;

            string userInput = $"유저이름:{username}, 오늘의 목표:{goal}, " +
                               $"노래 장르:{genre}, 오늘의 기분:{mood}, " +
                               $"에너지 레벨:{energyLevel}";

            string lyrics = GenerateSong(username, goal, genre, mood, energyLevel);

            songResult = lyrics;

            resultText.Text = lyrics;
        }

        private string GenerateSong(string username, string goal, string genre, string mood, string energy)
        {
            Random rnd = new Random();

            // 1. 기분별 표현
            var moodPhrases = new Dictionary<string, List<string>>()
    {
        {"기쁨", new List<string>{"행복한 오늘 하루", "웃음이 나는 하루", "즐거움 가득한 하루"}},
        {"슬픔", new List<string>{"조금 힘든 하루지만", "슬픔 속에서도 희망을", "마음 다독이는 하루"}},
        {"짜증", new List<string>{"짜증나는 하루지만", "화가 나도 이겨내자", "오늘도 마음 다잡기"}},
        {"분노", new List<string>{"분노를 에너지로 바꿔", "마음을 진정시키고", "열정으로 하루를 채워"}},
        {"우울", new List<string>{"우울한 기분 속에서", "지친 마음을 달래며", "회복이 필요한 하루"}},
        {"설렘", new List<string>{"두근거리는 오늘 하루", "설렘 가득한 순간", "행복 기대하며"}},
        {"감동", new List<string>{"마음이 울리는 하루", "감동 속에서 배우는 하루", "따뜻함 가득"}},
        {"황당", new List<string>{"예상치 못한 하루", "황당하지만 즐겁게", "오늘도 웃으며"}},
        {"피곤", new List<string>{"지친 몸을 이끌며", "피곤하지만 힘내자", "오늘도 달려가는 하루"}}
    };

            string moodLine = moodPhrases.ContainsKey(mood)
                ? moodPhrases[mood][rnd.Next(moodPhrases[mood].Count)]
                : "오늘 하루";

            // 2. 장르별 느낌 단어
            var genreWords = new Dictionary<string, List<string>>()
    {
        {"팝송", new List<string>{"la~ la~", "pop pop~", "doo wop~"}},
        {"트로트", new List<string>{"라라라~", "트롯~ 트롯~", "흥겨운 리듬~"}},
        {"힙합", new List<string>{"yo~ yo~", "check it~", "boom bap~"}},
        {"재즈", new List<string>{"doo-be-doo-be~", "스윙~ 스윙~", "smooth jazz~"}},
        {"발라드", new List<string>{"laaa~ laaa~", "slow melody~", "감성 발라드~"}},
        {"댄스", new List<string>{"dance! dance!", "let's groove~", "shake it~"}},
        {"록큰롤", new List<string>{"rock! rock!", "yeah~ yeah~", "riff riff~"}}
    };

            string genreWord = genreWords.ContainsKey(genre)
                ? genreWords[genre][rnd.Next(genreWords[genre].Count)]
                : "";

            // 3. 에너지 레벨
            string energyLine = "";
            if (energy == "5") energyLine = "오늘은 에너지 폭발! 신나게 시작해보자~";
            else if (energy == "4") energyLine = "조금 더 힘내서 활기차게!~";
            else if (energy == "3") energyLine = "활기차게 시작해볼까~";
            else if (energy == "2") energyLine = "조금 천천히 마음을 느껴봐~";
            else if (energy == "1") energyLine = "오늘은 편하게 쉬어가자~";
            else energyLine = "오늘 하루 힘내자~";

            // 4. 목표
            string goalLine = $"오늘의 목표: {goal}을(를) 이뤄보자~";

            // 5. 이름 포함
            string nameLine = $"{username}이의 특별한 하루~";

            // 6. 노래 제목 생성 (기분 + 장르 조합)
            var titlePhrases = new List<string>()
    {
        $"{moodLine}의 리듬",
        $"{genreWord} 속 하루",
        $"{nameLine}의 이야기",
        $"오늘의 {goal} 송"
    };
            string title = titlePhrases[rnd.Next(titlePhrases.Count)];

            // 7. 조합 (제목 아래 가사)
            string lyrics = title + "\r\n\r\n" +
                            moodLine + ", " + genreWord + "\r\n" +
                            energyLine + "\r\n" +
                            nameLine + "\r\n" +
                            goalLine;
            return lyrics;
        }

        public void LoadHistory(string history)
        {
        
            string goal = this.goal.Text;
            string genre = this.genre.SelectedItem?.ToString() ?? "";
            string mood = this.mood.SelectedItem?.ToString() ?? "";
            string energyLevel = this.energyLevel.SelectedItem?.ToString() ?? "";
            string username = this.username.Text;

            string userInput = $"유저이름:{username}, 오늘의 목표:{goal}, " +
                               $"노래 장르:{genre}, 오늘의 기분:{mood}, " +
                               $"에너지 레벨:{energyLevel}";

            string result = GenerateSong(username, goal, genre, mood, energyLevel);
        }


        private void goal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void 이전에ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History formHistory = Application.OpenForms["History"] as History;
            if (formHistory != null)
            {
                formHistory.Activate();

            }
            else
            {
                formHistory = new History(this);
                formHistory.Show();

            }
        }


            private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                File.AppendAllText(filename, history + Environment.NewLine +
                      "-------------------------" + Environment.NewLine);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한 없음 오류 발생 \n{ex.Message}", "권한 오류");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류 발생 \n{ex.Message}", "알 수 없는 오류");

            }
        }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveHistory(songResult);
        }

        private void musicTeller정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }

        }
    