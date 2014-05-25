function Gui_Config_Menu::Set_Master_Server_IP(%this)
{

$pref::Dots_Net_Crits::Master_IP=Gui_Textedit_IP.getText();

Dots_Net_Crits.Preferences_Save();

}
