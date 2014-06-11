function Class_Module_Construct_Button::onAction(%this)
{

if (%this.String_Type$="Main_Menu")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Main_Menu",%this.Module_ID_Parent);

}

}
