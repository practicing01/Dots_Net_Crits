function Class_Gui_Lobby_Button::onAction(%this)
{

if (%this.Button_Type$="Ready")
{

//Relay that we're ready.

commandToServer('Lobby_Client_Ready');

}

}
