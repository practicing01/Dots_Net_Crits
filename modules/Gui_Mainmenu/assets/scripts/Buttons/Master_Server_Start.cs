function Gui_Main_Menu::Master_Server_Start(%this)
{

Dots_Net_Crits.Bool_Hosting_Master_Server=!Dots_Net_Crits.Bool_Hosting_Master_Server;

if (Dots_Net_Crits.Bool_Hosting_Master_Server)
{

Gui_Button_Main_Menu_Master_Server_Toggle.setText("Stop Master Server");

setNetPort(9001);//OVER NINE THOUSAND

Module_Master_Server.Master_Server_Load();

}
else
{

Gui_Button_Main_Menu_Master_Server_Toggle.setText("Start Master Server");

Module_Master_Server.Master_Server_Unload();

}

}
