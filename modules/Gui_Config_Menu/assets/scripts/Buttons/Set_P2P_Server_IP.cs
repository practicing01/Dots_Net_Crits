function Module_Gui_Config_Menu::Set_P2P_Server_IP(%this,%GuiButtonCtrl)
{

$pref::Dots_Net_Crits::P2P_IP=%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.getText();

Dots_Net_Crits.Preferences_Save();

}
