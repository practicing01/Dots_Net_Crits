function Class_Module_Forest_Button::onAction(%this)
{

if (%this.String_Type$="Main_Menu")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Main_Menu",%this.Module_ID_Parent);

}
else if (%this.String_Type$="Deaths_Visibility_Toggle")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Toggle_Deaths_Visibility",%this.Module_ID_Parent);

}
else if (%this.String_Type$="Grid_Toggle")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Grid_Toggle",%this.Module_ID_Parent);

}
else if (%this.String_Type$="Gui_Toggle")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Gui_Toggle",%this.Module_ID_Parent);

}

}
