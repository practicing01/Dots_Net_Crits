function Module_Forest::Main_Menu(%this)
{

%this.Scene_Unload();

schedule(0,0,"Module_Gui_Main_Menu::Scene_Load",Module_Gui_Main_Menu);

}
