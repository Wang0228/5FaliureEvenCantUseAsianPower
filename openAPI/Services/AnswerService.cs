using Azure.AI.OpenAI;
using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using openAPI.Interfaces;
using openAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using openAPI.Models;
using Microsoft.Extensions.Options;
using NuGet.ContentModel;
using Microsoft.CodeAnalysis;
using System.Text;

namespace openAPI.Services
{
    public class AnswerService : IChatInterface
    {
        private readonly Hkcontext _hkcontext;
        public AnswerService(Hkcontext hkcontext)
        {
            _hkcontext = hkcontext;
        }
        public List<float> Embedding(string q)
        {
            OpenAIClient client = new(new Uri("https://hacker6.openai.azure.com/"), new AzureKeyCredential("50520d3c1ceb4e79aefe93a6550b9eba"));
            var options = new EmbeddingsOptions(q);
            List<float> client_embedding = client.GetEmbeddings("embedding", options).Value.Data[0].Embedding.ToList();
            return client_embedding;
        }
        public string TurboChat(TurboModel msg)
        {
            OpenAIClient client = new OpenAIClient(new Uri("https://hacker6.openai.azure.com/"), new AzureKeyCredential("50520d3c1ceb4e79aefe93a6550b9eba"));

            List<Qahistory> qahistory = _hkcontext.Qahistories.Where(x => x.ChatId == msg.ChatId).OrderByDescending(y => y.QahistoryId).Take(3).Reverse().ToList();
            IList<ChatMessage> messages = new List<ChatMessage>();

            var options = new ChatCompletionsOptions()
            {
                Messages = { new ChatMessage(ChatRole.System, @"你是藍星金流的客服人員") ,
                                    new ChatMessage(ChatRole.Assistant, $"你是一個客服人員,問題不知道或不相關請回答\"無相關資料,請在營業時間聯絡客服人員\",你只能參照「」內的內容回答問題「{ msg.Sim_Anser}」.只根據「」內的內容回答下面問題不要添加任何其他資訊:"),},
                Temperature = (float)0.7,
                MaxTokens = 350,
                NucleusSamplingFactor = (float)0.95,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
            };
                foreach (var content in qahistory)
                {
                    options.Messages.Add(new ChatMessage(ChatRole.User, content.QahistoryQ));
                    options.Messages.Add(new ChatMessage(ChatRole.Assistant, content.QahistoryA));
                };
            options.Messages.Add(new ChatMessage(ChatRole.User, msg.Question));
            Response<ChatCompletions> responseWithoutStream = client.GetChatCompletionsAsync("gpt-35-turbo", options).GetAwaiter().GetResult();//azure的模型部屬名稱

            string completions = responseWithoutStream.Value.Choices[0].Message.Content.ToString();

            return completions;
        }
        public string OtherChat(TurboModel msg)
        {
            OpenAIClient client = new OpenAIClient(new Uri("https://hacker6.openai.azure.com/"), new AzureKeyCredential("50520d3c1ceb4e79aefe93a6550b9eba"));

            List<Qahistory> qahistory = _hkcontext.Qahistories.Where(x => x.ChatId == msg.ChatId).OrderByDescending(y => y.QahistoryId).Take(3).Reverse().ToList();

            List<string> promptBuilder = new List<string>();

            string prompt = "";
            prompt += $"    你是一個客服人員,問題不知道或不相關請回答\"無相關資料,請在營業時間聯絡客服人員\",你只能參照「」內的內容回答問題「{msg.Sim_Anser}」.只根據「」內的內容回答下面問題不要添加任何其他資訊:";



            foreach (var content in qahistory)
            {
                //promptBuilder.Append($"User: {content.QahistoryQ}");
                //promptBuilder.Append($"Assistant: {content.QahistoryA}");
            }

            prompt += msg.Question;


            CompletionsOptions options = new CompletionsOptions()
            {
                MaxTokens = 1000,
                Temperature = (float)0.7,
                Prompts = {$"{prompt}"},
            };

            Response<Completions> response = client.GetCompletionsAsync("text-ada-001",  options).GetAwaiter().GetResult();

            string completions = response.Value.Choices[0].Text.ToString();

            return completions;
        }
    }
}
