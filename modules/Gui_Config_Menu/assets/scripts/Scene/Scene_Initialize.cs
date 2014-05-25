function Module_Gui_Config_Menu::Scene_Initialize(%this)
{

if ($pref::Audio::sfxVolume==0)
{

Checkbox_Sound_Toggle.setStateOn(true);

}

if (!$pref::Video::disableVerticalSync)
{

Checkbox_VSync_Toggle.setStateOn(true);

}

%String_Resolution_List=getResolutionList($pref::Video::displayDevice);

for (%x=0;%x<getWordCount(%String_Resolution_List);%x+=3)
{

%String_Resolution=
getWord(%String_Resolution_List,%x) SPC
getWord(%String_Resolution_List,%x+1) SPC
getWord(%String_Resolution_List,%x+2);

GuiPopUpMenuCtrl_Resolution_List.add(%String_Resolution,%x/3);

}

Gui_Textedit_Player_Name.setText($pref::Dots_Net_Crits::Player_Name);

Gui_Textedit_IP.setText($pref::Dots_Net_Crits::Master_IP);

}
