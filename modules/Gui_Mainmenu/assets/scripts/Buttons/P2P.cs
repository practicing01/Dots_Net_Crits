function Module_Gui_Main_Menu::P2P(%this,%GuiButtonCtrl)
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

setNetPort(9003);//OVER NINE THOUSAND

Dots_Net_Crits.GameConnection_Client_Connection=new GameConnection();

Dots_Net_Crits.GameConnection_Client_Connection.setConnectArgs
(

$pref::Dots_Net_Crits::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to P2P server:" SPC $pref::Dots_Net_Crits::P2P_IP);

Dots_Net_Crits.GameConnection_Client_Connection.connect($pref::Dots_Net_Crits::P2P_IP);

}
