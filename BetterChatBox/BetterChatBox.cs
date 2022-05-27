using BetterChatBox.Util;
using Dalamud.Game.Command;
using Dalamud.Plugin;

namespace BetterChatBox {
    public class BetterChatBox : IDalamudPlugin {
        public string Name => Constants.PLUGIN_NAME;
        
        public DalamudPluginInterface pluginInterface { get; private set; }

        public BetterChatBox(DalamudPluginInterface pluginInterface) {
            pluginInterface.Create<Services>();
            this.pluginInterface = pluginInterface;
            
            //TODO: Configs
            //TODO: Localization

            Services.Commands.AddHandler(Constants.PLUGIN_COMMAND, new CommandInfo(handlePluginCommand) {
                HelpMessage = ""
            });
        }

        private void handlePluginCommand(string command, string args) {
            //TODO: Commands
        }
        
        public void Dispose() {
            Services.Commands.RemoveHandler(Constants.PLUGIN_COMMAND);
        }
    }
}