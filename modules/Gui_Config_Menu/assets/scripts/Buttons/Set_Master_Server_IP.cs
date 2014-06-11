function Module_Gui_Config_Menu::Set_Master_Server_IP(%this,%GuiButtonCtrl)
{

$pref::Dots_Net_Crits::Master_IP=%this.GuiControl_Config_Menu->GuiTextEditCtrl_IP.getText();

Dots_Net_Crits.Preferences_Save();

}
