function Class_Gui_Lobby_Button::onAction(%this)
{

if (%this.Button_Type$="Ready")
{

//Relay that we're ready.

commandToServer('Relay_Module_Function',Module_Lobby,"Lobby_Client_Ready");

}

}
