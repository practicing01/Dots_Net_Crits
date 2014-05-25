exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");

function Module_Lobby::Scene_Load(%this)
{

%this.Ass_Load();

Scene_Dots_Net_Crits.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Lobby.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

if (!isObject(Gui_Lobby))
{

Dots_Net_Crits.add(TamlRead("./../../gui/Gui_Lobby.gui.taml"));

}

Canvas.pushDialog(Gui_Lobby);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
