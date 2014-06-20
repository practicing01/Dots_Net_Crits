function Module_Gameplay_Object_Controller::Load_Gameplay_Mechanic(%this,%GameConnection_Client_Sender,%Module_ID_Gameplay_Mechanic)
{

if (!isObject(%Module_ID_Gameplay_Mechanic))
{

for (%x=0;%x<%this.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=%this.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

if (%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic$=%Module_ID_Gameplay_Mechanic)
{

ModuleDatabase.LoadExplicit(%Module_ID_Gameplay_Mechanic);

%Module_ID_Gameplay_Mechanic.Mechanic_Load();

%ScriptObject_Gameplay_Mechanic_Module.Bool_Loaded=true;

return;

}

}

}

}
