function serverCmdLobby_Client_Ready(%Client)
{

echo(%Client SPC "is ready in the lobby.");

//Go through list of connected clients and send them the status.
for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Client=ClientGroup.getObject(%x);

if (%GameConnection_Client.Connector_Type$="Client")
{

commandToClient(%GameConnection_Client,'Lobby_Client_Ready',%Client);

}

}

}
