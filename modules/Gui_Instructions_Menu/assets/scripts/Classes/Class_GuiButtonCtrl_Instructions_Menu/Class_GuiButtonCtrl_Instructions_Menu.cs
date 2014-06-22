function Class_GuiButtonCtrl_Instructions_Menu::onAction(%this)
{

if (%this.String_Type$="Main_Menu")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Go_Main_Menu",%this.Module_ID_Parent,%this);

}

}
