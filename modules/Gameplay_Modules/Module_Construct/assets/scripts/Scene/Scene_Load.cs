exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");

function Module_Construct::Scene_Load(%this)
{

Module_Lobby.Scene_Unload();

%this.Ass_Load();

Scene_Dots_Net_Crits.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Construct.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
