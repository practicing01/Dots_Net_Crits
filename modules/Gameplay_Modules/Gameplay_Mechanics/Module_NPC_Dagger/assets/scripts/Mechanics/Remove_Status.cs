function Module_NPC_Dagger::Remove_Status(%this,%Target_Object_GameConnection_Handle,%Target_Object_Int_Index,
%Origin_Object_Module_ID_Parent,%Origin_Object_GameConnection_Handle,%Origin_Object_Int_Index,%String_Status)
{

for (%x=0;%x<%this.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%this.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Target_Object_Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Target_Object_GameConnection_Handle)
{

for (%y=0;%y<%Gameplay_Object.SimSet_Status.getCount();%y++)
{

%ScriptObject_Status=%Gameplay_Object.SimSet_Status.getObject(%y);

//Potential bug to use $= instead of ==?
if (%ScriptObject_Status.Origin_Object_Module_ID_Parent$=%Origin_Object_Module_ID_Parent
&&%ScriptObject_Status.Origin_Object_GameConnection_Handle==%Origin_Object_GameConnection_Handle
&&%ScriptObject_Status.Origin_Object_Int_Index==%Origin_Object_Int_Index
&&%ScriptObject_Status.String_Status$=%String_Status)
{

%Gameplay_Object.SimSet_Status.remove(%ScriptObject_Status);

%ScriptObject_Status.delete();

return;

}

}

return;

}

}

}
