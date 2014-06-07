exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Gui_Initialize.cs");
exec("./Classes/Classes.cs");

function Module_Gameplay_Mechanic_Browser::Gui_Load(%this)
{

%this.Ass_Load();

if (!isObject(Gui_Gameplay_Mechanic_Browser))
{

Dots_Net_Crits.add(TamlRead("./../gui/Gui_Gameplay_Mechanic_Browser.gui.taml"));

}

//Canvas.pushDialog(Gui_Gameplay_Mechanic_Browser);

Gui_Dots_Net_Crits_Overlay.add(Gui_Gameplay_Mechanic_Browser);

if (!isObject(GuiButtonCtrl_Gameplay_Mechanic_Browser_Show))
{

Dots_Net_Crits.add(TamlRead("./../gui/Gui_Gameplay_Mechanic_Browser_Show.gui.taml"));

}

Gui_Dots_Net_Crits_Overlay.add(GuiButtonCtrl_Gameplay_Mechanic_Browser_Show);

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Visible=false;

%this.Variables_Initialize();

%this.Gui_Initialize();

}
