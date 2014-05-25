function Class_GuiPopUpMenuCtrl_Resolution_List::onSelect(%this)
{

%String_Resolution=%this.getText();

if(setRes(%String_Resolution.X,%String_Resolution.Y,%String_Resolution.Z))
{

$pref::Video::defaultResolution = %String_Resolution.X SPC %String_Resolution.Y;

$pref::Video::windowedRes = %String_Resolution;

Dots_Net_Crits.Preferences_Save();

}

}
