function Class_Gui_Lobby_Button::onAction(%this)
{

if (%this.Button_Type$="Ready")
{

//Relay that we're ready.

commandToServer('Relay_Module_Function',Module_Lobby,"Lobby_Client_Ready");

}
else if (%this.Button_Type$="Start")
{

if (Gui_List_Gameplay_Modules.getSelectedItem()==-1){return;}

%String_Gameplay_Module_Description=Gui_List_Gameplay_Modules.getItemText(Gui_List_Gameplay_Modules.getSelectedItem());

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

}
