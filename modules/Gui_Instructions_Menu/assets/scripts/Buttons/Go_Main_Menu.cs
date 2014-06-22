function Module_Gui_Instructions_Menu::Go_Main_Menu(%this,%GuiButtonCtrl)
{

%this.Scene_Unload();

schedule(0,0,"Module_Gui_Main_Menu::Scene_Load",Module_Gui_Main_Menu);

}
