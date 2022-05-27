using System;
using Dalamud.Configuration;

namespace BetterChatBox.Config; 

[Serializable]
public class BCBConfig : IPluginConfiguration {
    [NonSerialized] private BetterChatBox plugin;
    
    public int Version { get; set; } = 0;

    public bool openChatOnStartup = true;
    
    //TODO: Save tab settings

    public void init(BetterChatBox plugin) {
        this.plugin = plugin;
    }

    public void save() {
        plugin.pluginInterface.SavePluginConfig(this);
    }
}