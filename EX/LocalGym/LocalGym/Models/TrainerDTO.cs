using LocalGym.Entities;

namespace LocalGym.Models
{
    public class TrainerDTO
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public double FeePer30Minutes { get; set; }
        public DateOnly HireDate { get; set; }
        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
