exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Gui_Initialize.cs");
exec("./../Buttons/Buttons.cs");

function Module_Gameplay_Mechanic_Browser::Gui_Load(%this)
{

%this.Ass_Load();

if (!isObject(Gui_Module_Gameplay_Mechanic_Browser))
{

Dots_Net_Crits.add(TamlRead("./../../gui/Gui_Module_Gameplay_Mechanic_Browser.gui.taml"));

}

Canvas.pushDialog(Gui_Module_Gameplay_Mechanic_Browser);

%this.Variables_Initialize();

%this.Gui_Initialize();

}
