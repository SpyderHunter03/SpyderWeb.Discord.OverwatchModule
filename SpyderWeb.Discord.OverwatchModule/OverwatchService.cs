using System;
using System.Threading.Tasks;
using AutoMapper;
using OverwatchAPI;

namespace SpyderWeb.Discord.OverwatchModule
{
    public class OverwatchService : IOverwatchService
    {
        private readonly IMapper _mapper;

        public OverwatchService()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new OverwatchProfile());
            });

            _mapper = mappingConfig.CreateMapper();
        }

        public async Task<OverwatchPlayerModel> GetOverwatchPlayerModel(string name)
        {
            using (var owClient = new OverwatchClient())
            {
                Player player = await owClient.GetPlayerAsync(name);
                return _mapper.Map<OverwatchPlayerModel>(player);
            }
        }
    }
}
