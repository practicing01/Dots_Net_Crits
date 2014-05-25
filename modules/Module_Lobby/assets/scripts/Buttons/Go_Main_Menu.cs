function Gui_Lobby::Go_Main_Menu(%this)
{

if (isObject(Dots_Net_Crits.GameConnection_Client_Connection))
{

Dots_Net_Crits.GameConnection_Client_Connection.delete("Leaving lobby, disconnecting from server.");

}

Module_Lobby.Scene_Unload();

Module_Gui_Main_Menu.Scene_Load();

}
