function serverCmdMaster_Server_Query_Request(%Client)
{

echo("Got query request from:" SPC %Client);

//Go through list of connected servers and send their info to the client who requested a query.
for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Server=ClientGroup.getObject(%x);

if (%GameConnection_Server.Connector_Type$="Server")
{

echo(%GameConnection_Server.Connector_Name SPC %GameConnection_Server.IP_Address SPC %GameConnection_Server.Connector_Type);

commandToClient(%Client,'Query_Response',false,%GameConnection_Server.Connector_Name,%GameConnection_Server.IP_Address);

}

}

commandToClient(%Client,'Query_Response',true);

}
