exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./Synchronize_Clients.cs");
exec("./Populate_Connected_Clients_List.cs");
exec("./Lobby_Client_Ready.cs");
exec("./Load_Gameplay.cs");
exec("./../Buttons/Buttons.cs");
exec("./../Classes/Classes.cs");
exec("./../Relay_Module_Function/Relay_Module_Function.cs");

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
