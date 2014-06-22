function clientCmdRegister_Player_Connect(%Bool_Is_My_Initializer,%GameConnection_Client_Sender,%Connector_Name,%Bool_Token_Bearer)
{

echo("Register_Player_Connect:" SPC %GameConnection_Client_Sender SPC %Connector_Name);

if (%Bool_Is_My_Initializer)
{

Dots_Net_Crits.GameConnection_Client_Connection_Server_Side=%GameConnection_Client_Sender;

}

for (%x=0;%x<Dots_Net_Crits.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dots_Net_Crits.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)//Already have client info.
{

%ScriptObject_Client.Connector_Name=%Connector_Name;//Refresh name.

%ScriptObject_Client.Bool_Token_Bearer=%Bool_Token_Bearer;

for (%y=0;%y<Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.getCount();%y++)
{

%Module_ID=Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.getObject(%y);

%Module_ID.Synchronize_Clients(%ScriptObject_Client,true);

}

return;

}

}

%ScriptObject_Client=new ScriptObject()
{

GameConnection_Handle=%GameConnection_Client_Sender;

Connector_Name=%Connector_Name;

Bool_Token_Bearer=%Bool_Token_Bearer;

};

Dots_Net_Crits.Simset_Client_List.add(%ScriptObject_Client);

for (%y=0;%y<Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.getCount();%y++)
{

%Module_ID=Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.getObject(%y);

%Module_ID.Synchronize_Clients(%ScriptObject_Client,true);

}

}
