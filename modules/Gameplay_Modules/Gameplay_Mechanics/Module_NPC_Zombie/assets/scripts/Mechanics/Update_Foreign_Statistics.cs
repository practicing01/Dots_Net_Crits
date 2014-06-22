function Module_NPC_Zombie::Update_Foreign_Statistics(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
{

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
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

if (!isObject(%Gameplay_Object)||!isObject(%Second_Gameplay_Object)){return;}

for (%x=0;%x<%Gameplay_Object.SimSet_Foreign_Statistics.getCount();%x++)
{

%ScriptObject_Foreign_Statistic=%Gameplay_Object.SimSet_Foreign_Statistics.getObject(%x);

//Potential bug to use $= instead of ==?
if (%ScriptObject_Foreign_Statistic.Foreign_Object_Module_ID_Parent$=%Second_Module_ID_Parent
&&%ScriptObject_Foreign_Statistic.Foreign_Object_GameConnection_Handle==%Second_GameConnection_Handle
&&%ScriptObject_Foreign_Statistic.Foreign_Object_Int_Index==%Second_Int_Index)
{

commandToServer('Relay_Module_Function',%Module_ID_Parent,%ScriptObject_Foreign_Statistic.String_Statistic,
%Module_ID_Parent,
%GameConnection_Handle,
%Int_Index,
%Second_Module_ID_Parent,
%Second_GameConnection_Handle,
%Second_Int_Index);

}

}

}

}
