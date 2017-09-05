using Microsoft.Azure.Mobile.Server;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyAppService.DataObjects
{
    [Table("responses")]
    public class SurveyResponse : EntityData
    {
        public string Name { get; set; }
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }
        [JsonProperty("answer")]
        public int AnswerIndex { get; set; }
    }
}