exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./Initialize/Initialize.cs");
exec("./../Classes/Classes.cs");
exec("./Synchronize_Clients.cs");
exec("./Synchronize_Module_Data.cs");
exec("./../Relay_Module_Function/Relay_Module_Function.cs");
exec("./../Gameplay/Gameplay.cs");

function Module_Forest::Scene_Load(%this)
{

%this.Ass_Load();

Scene_Dots_Net_Crits.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Forest.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
