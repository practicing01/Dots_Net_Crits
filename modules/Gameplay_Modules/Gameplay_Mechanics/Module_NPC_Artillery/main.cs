function Module_NPC_Artillery::create(%this)
{

exec("./assets/scripts/Mechanic_Load.cs");

exec("./assets/scripts/Mechanic_Unload.cs");

}

function Module_NPC_Artillery::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Mechanic_Unload();

}

}