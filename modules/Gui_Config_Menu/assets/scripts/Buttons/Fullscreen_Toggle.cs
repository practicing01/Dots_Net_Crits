function Module_Gui_Config_Menu::Fullscreen_Toggle(%this,%GuiButtonCtrl)
{

$pref::Video::fullScreen=!$pref::Video::fullScreen;

toggleFullScreen();

Dots_Net_Crits.Preferences_Save();

}
