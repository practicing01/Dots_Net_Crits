function Module_Lobby::Populate_Connected_Clients_List(%this)
{

Gui_List_Connected_Clients.clearItems();

for (%x=0;%x<Dots_Net_Crits.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dots_Net_Crits.Simset_Client_List.getObject(%x);

Gui_List_Connected_Clients.addItem(%ScriptObject_Client.Connector_Name);

//Refresh Module_Lobby's copy of the client list.
//First pass to add connected clients.

%Bool_Client_Exists=false;

for (%y=0;%y<%this.Simset_Client_List.getCount();%y++)
{

%ScriptObject_Client_Copy=%this.Simset_Client_List.getObject(%y);

if (%ScriptObject_Client_Copy.GameConnection_Handle==%ScriptObject_Client.GameConnection_Handle)
{

%Bool_Client_Exists=true;

break;

}

if (!%Bool_Client_Exists)
{

%ScriptObject_New_Client=new ScriptObject()
{

GameConnection_Handle=%ScriptObject_Client.GameConnection_Handle;

Connector_Name=%ScriptObject_Client.Connector_Name;

//Specific to Module_Lobby

Bool_Ready=false;

};

%this.Simset_Client_List.add(%ScriptObject_New_Client);

echo("added" SPC %ScriptObject_New_Client.Connector_Name);

}

}

}

//Refresh Module_Lobby's copy of the client list.
//Second pass to delete disconnected clients.
for (%y=0;%y<%this.Simset_Client_List.getCount();%y++)
{

%Bool_Delete_Copy=true;

%ScriptObject_Client_Copy=%this.Simset_Client_List.getObject(%y);

for (%x=0;%x<Dots_Net_Crits.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dots_Net_Crits.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client_Copy.GameConnection_Handle==%ScriptObject_Client.GameConnection_Handle)
{

%ScriptObject_Client_Copy.Connector_Name=%ScriptObject_Client.Connector_Name;

//There could be a bug here.  Since the global client list doesn't store wether a client is ready or not
//and if the server decides to use the same connection handle for new, unready clients, since we're not setting
//the ready status here, the previous disconnected clients status will be used, resulting in confusion.

%Bool_Delete_Copy=false;

break;

}

}

if (%Bool_Delete_Copy)
{

echo("removed" SPC %ScriptObject_Client_Copy.Connector_Name);

%this.Simset_Client_List.remove(%ScriptObject_Client_Copy);

%ScriptObject_Client_Copy.delete();

}

}

}
