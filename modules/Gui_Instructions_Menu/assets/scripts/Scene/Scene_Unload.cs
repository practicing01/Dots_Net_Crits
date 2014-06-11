function Module_Gui_Instructions_Menu::Scene_Unload(%this)
{

if (isObject(%this.GuiControl_Instructions_Menu))
{

%this.GuiControl_Instructions_Menu.deleteObjects();

%this.GuiControl_Instructions_Menu.delete();

}

%this.Ass_Unload();

}
