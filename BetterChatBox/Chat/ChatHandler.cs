using System;
using BetterChatBox.Chat.UI;
using BetterChatBox.Util;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;

namespace BetterChatBox.Chat;

public class ChatHandler : IDisposable {
    public BetterChatBox plugin { get; }
    
    public BaseChatBox chatBox { get; }

    public ChatHandler(BetterChatBox plugin) {
        this.plugin = plugin;
        chatBox = new BaseChatBox(plugin);

        Services.Chat.ChatMessageHandled += handleChat;
    }

    private void handleChat(XivChatType chatType, uint senderID, SeString sender, SeString msg) {
        chatBox.handleChat(new ChatPacket {
            chatType = chatType,
            senderID = senderID,
            sender = sender,
            msg = msg
        });
    }

    public void toggleChatBox(bool show) {
        chatBox.drawChatBox = show;
    }

    public void toggleChatBox() =>
        toggleChatBox(true);

    public void Dispose() {
        chatBox.Dispose();
        Services.Chat.ChatMessageHandled -= handleChat;
    }
}