using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalGym.Entities
{
    public class Trainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrainerId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public double FeePer30Minutes { get; set; }
        public DateOnly HireDate { get; set; }

        //public ICollection<Trainer> trainers { get; set; } = new List<Trainer>();
        public ICollection<Session> Sessions { get; set; } = new List<Session>();

    }
}
