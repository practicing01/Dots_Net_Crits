function Gui_Main_Menu::Server_Start(%this)
{

Dots_Net_Crits.Bool_Hosting_Server=!Dots_Net_Crits.Bool_Hosting_Server;

if (Dots_Net_Crits.Bool_Hosting_Server)
{

Gui_Button_Main_Menu_Server_Toggle.setText("Stop Server");

setNetPort(9002);//OVER NINE THOUSAND

Module_Server.Server_Load();

}
else
{

Gui_Button_Main_Menu_Server_Toggle.setText("Start Server");

Module_Server.Server_Unload();

}

}
