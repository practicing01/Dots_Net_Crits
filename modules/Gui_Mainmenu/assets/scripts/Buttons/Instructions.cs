function Module_Gui_Main_Menu::Instructions(%this,%GuiButtonCtrl)
{

Module_Gui_Main_Menu.Scene_Unload();

ModuleDatabase.LoadExplicit("Module_Gui_Instructions_Menu");

Module_Gui_Instructions_Menu.Scene_Load();

}
