using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using OverwatchAPI;

[assembly: InternalsVisibleToAttribute("SpyderWeb.Discord.OverwatchModule.Tests")]
namespace SpyderWeb.Discord.OverwatchModule
{
    internal class OverwatchService : IOverwatchService
    {
        private readonly IMapper _mapper;

        internal OverwatchService()
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