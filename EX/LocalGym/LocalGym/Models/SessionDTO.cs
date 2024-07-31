namespace LocalGym.Models
{
    public class SessionDTO
    {
        public int SessionId { get; set; }
        public int CustomerId { get; set; }
        public int TrainerId { get; set; }
        public DateOnly SessionDate { get; set; }
        public TimeOnly Duration { get; set; }
    }
}
