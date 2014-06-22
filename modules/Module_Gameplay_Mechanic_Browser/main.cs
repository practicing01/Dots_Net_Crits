function Module_Gameplay_Mechanic_Browser::create(%this)
{

exec("./assets/scripts/Gui_Load.cs");

exec("./assets/scripts/Gui_Unload.cs");

}

function Module_Gameplay_Mechanic_Browser::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Gui_Unload();

}

}
