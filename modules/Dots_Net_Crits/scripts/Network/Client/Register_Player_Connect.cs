function clientCmdRegister_Player_Connect(%Bool_Is_My_Initializer,%GameConnection_Handle,%Connector_Name)
{

echo("Register_Player_Connect:" SPC %GameConnection_Handle SPC %Connector_Name);

if (%Bool_Is_My_Initializer)
{

Dots_Net_Crits.GameConnection_Client_Connection_Server_Side=%GameConnection_Handle;

}

for (%x=0;%x<Dots_Net_Crits.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dots_Net_Crits.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Handle)//Already have client info.
{

%ScriptObject_Client.Connector_Name=%Connector_Name;//Refresh name.

return;

}

}

%ScriptObject_Client=new ScriptObject()
{

GameConnection_Handle=%GameConnection_Handle;

Connector_Name=%Connector_Name;

};

Dots_Net_Crits.Simset_Client_List.add(%ScriptObject_Client);

}
