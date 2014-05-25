function Gui_Config_Menu::VSync_Toggle(%this)
{

$pref::Video::disableVerticalSync=!$pref::Video::disableVerticalSync;

setVerticalSync($pref::Video::disableVerticalSync);

Dots_Net_Crits.Preferences_Save();

}
