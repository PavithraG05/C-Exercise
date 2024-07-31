using AutoMapper;

namespace LocalGym.Profiles
{
    public class TrainerProfile:Profile
    {
        public TrainerProfile()
        {
            CreateMap<Entities.Trainer, Models.TrainerDTO>();
            CreateMap<Entities.Trainer, Models.TrainerDTO>().ReverseMap();
            CreateMap<Entities.Trainer, Models.TrainerUpdateDTO>().ReverseMap();

        }
    }
}
