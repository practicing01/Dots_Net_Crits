function Module_Master_Server::Master_Server_Load(%this)
{

if (isObject(%this.GameConnection_Connection))
{

%this.GameConnection_Connection.delete("Restarting master server.");

}

%this.GameConnection_Connection=new GameConnection();

Dots_Net_Crits.Bool_Is_Client=false;

}
