function Module_NPC_Bard::Inspire(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
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

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Second_Gameplay_Object.Position),3);

}

if (isObject(%Second_Gameplay_Object))
{

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

%Vector_2D_Top_Left=%Gameplay_Object.Position.X-(%Gameplay_Object.Size.X*10) SPC %Gameplay_Object.Position.Y+(%Gameplay_Object.Size.Y*10);

%Vector_2D_Bottom_Right=%Gameplay_Object.Position.X+(%Gameplay_Object.Size.X*10) SPC %Gameplay_Object.Position.Y-(%Gameplay_Object.Size.Y*10);

%String_Object_List=Scene_Dots_Net_Crits.pickArea(%Vector_2D_Top_Left,%Vector_2D_Bottom_Right,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else
{

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

if (%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Object.ScriptObject_Client_Parent.GameConnection_Handle)
{

//Inspire

commandToServer('Relay_Module_Function',%Object.Module_ID_Parent,"Update_Attack",
%Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Object.Int_Index,
10,
1
);

commandToServer('Relay_Module_Function',%Object.Module_ID_Parent,"Update_Speed",
%Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Object.Int_Index,
1,
1
);

}

}

}

}

}

}
