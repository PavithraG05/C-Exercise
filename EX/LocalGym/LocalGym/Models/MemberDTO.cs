using LocalGym.Entities;

namespace LocalGym.Models
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   
        public DateOnly JoinDate { get; set; }

        public ICollection<Session> Sessions { get; set; } = new List<Session>();


    }
}
