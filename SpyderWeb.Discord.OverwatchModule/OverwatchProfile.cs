using AutoMapper;
using OverwatchAPI;

namespace SpyderWeb.Discord.OverwatchModule
{
    public class OverwatchProfile : Profile
    {
        public OverwatchProfile()
        {
            CreateMap<OverwatchCore.Data.Player, OverwatchPlayerModel>()
                .ForMember(d => d.Endorsements, s => s.Ignore())
                .ForMember(d => d.Achievements, s => s.Ignore());
            
            CreateMap<OverwatchCore.Data.Stat, OverwatchPlayerModel.Stat>();

            CreateMap<OverwatchCore.Data.StatValue, OverwatchPlayerModel.StatValue>();

            CreateMap<OverwatchCore.Data.Alias, OverwatchPlayerModel.Alias>();
        }
    }
}
