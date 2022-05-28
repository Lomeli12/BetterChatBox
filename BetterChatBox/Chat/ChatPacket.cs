using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;

namespace BetterChatBox.Chat; 

public struct ChatPacket {
    public XivChatType chatType;
    public uint senderID;
    public SeString sender;
    public SeString msg;
}