using LocalGym.DbContexts;
using LocalGym.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocalGym.Services
{
    public class GymInfoRepository : IGymInfoRepository
    {
        private readonly GymInfoContext _context;

        public GymInfoRepository(GymInfoContext context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Member?> GetMemberAsync(int Id)
        {
            //throw new NotImplementedException();
            return await _context.Members.Where(c => c.Id == Id).FirstOrDefaultAsync();
           
        }

        public async Task<IEnumerable<Member>> GetMembersAsync()
        {
            //throw new NotImplementedException();
            return await _context.Members.ToListAsync();
        }

        public async Task<IEnumerable<Session>> GetSessionsForMemberAsync(int Id)
        {
            //throw new NotImplementedException();
            return await _context.Sessions.Where(c => c.CustomerId == Id).ToListAsync();

        }

        public async Task<IEnumerable<Session>> GetSessionsForTrainerAsync(int Id)
        {
            //throw new NotImplementedException();
            return await _context.Sessions.Where(c=>c.TrainerId == Id).ToListAsync();

        }

        public async Task<Trainer?> GetTrainerAsync(int Id)
        {
            //throw new NotImplementedException();
            return await _context.Trainers.Where(c => c.TrainerId == Id).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<Trainer>> GetTrainersAsync()
        {
            //throw new NotImplementedException();
            return await _context.Trainers.ToListAsync();

        }

        public async Task AddTrainerAsync(Trainer trainer)
        {
            _context.Add(trainer);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()>=0);
        }
    }
}
