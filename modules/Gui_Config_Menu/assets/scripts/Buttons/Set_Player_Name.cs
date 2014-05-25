function Gui_Config_Menu::Set_Player_Name(%this)
{

$pref::Dots_Net_Crits::Player_Name=Gui_Textedit_Player_Name.getText();

Dots_Net_Crits.Preferences_Save();

}
