function Module_Forest::create(%this)
{

exec("./assets/scripts/Scene/Scene_Load.cs");

exec("./assets/scripts/Scene/Scene_Unload.cs");

}

function Module_Forest::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Scene_Unload();

if (isObject(%this.Scene_Current))
{

%this.Scene_Current.delete();

}

Scene_Create_Dots_Net_Crits();

}

}
