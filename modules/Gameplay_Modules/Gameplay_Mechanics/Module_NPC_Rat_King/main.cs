function Module_NPC_Rat_King::create(%this)
{

exec("./assets/scripts/Mechanic_Load.cs");

exec("./assets/scripts/Mechanic_Unload.cs");

}

function Module_NPC_Rat_King::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Mechanic_Unload();

}

}
