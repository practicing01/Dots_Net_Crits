function Module_Gui_Main_Menu::Configure(%this,%GuiButtonCtrl)
{

Module_Gui_Main_Menu.Scene_Unload();

ModuleDatabase.LoadExplicit("Module_Gui_Config_Menu");

Module_Gui_Config_Menu.Scene_Load();

}
