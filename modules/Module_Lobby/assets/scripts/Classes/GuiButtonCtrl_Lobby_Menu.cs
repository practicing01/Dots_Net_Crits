function GuiButtonCtrl_Lobby_Menu::onAction(%this)
{

if (%this.String_Type$="Ready")
{

//Relay that we're ready.

commandToServer('Relay_Module_Function',Module_Lobby,"Lobby_Client_Ready");

}
else if (%this.String_Type$="Start")
{

if (%this.Module_ID_Parent.GuiControl_Lobby->GuiScrollCtrl_Gameplay_Modules->GuiListBoxCtrl_Gameplay_Modules.getSelectedItem()==-1){return;}

%String_Gameplay_Module_Description=%this.Module_ID_Parent.GuiControl_Lobby->GuiScrollCtrl_Gameplay_Modules->GuiListBoxCtrl_Gameplay_Modules.getItemText(%this.Module_ID_Parent.GuiControl_Lobby->GuiScrollCtrl_Gameplay_Modules->GuiListBoxCtrl_Gameplay_Modules.getSelectedItem());

for (%x=0;%x<Module_Lobby.SimSet_Gameplay_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Module=Module_Lobby.SimSet_Gameplay_Modules.getObject(%x);

if (%ScriptObject_Gameplay_Module.String_Description$=%String_Gameplay_Module_Description)
{

commandToServer('Relay_Module_Function',Module_Lobby,"Load_Gameplay",%ScriptObject_Gameplay_Module.Module_ID_Gameplay_Module);

break;

}

}

}
else if (%this.String_Type$="Main_Menu")
{

schedule(0,0,%this.Module_ID_Parent@"::"@"Go_Main_Menu",%this.Module_ID_Parent,%this);

}

}
