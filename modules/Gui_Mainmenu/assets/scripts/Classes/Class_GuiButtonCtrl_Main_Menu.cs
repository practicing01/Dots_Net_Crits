function Class_GuiButtonCtrl_Main_Menu::onAction(%this)
{

if (%this.String_Type$="Configure")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Configure",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Instructions")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Instructions",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="P2P")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"P2P",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="List_Servers")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Servers_List",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Single_Player")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Single_Player",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Host_Master_Server")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Master_Server_Start",%this.Module_ID_Parent,%this);

}
else if (%this.String_Type$="Host_Server")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Server_Start",%this.Module_ID_Parent,%this);

}

}
