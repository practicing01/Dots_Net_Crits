function Module_Server::Server_Load(%this)
{

if (isObject(%this.GameConnection_Connection))
{

%this.GameConnection_Connection.delete("Restarting server.");

}

%this.GameConnection_Connection=new GameConnection();

Dots_Net_Crits.Bool_Is_Client=false;

%this.GameConnection_Connection.setConnectArgs
(

$pref::Dots_Net_Crits::Player_Name,//Connector Name

"Server"//Connector Type

);

if (Dots_Net_Crits.Bool_Local_Connection)
{

echo("Can't connect to master server, this is a local connection.");

}
else
{

echo("Connecting to the master server.");

%this.GameConnection_Connection.connect($pref::Dots_Net_Crits::Master_IP);

schedule(30000,0,"Module_Server::Server_Pass_Token",%this);

}

}
