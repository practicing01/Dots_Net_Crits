function Module_Construct::Remove_Statistic(%this,%Target_Object_GameConnection_Handle,%Target_Object_Int_Index,
%Origin_Object_Module_ID_Parent,%Origin_Object_GameConnection_Handle,%Origin_Object_Int_Index,%String_Statistic)
{

for (%x=0;%x<%this.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%this.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Target_Object_Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Target_Object_GameConnection_Handle)
{


for (%y=0;%y<%Gameplay_Object.SimSet_Statistics.getCount();%y++)
{

%ScriptObject_Statistic=%Gameplay_Object.SimSet_Statistics.getObject(%y);

//Potential bug to use $= instead of ==?
if (%ScriptObject_Statistic.Origin_Object_Module_ID_Parent$=%Origin_Object_Module_ID_Parent
&&%ScriptObject_Statistic.Origin_Object_GameConnection_Handle==%Origin_Object_GameConnection_Handle
&&%ScriptObject_Statistic.Origin_Object_Int_Index==%Origin_Object_Int_Index
&&%ScriptObject_Statistic.String_Statistic$=%String_Statistic)
{

%Gameplay_Object.SimSet_Statistics.remove(%ScriptObject_Statistic);

%ScriptObject_Statistic.delete();

return;

}

}

return;

}

}

}
