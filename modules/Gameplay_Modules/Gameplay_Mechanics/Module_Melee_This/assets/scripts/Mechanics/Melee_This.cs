function Module_Melee_This::Melee_This(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position)
{

%Gameplay_Object=0;

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

break;

}

}

//Call the object's animation function.

if (isObject(%Gameplay_Object))
{

%Gameplay_Object.Animate(%Gameplay_Object.Float_Angle,2);

}

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

%Vector_2D_Top_Left=%Vector_2D_World_Position.X-(%Gameplay_Object.Size.X*1.5) SPC %Vector_2D_World_Position.Y+(%Gameplay_Object.Size.Y*1.5);

%Vector_2D_Bottom_Right=%Vector_2D_World_Position.X+(%Gameplay_Object.Size.X*1.5) SPC %Vector_2D_World_Position.Y-(%Gameplay_Object.Size.Y*1.5);

%String_Object_List=Scene_Dots_Net_Crits.pickArea(%Vector_2D_Top_Left,%Vector_2D_Bottom_Right,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else
{

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

if (%Object==%Gameplay_Object){continue;}

commandToServer('Relay_Module_Function',%Object.Module_ID_Parent,"Update_Health",
%Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Object.Int_Index,
10,
-1,
1,
5,
0.25
);

}

}

}

}
