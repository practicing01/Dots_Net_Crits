function clientCmdRegister_Player_Disconnect(%GameConnection_Handle)
{

echo("Register_Player_Disconnect:" SPC %GameConnection_Handle);

for (%x=0;%x<Dots_Net_Crits.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dots_Net_Crits.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Handle)
{

Dots_Net_Crits.Simset_Client_List.remove(%ScriptObject_Client);

%ScriptObject_Client.delete();

//Refresh lobby clients list.

Module_Lobby.Populate_Connected_Clients_List();

//Have the map remove the client here.

//

return;

}

}

}
