function Dots_Net_Crits::Variables_Initialize(%this)
{

%this.Resolution=$pref::Video::defaultResolution;//"800 480";

%this.All_Bits="0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31";

%this.Pie=3.14;

%this.Bool_Hosting_Master_Server=false;

%this.Bool_Hosting_Server=false;

allowConnections(true);

%this.Bool_AI_Token_Bearer=false;

%this.GameConnection_Master_Server_Query=0;

%this.Bool_Local_Connection=false;

%this.Simset_Server_List=new SimSet();

//Each client holds the other connected clients info.
%this.Simset_Client_List=new SimSet();

%this.GameConnection_Client_Connection=0;

//The server and client will have different handles for their GameConnection's
//this will be used to identify ourselves within the client list.
%this.GameConnection_Client_Connection_Server_Side=0;

%this.Bool_Is_Client=true;

}
