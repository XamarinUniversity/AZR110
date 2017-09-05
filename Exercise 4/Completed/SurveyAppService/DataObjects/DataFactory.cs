using System;
using System.Collections.Generic;

namespace SurveyAppService.DataObjects
{
    static class DataFactory
    {
        public static List<SurveyQuestion> Questions
    {
        get
        {
            return new List<SurveyQuestion>
            {
                new SurveyQuestion { Id = Guid.NewGuid().ToString(),
                    Text = "Where should we have lunch?",
                    Answers = "McDonalds|Sushi King|Olive Garden|Outback Steakhouse|KFC" },
                new SurveyQuestion { Id = Guid.NewGuid().ToString(),
                    Text = "PARTY! Which date do you prefer?",
                    Answers = "Monday|Wednesday|Friday" },
                new SurveyQuestion { Id = Guid.NewGuid().ToString(),
                    Text = "Which mobile platform do you like best?",
                    Answers = "Android|iOS|UWP|WPF|HTML|Blackberry" }
            };
        }
    }
}
}