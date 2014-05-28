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

%ScriptObject_Client_Copy.Bool_Token_Bearer=%ScriptObject_Client.Bool_Token_Bearer;

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

Bool_Token_Bearer=%ScriptObject_Client.Bool_Token_Bearer;

//Specific to Module_Lobby

Bool_Ready=false;

};

%this.Simset_Client_List.add(%ScriptObject_New_Client);

//Find this local clients information and send for Synchronize_Module_Data().

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client_Copy=%this.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client_Copy.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

commandToServer('Relay_Module_Function_To_Specific_Client',
%ScriptObject_Client.GameConnection_Handle,//Reciever client.
Module_Lobby,"Synchronize_Module_Data",
%ScriptObject_Client_Copy.Bool_Ready);//Sender client data.

break;

}

}

}

//Enable start game button if this is the token bearer.

if (%ScriptObject_Client.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side&&%ScriptObject_Client.Bool_Token_Bearer)
{

Gui_Button_Lobby_Start.Visible=true;

}

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
