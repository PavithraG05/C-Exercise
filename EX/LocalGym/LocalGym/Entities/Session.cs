using System.ComponentModel.DataAnnotations.Schema;

namespace LocalGym.Entities
{
    public class Session
    {
        public int SessionId { get; set; }

        [ForeignKey("CustomerId")]
        public Member? member { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("TrainerId")]
        public Trainer? Trainer { get; set; }
        public int TrainerId { get; set; }

        public DateOnly SessionDate {  get; set; }
        public TimeOnly Duration { get; set; }
    }
}
