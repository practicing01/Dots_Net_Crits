//client
function GameConnection::onConnectionAccepted(%this)
{

echo("GameConnection onConnectionAccepted. Handle:" SPC %this);

if (isObject(Dots_Net_Crits.GameConnection_Master_Server_Query)&&!Dots_Net_Crits.Bool_Local_Connection)//This is a query connection.
{

echo("Querying master server.");

if (isObject(Dots_Net_Crits.Simset_Server_List))
{

Dots_Net_Crits.Simset_Server_List.deleteObjects();

Gui_List_Servers.clearItems();

}

commandToServer('Master_Server_Query_Request');

}
else if (isObject(Dots_Net_Crits.GameConnection_Client_Connection)&&Dots_Net_Crits.Bool_Is_Client)//This is a client to server connection.
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Lobby.Scene_Load();

}

}
