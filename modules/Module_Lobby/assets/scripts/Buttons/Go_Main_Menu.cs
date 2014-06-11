function Module_Lobby::Go_Main_Menu(%this,%GuiButtonCtrl)
{

if (isObject(Dots_Net_Crits.GameConnection_Client_Connection))
{

Dots_Net_Crits.GameConnection_Client_Connection.delete("Leaving lobby, disconnecting from server.");

}

%this.Scene_Unload();

schedule(0,0,"Module_Gui_Main_Menu::Scene_Load",Module_Gui_Main_Menu);

}
