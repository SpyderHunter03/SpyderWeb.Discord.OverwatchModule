using System;
using System.Threading.Tasks;

namespace SpyderWeb.Discord.OverwatchModule
{
    public interface IOverwatchService
    {
        Task<OverwatchPlayerModel> GetOverwatchPlayerModel(string name);
    }
}
