using LocalGym.Entities;

namespace LocalGym.Services
{
    public interface IGymInfoRepository
    {
        Task<IEnumerable<Member>> GetMembersAsync();
        Task<Member?> GetMemberAsync(int Id);
        Task<IEnumerable<Trainer>> GetTrainersAsync();
        Task<Trainer?> GetTrainerAsync(int Id);
        Task<IEnumerable<Session>> GetSessionsForTrainerAsync(int Id);
        Task<IEnumerable<Session>> GetSessionsForMemberAsync(int Id);

        Task AddTrainerAsync(Trainer trainer);
        Task<bool> SaveChangesAsync();
    }
}
