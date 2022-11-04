using KodelabAssessment1122DLL.Dtos;
using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using KodelabAssessment1122DLL.DomainModels;
using System.Text;

namespace KodelabAssessment1122.Services
{
    public class QuizService
    {

        public static async Task<List<QuizFileDto>> GetAll()
        {

            string apiUrl = "https://localhost:44348/api/";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<QuizFileDto>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<QuizFileDto>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }
        }

        public static async Task<List<QuizQuestions>> GetAllQuestions()
        {

            string apiUrl = "https://localhost:44348/api/Question/GetAll";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<QuizQuestions>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<QuizQuestions>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }
        }

        public static async Task<List<QuizAnswers>> GetAllAnswers()
        {

            string apiUrl = "https://localhost:44348/api/Answer/GetAll";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<QuizAnswers>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<QuizAnswers>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }
        }

        public static async Task<List<Quiz>> GetAllQuizes()
        {

            string apiUrl = "https://localhost:44348/api/Quiz/GetAll";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Quiz>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Quiz>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }
        }

        public static async Task<List<CreateUserAnswerDto>> GetAllUserAnswers()
        {

            string apiUrl = "https://localhost:44348/api/Quiz/GetAllUserAnswers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<CreateUserAnswerDto>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<CreateUserAnswerDto>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }
        }

        public static async Task<List<UserAnswerDto>> CreateUserAnswer(CreateUserAnswerDto newAnswer) {

            IEnumerable<CreateUserAnswerDto> Answers = null;

            string apiUrl = "https://localhost:44348/api/Quiz/AnswerQuestion";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var newbarberJson = Newtonsoft.Json.JsonConvert.SerializeObject(newAnswer);
                var payload = new StringContent(newbarberJson, Encoding.UTF8, "application/json");

                HttpResponseMessage result = await client.PostAsync(apiUrl, payload);

                //result.EnsureSuccessStatusCode();

                var apiresponse = new List<UserAnswerDto>();

                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsAsync<List<UserAnswerDto>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }
        }
    }
}
