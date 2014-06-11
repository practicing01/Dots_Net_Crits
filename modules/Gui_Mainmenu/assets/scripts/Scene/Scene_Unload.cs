function Module_Gui_Main_Menu::Scene_Unload(%this)
{

if (isObject(%this.GuiControl_Main_Menu))
{

%this.GuiControl_Main_Menu.deleteObjects();

%this.GuiControl_Main_Menu.delete();

}

%this.Ass_Unload();

}
