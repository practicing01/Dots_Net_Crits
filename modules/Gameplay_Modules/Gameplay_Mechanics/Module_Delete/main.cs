function Module_Delete::create(%this)
{

exec("./assets/scripts/Mechanic_Load.cs");

exec("./assets/scripts/Mechanic_Unload.cs");

}

function Module_Delete::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Mechanic_Unload();

}

}
