using System;
using BetterChatBox.Chat.UI;
using BetterChatBox.Util;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;

namespace BetterChatBox.Chat;

public class ChatHandler : IDisposable {
    public BetterChatBox plugin { get; private set; }
    
    public BaseChatBox chatBox { get; private set; }

    public ChatHandler(BetterChatBox plugin) {
        this.plugin = plugin;
        chatBox = new BaseChatBox(plugin);

        Services.Chat.CheckMessageHandled += handleChat;
    }

    private void handleChat(XivChatType chatType, uint senderID, ref SeString sender, ref SeString msg,
        ref bool isHandled) {
        //TODO: Process chat based on current tab
    }

    public void Dispose() {
        chatBox.Dispose();
        Services.Chat.CheckMessageHandled -= handleChat;
    }
}