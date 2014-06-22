function Module_Server::Server_Unload(%this)
{

if (isObject(%this.GameConnection_Connection)&&!Dots_Net_Crits.Bool_Local_Connection)
{

%this.GameConnection_Connection.delete("Unloading server.");

}

Dots_Net_Crits.Bool_Is_Client=true;

Dots_Net_Crits.Bool_Hosting_Server=false;

}
