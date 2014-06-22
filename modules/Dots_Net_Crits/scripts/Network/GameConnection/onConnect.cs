//Master Server/Server callback
function GameConnection::onConnect(%this,%arg0,%arg1,%arg2,%arg3,%arg4,%arg5,%arg6,
%arg7,%arg8,%arg9,%arg10,%arg11,%arg12,%arg13,%arg14,%arg15)
{

echo("GameConnection onConnect. Handle:" SPC %this);

echo(%arg0 SPC %arg1 SPC %arg2 SPC %arg3 SPC %arg4 SPC %arg5 SPC
%arg6 SPC %arg7 SPC %arg8 SPC %arg9 SPC %arg10 SPC %arg11 SPC
%arg12 SPC %arg13 SPC %arg14 SPC %arg15);

%this.IP_Address=%this.getAddress();

%this.Connector_Name=%arg0;

%this.Connector_Type=%arg1;//"Client" or "Server"

if (%this.Connector_Type$="Client")
{

%this.Bool_Token_Bearer=false;

if (ClientGroup.getCount()==1)
{

%this.Bool_Token_Bearer=true;

}

}

if (Dots_Net_Crits.Bool_Hosting_Server||Dots_Net_Crits.Bool_Local_Connection)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Client=ClientGroup.getObject(%x);

if (%GameConnection_Client.Connector_Type$="Client")
{

if (%GameConnection_Client!=%this)
{

commandToClient(%GameConnection_Client,'Register_Player_Connect',false,%this,%this.Connector_Name,%this.Bool_Token_Bearer);

commandToClient(%this,'Register_Player_Connect',false,%GameConnection_Client,%GameConnection_Client.Connector_Name,%GameConnection_Client.Bool_Token_Bearer);

}
else
{

commandToClient(%this,'Register_Player_Connect',true,%GameConnection_Client,%GameConnection_Client.Connector_Name,%GameConnection_Client.Bool_Token_Bearer);

}

}

}

}

}
