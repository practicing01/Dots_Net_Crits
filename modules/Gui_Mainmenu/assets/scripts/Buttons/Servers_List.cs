function Module_Gui_Main_Menu::Servers_List(%this,%GuiButtonCtrl)
{

if (Dots_Net_Crits.Bool_Hosting_Server||Dots_Net_Crits.Bool_Hosting_Master_Server)
{

return;

}

if (!isObject(Dots_Net_Crits.GameConnection_Master_Server_Query))
{

setNetPort(9003);//OVER NINE THOUSAND

Dots_Net_Crits.GameConnection_Master_Server_Query=new GameConnection();

Dots_Net_Crits.GameConnection_Master_Server_Query.setConnectArgs
(

$pref::Dots_Net_Crits::Player_Name,//Connector Name

"Client"//Connector Type

);

if (Dots_Net_Crits.Bool_Local_Connection)
{

echo("Can't query master server, this is a local connection.");

}
else
{

echo("Connecting to the master server for query.");

Dots_Net_Crits.GameConnection_Master_Server_Query.connect($pref::Dots_Net_Crits::Master_IP);

}

}

}
