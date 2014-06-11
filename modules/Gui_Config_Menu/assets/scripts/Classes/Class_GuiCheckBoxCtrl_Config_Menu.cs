function Class_GuiCheckBoxCtrl_Config_Menu::onAction(%this)
{

if (%this.String_Type$="Sound_Toggle")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Sound_Toggle",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="VSync_Toggle")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"VSync_Toggle",%this.Module_ID_Parent,%this);

}

}
