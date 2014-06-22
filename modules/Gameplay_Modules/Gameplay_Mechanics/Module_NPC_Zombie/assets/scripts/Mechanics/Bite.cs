function Module_NPC_Zombie::Bite(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
{

%Gameplay_Object=0;

%Second_Gameplay_Object=0;

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

break;

}

}

for (%x=0;%x<%Second_Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Second_Gameplay_Object=%Second_Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Second_Gameplay_Object.Int_Index==%Second_Int_Index&&%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Second_GameConnection_Handle)
{

break;

}

}

//Call the object's animation function.

if (isObject(%Gameplay_Object))
{

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Second_Gameplay_Object.Position),2);

}

if (isObject(%Second_Gameplay_Object))
{

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

%Float_Distance=%Gameplay_Object.Size.X;

if (%Gameplay_Object.Size.X<%Gameplay_Object.Size.Y){%Float_Distance=%Gameplay_Object.Size.Y;}

%Float_Distance*=1.5;

if (Vector2Distance(%Gameplay_Object.Position,%Second_Gameplay_Object.Position)<=%Float_Distance)
{

commandToServer('Relay_Module_Function',%Second_Gameplay_Object.Module_ID_Parent,"Update_Health",
%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Second_Gameplay_Object.Int_Index,
10,
-1,
1,
5,
0.25
);

//Add poison statistic.

commandToServer('Relay_Module_Function',%Second_Gameplay_Object.Module_ID_Parent,"Add_Status",
%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Second_Gameplay_Object.Int_Index,
%Gameplay_Object.Module_ID_Parent,
%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Gameplay_Object.Int_Index,
"Poison"
);

%ScriptObject_Foreign_Status=new ScriptObject()
{

Foreign_Object_Module_ID_Parent=%Second_Gameplay_Object.Module_ID_Parent;

Foreign_Object_GameConnection_Handle=%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle;

Foreign_Object_Int_Index=%Second_Gameplay_Object.Int_Index;

String_Status="Poison";

Int_Counter=3;

};

%Gameplay_Object.SimSet_Foreign_Status.add(%ScriptObject_Foreign_Status);

}

}

}

}
