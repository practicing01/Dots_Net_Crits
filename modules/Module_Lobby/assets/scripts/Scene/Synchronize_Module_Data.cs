function Module_Lobby::Synchronize_Module_Data(%this,%GameConnection_Client_Sender,%Bool_Lobby_Status)
{

for (%x=0;%x<Module_Lobby.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Module_Lobby.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)
{

%ScriptObject_Client.Bool_Ready=%Bool_Lobby_Status;

%this.Populate_Connected_Clients_List();

return;

}

}

}
