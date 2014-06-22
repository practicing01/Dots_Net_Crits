function Module_Master_Server::Master_Server_Unload(%this)
{

if (isObject(%this.GameConnection_Connection))
{

%this.GameConnection_Connection.delete("Unloading master server.");

}

Dots_Net_Crits.Bool_Is_Client=true;

}
