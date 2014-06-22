function Module_Kitsune_Mask::Mechanic_Initialize(%this)
{

//Populate the client list using the lobby's client list.

for (%x=0;%x<Module_Lobby.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client_Copy=Module_Lobby.Simset_Client_List.getObject(%x);

%ScriptObject_New_Client=new ScriptObject()
{

GameConnection_Handle=%ScriptObject_Client_Copy.GameConnection_Handle;

Connector_Name=%ScriptObject_Client_Copy.Connector_Name;

Bool_Token_Bearer=%ScriptObject_Client_Copy.Bool_Token_Bearer;

//Specific to Module_Kitsune_Mask



};

%this.Simset_Client_List.add(%ScriptObject_New_Client);

}

//Register Module_Construct for client synchronization.

if (!Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.isMember(%this))
{

Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.add(%this);

}

/*****/

}
