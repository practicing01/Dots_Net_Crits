function Module_Gui_Config_Menu::Scene_Unload(%this)
{

if (isObject(%this.GuiControl_Config_Menu))
{

%this.GuiControl_Config_Menu.deleteObjects();

%this.GuiControl_Config_Menu.delete();

}

%this.Ass_Unload();

}
