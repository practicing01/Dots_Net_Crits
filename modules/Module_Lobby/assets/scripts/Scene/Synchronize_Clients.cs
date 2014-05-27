function Module_Lobby::Synchronize_Clients(%this,%ScriptObject_Client,%Bool_Connected)
{

if (%Bool_Connected)//New connection or refresh.
{

%Bool_Client_Exists=false;

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client_Copy=%this.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client_Copy.GameConnection_Handle==%ScriptObject_Client.GameConnection_Handle)
{

%ScriptObject_Client_Copy.Connector_Name=%ScriptObject_Client.Connector_Name;

%Bool_Client_Exists=true;

break;

}

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

}

//Need to send the current clients status.
//Need to figure out a way to have only 1 client send this information.  Perhaps the Token Bearer.
//Or perhaps when a client connects and recieves the data for the other connected clients,
//it sends a request to the server to request to the other clients that they send their data.

}
else//Disconnect.
{

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client_Copy=%this.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client_Copy.GameConnection_Handle==%ScriptObject_Client.GameConnection_Handle)
{

%this.Simset_Client_List.remove(%ScriptObject_Client_Copy);

%ScriptObject_Client_Copy.delete();

break;

}

}

}

%this.Populate_Connected_Clients_List();

}
