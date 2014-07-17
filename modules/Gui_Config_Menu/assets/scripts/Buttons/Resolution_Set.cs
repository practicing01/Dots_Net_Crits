function Class_GuiPopUpMenuCtrl_Resolution_List::onSelect(%this,%GuiButtonCtrl)
{

%String_Resolution=%this.getText();

if(setRes(%String_Resolution.X,%String_Resolution.Y,%String_Resolution.Z))
{

$pref::Video::defaultResolution = %String_Resolution.X SPC %String_Resolution.Y;

$pref::Video::windowedRes = %String_Resolution;

Dots_Net_Crits.Preferences_Save();

Dots_Net_Crits.Resolution=%String_Resolution.X SPC %String_Resolution.Y;

%Y_Times_100=100*Dots_Net_Crits.Resolution.Y;
%Cam_Y=%Y_Times_100/Dots_Net_Crits.Resolution.X;

SceneWindow_Dots_Net_Crits.setCameraSize(100,%Cam_Y);

Gui_Dots_Net_Crits_Overlay.resize(0,0,Dots_Net_Crits.Resolution.X,Dots_Net_Crits.Resolution.Y);

}

}
