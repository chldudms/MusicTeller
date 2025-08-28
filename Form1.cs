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
        private string GenerateLyrics(string username, string goal, string genre, string mood, string energy)
        {
            // 이 부분에 실제 AI API 호출 로직 들어가야 함
            // 지금은 예시로 단순 문자열 반환
            return $"[AI Generated Lyrics]\n사용자: {username}\n목표: {goal}\n장르: {genre}\n무드: {mood}\n에너지: {energy}\n\n🎵 가사 예시: 라라라라...";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string goal = this.goal.Text;
            string genre = this.genre.SelectedItem.ToString();
            string mood = this.mood.SelectedItem.ToString();    
            string energyLevel = this.energyLevel.SelectedItem.ToString();
            string username = this.username.Text;

            // AI 가사 생성
            string lyrics = GenerateLyrics(username, goal, genre, mood, energyLevel);

            // tbResult 텍스트박스에 출력
            Result.Text = lyrics;
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
