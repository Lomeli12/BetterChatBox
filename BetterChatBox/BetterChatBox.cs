using BetterChatBox.Util;
using Dalamud.Plugin;

namespace BetterChatBox {
    public class BetterChatBox : IDalamudPlugin {
        public string Name => Constants.PLUGIN_NAME;

        public BetterChatBox(DalamudPluginInterface pluginInterface) {
            pluginInterface.Create<Services>();
        }
        
        public void Dispose() {
            
        }
    }
}