using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTeller
{
    public partial class Form1: Form
    {
      private async Task<string> GenerateLyrics(string username, string goal, string genre, string mood, string energy)
{
   // GptApi api = new GptApi();
    string userInput = $"유저이름:{username}, 오늘의 목표: {goal}, " +
        $"노래 장르:{genre}, 오늘의 기분:{mood}, " +
        $"에너지 레벨:{energy}";

   // string result = await api.GetSongAsync(userInput) ?? "AI 응답이 없습니다";

    return userInput;
}

        public Form1()
        {
            InitializeComponent();
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
            string genre = this.genre.SelectedItem.ToString();
            string mood = this.mood.SelectedItem.ToString();    
            string energyLevel = this.energyLevel.SelectedItem.ToString();
            string username = this.username.Text;

            // AI 가사 생성
            string lyrics = await GenerateLyrics(username, goal, genre, mood, energyLevel);

            // tbResult 텍스트박스에 출력
            resultText.Text = lyrics;
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

        }
    }
}
