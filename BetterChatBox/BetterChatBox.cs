using BetterChatBox.Chat;
using BetterChatBox.Config;
using BetterChatBox.Util;
using Dalamud.Game.Command;
using Dalamud.Plugin;

namespace BetterChatBox {
    public class BetterChatBox : IDalamudPlugin {
        public string Name => Constants.PLUGIN_NAME;
        
        public DalamudPluginInterface pluginInterface { get; }
        
        public BCBConfig config { get; }
        
        public ChatHandler chatHandler { get; }

        public BetterChatBox(DalamudPluginInterface pluginInterface) {
            pluginInterface.Create<Services>();
            this.pluginInterface = pluginInterface;

            config = (BCBConfig) pluginInterface.GetPluginConfig() ?? new BCBConfig();
            config.init(this);
            //TODO: Config UI
            
            //TODO: Localization

            Services.Commands.AddHandler(Constants.PLUGIN_COMMAND, new CommandInfo(handlePluginCommand) {
                HelpMessage = ""
            });

            chatHandler = new ChatHandler(this);
        }

        private void handlePluginCommand(string command, string args) {
            //TODO: Commands
        }
        
        public void Dispose() {
            Services.Commands.RemoveHandler(Constants.PLUGIN_COMMAND);
            chatHandler.Dispose();
        }
    }
}