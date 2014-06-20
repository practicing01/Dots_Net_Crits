function Module_Gameplay_Object_Controller::create(%this)
{

exec("./assets/scripts/Gui_Load.cs");

exec("./assets/scripts/Gui_Unload.cs");

}

function Module_Gameplay_Object_Controller::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Gui_Unload();

}

}
