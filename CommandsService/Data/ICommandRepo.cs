using System.Collections.Generic;
using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepo
    {
        bool saveChanges();

        // Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void createPlatform(Platform plat);
        bool PlatformExists(int platformId);

        // Commands
        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
    }   
}