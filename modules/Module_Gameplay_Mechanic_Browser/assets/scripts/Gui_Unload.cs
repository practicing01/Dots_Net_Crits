function Module_Gameplay_Mechanic_Browser::Gui_Unload(%this)
{

//Canvas.popDialog(Gui_Gameplay_Mechanic_Browser);

Gui_Dots_Net_Crits_Overlay.remove(Gui_Gameplay_Mechanic_Browser);

Gui_Dots_Net_Crits_Overlay.remove(GuiButtonCtrl_Gameplay_Mechanic_Browser_Show);

%this.Ass_Unload();

}
