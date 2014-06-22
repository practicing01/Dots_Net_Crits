function Module_Gui_Config_Menu::Set_Player_Name(%this,%GuiButtonCtrl)
{

$pref::Dots_Net_Crits::Player_Name=%this.GuiControl_Config_Menu->GuiTextEditCtrl_Player_Name.getText();

Dots_Net_Crits.Preferences_Save();

}
