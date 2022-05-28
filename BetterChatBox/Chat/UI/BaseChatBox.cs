using System;
using System.Collections.Generic;
using System.Numerics;
using BetterChatBox.Chat.UI.Modules;
using ImGuiNET;

namespace BetterChatBox.Chat.UI {
    public class BaseChatBox : IDisposable {
        public BetterChatBox plugin { get; }

        public List<ITabbedChat> tabbedChats = new ();
        public int currentTab = 0;

        public bool drawChatBox;

        public BaseChatBox(BetterChatBox plugin) {
            this.plugin = plugin;
            drawChatBox = plugin.config.openChatOnStartup;

            plugin.pluginInterface.UiBuilder.Draw += draw;
        }

        private void drawBaseChatBox() {
            ImGui.SetNextWindowSize(new Vector2(300, 300), ImGuiCond.FirstUseEver );
            ImGui.Begin("", ref drawChatBox);
            
            //TODO: Draw tabs
            ImGui.BeginTabBar("Chats");
            
            
            ImGui.EndTabBar();
            
            ImGui.End();
        }

        public void handleChat(ChatPacket cptx) {
            if (tabbedChats.Count < 1) return;
            foreach (var tab in tabbedChats)
                tab.handleChat(cptx);
        }

        private void draw() {
            if (drawChatBox) drawBaseChatBox();
        }

        public void Dispose() {
        }
    }
}