function Module_Lobby::Variables_Initialize(%this)
{

//Copy the global client simset so we can add fields to the clients, specific to this module.

%this.Simset_Client_List=new SimSet();

for (%x=0;%x<Dots_Net_Crits.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Dots_Net_Crits.Simset_Client_List.getObject(%x);

%ScriptObject_Client_Copy=new ScriptObject()
{

GameConnection_Handle=%ScriptObject_Client.GameConnection_Handle;

Connector_Name=%ScriptObject_Client.Connector_Name;

//Specific to Module_Lobby

Bool_Ready=false;

};

%this.Simset_Client_List.add(%ScriptObject_Client_Copy);

}

/********************************/

%this.SimSet_Gameplay_Modules=new SimSet();

/********************************/

%this.SimSet_Stars=new SimSet();

%this.Schedule_Rotate_Stars=0;

%this.Float_Magnitude=10;

%this.Vector_3D_Rotation="0 0 0";

%this.Int_Rotation_Speed=1;

%this.SimSet_Sine_Table=new SimSet();

%this.SimSet_Cosine_Table=new SimSet();

}
