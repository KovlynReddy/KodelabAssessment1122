using KodelabAssessment1122DLL.Dtos;
using System;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using KodelabAssessment1122DLL.DomainModels;

namespace KodelabAssessment1122DLL.Services
{
    public class QuizService
    {

        //public async Task<List<QuizFileDto>> GetAll() {

        //    string apiUrl = "";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(apiUrl);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);

        //        var apiresponse = new List<QuizFileDto>();

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var data = await response.Content.ReadAsAsync<List<QuizFileDto>>();
        //            //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
        //            apiresponse = data;
        //        }

        //        return apiresponse;
        //    }
        //}

        //public async Task<List<QuizFileDto>> GetAllQuestions()
        //{

        //    string apiUrl = "";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(apiUrl);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);

        //        var apiresponse = new List<QuizFileDto>();

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var data = await response.Content.ReadAync<List<QuizQuestions>>();
        //            //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
        //            apiresponse = data;
        //        }

        //        return apiresponse;
        //    }
        //}

        //public async Task<List<QuizFileDto>> GetAllAnswers()
        //{

        //    string apiUrl = "";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(apiUrl);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);

        //        var apiresponse = new List<QuizFileDto>();

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var data = await response.Content.ReadAsAsync<List<QuizFileDto>>();
        //            //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
        //            apiresponse = data;
        //        }

        //        return apiresponse;
        //    }
        //}

        //public async Task<List<QuizFileDto>> GetAllQuizes()
        //{

        //    string apiUrl = "";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(apiUrl);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);

        //        var apiresponse = new List<QuizFileDto>();

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var data = await response.Content.ReadAsAsync<List<QuizFileDto>>();
        //            //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
        //            apiresponse = data;
        //        }

        //        return apiresponse;
        //    }
        //}

    }
}
