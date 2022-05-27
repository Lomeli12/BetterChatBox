using System;
using Dalamud.Game.Text;

namespace BetterChatBox.Chat.UI.Modules; 

public interface ITabbedChat : IDisposable {
    string tabName { get; }
    
    bool filteredChat { get; }
    
    XivChatType[] chatTypes { get; }
}