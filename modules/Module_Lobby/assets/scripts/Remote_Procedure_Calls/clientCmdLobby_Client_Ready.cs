function clientCmdLobby_Client_Ready(%GameConnection_Handle)
{

for (%x=0;%x<Module_Lobby.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Module_Lobby.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Handle)
{

%ScriptObject_Client.Bool_Ready=true;

return;

}

}

}
