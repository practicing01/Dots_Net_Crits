function Class_GuiButtonCtrl_Config_Menu::onAction(%this)
{

if (%this.String_Type$="Set_Player_Name")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Set_Player_Name",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Set_Master_Server_IP")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Set_Master_Server_IP",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Set_P2P_Server_IP")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Set_P2P_Server_IP",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="P2P_Server_IP_Keypad")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"P2P_Server_IP_Keypad",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Key")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Key",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Main_Menu")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Go_Main_Menu",%this.Module_ID_Parent,%this);

}

}
