function Module_Lobby::Lobby_Client_Ready(%this,%GameConnection_Client_Sender)
{

for (%x=0;%x<Module_Lobby.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Module_Lobby.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)
{

%ScriptObject_Client.Bool_Ready=true;

%this.Populate_Connected_Clients_List();

return;

}

}

}
