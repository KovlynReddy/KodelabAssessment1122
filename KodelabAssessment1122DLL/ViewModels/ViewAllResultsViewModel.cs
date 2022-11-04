using KodelabAssessment1122DLL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodelabAssessment1122DLL.ViewModels
{
    public class ViewAllResultsViewModel
    {
        public List<CreateUserAnswerDto> AllAnswers { get; set; } = new List<CreateUserAnswerDto>();
        public List<UserResultsViewModel> AllResults { get; set; } = new List<UserResultsViewModel>();
    }
}
