﻿using System.Collections.Generic;

namespace Mock3.ViewModels
{
    public class ExamsListViewModel
    {
        public ExamsListViewModel()
        {
            Exams = new List<ExamViewModel>();
        }
        public List<ExamViewModel> Exams { get; set; }
    }
}