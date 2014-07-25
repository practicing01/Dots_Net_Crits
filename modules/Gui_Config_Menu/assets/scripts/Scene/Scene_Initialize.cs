function Module_Gui_Config_Menu::Scene_Initialize(%this)
{

if ($pref::Audio::sfxVolume==0)
{

%this.GuiControl_Config_Menu->GuiCheckBoxCtrl_Sound_Toggle.setStateOn(true);

}

if (!$pref::Video::disableVerticalSync)
{

%this.GuiControl_Config_Menu->GuiCheckBoxCtrl_VSync_Toggle.setStateOn(true);

}

if (!$pref::Video::fullScreen)
{

%this.GuiControl_Config_Menu->GuiCheckBoxCtrl_Fullscreen_Toggle.setStateOn(true);

}

%String_Resolution_List=getResolutionList($pref::Video::displayDevice);

for (%x=0;%x<getWordCount(%String_Resolution_List);%x+=3)
{

%String_Resolution=
getWord(%String_Resolution_List,%x) SPC
getWord(%String_Resolution_List,%x+1) SPC
getWord(%String_Resolution_List,%x+2);

%this.GuiControl_Config_Menu->GuiPopUpMenuCtrl_Resolution_List.add(%String_Resolution,%x/3);

}

%this.GuiControl_Config_Menu->GuiTextEditCtrl_Player_Name.setText($pref::Dots_Net_Crits::Player_Name);

%this.GuiControl_Config_Menu->GuiTextEditCtrl_IP.setText($pref::Dots_Net_Crits::Master_IP);

%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.setText($pref::Dots_Net_Crits::P2P_IP);

}
