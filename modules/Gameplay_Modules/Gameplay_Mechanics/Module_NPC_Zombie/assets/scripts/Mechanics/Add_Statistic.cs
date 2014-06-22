function Module_NPC_Zombie::Add_Statistic(%this,%Target_Object_GameConnection_Handle,%Target_Object_Int_Index,
%Origin_Object_Module_ID_Parent,%Origin_Object_GameConnection_Handle,%Origin_Object_Int_Index,%String_Statistic)
{

for (%x=0;%x<%this.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%this.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Target_Object_Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Target_Object_GameConnection_Handle)
{

%ScriptObject_Statistic=new ScriptObject()
{

Origin_Object_Module_ID_Parent=%Origin_Object_Module_ID_Parent;

Origin_Object_GameConnection_Handle=%Origin_Object_GameConnection_Handle;

Origin_Object_Int_Index=%Origin_Object_Int_Index;

String_Statistic=%String_Statistic;

};

%Gameplay_Object.SimSet_Statistics.add(%ScriptObject_Statistic);

return;

}

}

}
