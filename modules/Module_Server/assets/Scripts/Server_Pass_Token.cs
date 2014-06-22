function Module_Server::Server_Pass_Token(%this)
{

if (!isObject(%this)){return;}

%Bool_Token_Registered=false;

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Client=ClientGroup.getObject(%x);

if (%GameConnection_Client.Bool_Token_Bearer)
{

%Bool_Token_Registered=true;

break;

}

}

if (!%Bool_Token_Registered&&ClientGroup.getCount()>0)
{

%GameConnection_Random_Client=ClientGroup.getObject(getRandom(0,ClientGroup.getCount()-1));

%GameConnection_Random_Client.Bool_Token_Bearer=true;

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Client=ClientGroup.getObject(%x);

commandToClient(%GameConnection_Client,'Register_Token_Bearer',%GameConnection_Random_Client);

}

}

schedule(30000,0,"Module_Server::Server_Pass_Token",%this);

}
