function Module_Gui_Main_Menu::Single_Player(%this,%GuiButtonCtrl)
{

if (Dots_Net_Crits.Bool_Hosting_Server||Dots_Net_Crits.Bool_Hosting_Master_Server)
{

return;

}

if (isObject(Dots_Net_Crits.GameConnection_Master_Server_Query))
{

Dots_Net_Crits.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Dots_Net_Crits.GameConnection_Client_Connection))
{

Dots_Net_Crits.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

ClientGroup.deleteObjects();//Clear clients.

Dots_Net_Crits.Bool_Local_Connection=true;

Dots_Net_Crits.Bool_Hosting_Server=true;

Module_Server.Server_Load();

Dots_Net_Crits.GameConnection_Client_Connection=new GameConnection();

Dots_Net_Crits.GameConnection_Client_Connection.setConnectArgs
(

$pref::Dots_Net_Crits::Player_Name,//Connector Name

"Client"//Connector Type

);

Dots_Net_Crits.GameConnection_Client_Connection.connectLocal();

}
