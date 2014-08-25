function Module_Ninja::create(%this)
{

exec("./assets/scripts/Player_Sprite_Load.cs");

exec("./assets/scripts/Player_Sprite_Unload.cs");

}

function Module_Ninja::destroy(%this)
{

if (!$Bool_Application_Closing)
{

%this.Player_Sprite_Unload();

}

}
