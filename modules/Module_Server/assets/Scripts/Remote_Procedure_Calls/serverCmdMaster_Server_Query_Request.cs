function serverCmdMaster_Server_Query_Request(%Client)
{

echo("Got query request from:" SPC %Client);

//Go through list of connected servers and send their info to the client who requested a query.
for (%x=0;%x<ClientGroup.getCount();%x++)
{

%ScriptObject_Server=ClientGroup.getObject(%x);

if (%ScriptObject_Server.Connector_Type$="Server")
{

echo(%ScriptObject_Server.Connector_Name SPC %ScriptObject_Server.IP_Address SPC %ScriptObject_Server.Connector_Type);

commandToClient(%Client,'Query_Response',false,%ScriptObject_Server.Connector_Name,%ScriptObject_Server.IP_Address);

}

}

commandToClient(%Client,'Query_Response',true);

}
