function Module_Gameplay_Mechanic_Browser::Bound_Execute(%this,%Module_ID)
{

for (%x=0;%x<%this.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=%this.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

if (%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic$=%Module_ID)
{

if (!%ScriptObject_Gameplay_Mechanic_Module.Bool_Loaded)
{

ModuleDatabase.LoadExplicit(%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic);

%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic.Mechanic_Load();

%ScriptObject_Gameplay_Mechanic_Module.Bool_Loaded=true;

commandToServer('Relay_Module_Function',Module_Gameplay_Mechanic_Browser,"Load_Gameplay_Mechanic",%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic);

}

%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic.Mechanic_Execute();

break;

}

}

}
