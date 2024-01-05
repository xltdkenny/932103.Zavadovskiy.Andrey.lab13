using System.ComponentModel.DataAnnotations;

namespace lab13.Models
{
    public class QuizAnswer
    {
        [Required]
        public int answer { get; set; }

        public QuizAnswer(int answer)
        {
            this.answer = answer;
        }
    }
}