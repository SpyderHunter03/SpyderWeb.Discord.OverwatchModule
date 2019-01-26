using AutoMapper;
using OverwatchAPI;

namespace SpyderWeb.Discord.OverwatchModule
{
    public class OverwatchProfile : Profile
    {
        public OverwatchProfile()
        {
            CreateMap<Player, OverwatchPlayerModel>()
                .ForMember(m => m.GamePlatform, x => x.MapFrom(m => m.Platform))
                .ReverseMap();
        }
    }
}
