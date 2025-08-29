using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace MusicTeller
{
    public class OpenAI
    {
        private readonly string apiKey = "AIzaSyAmugm40Zyhmq-scvq0n-uCJJEYhNp2bSk";

        private async Task<string> GenerateLyricsGemini(string userInput)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");


                var payload = new
                {
                    prompt = userInput,
                    max_output_tokens = 500
                };

                var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://api.generativeai.googleapis.com/v1beta2/models/text-bison-001:generate", content);

                string json = await response.Content.ReadAsStringAsync();

                try
                {
                    var obj = JObject.Parse(json);
                    string output = obj["candidates"]?[0]?["output"]?.ToString();
                    return output ?? "응답 없음";
                }
                catch
                {
                    return "JSON 파싱 실패: " + json;
                }
            }
        }

    }
}
