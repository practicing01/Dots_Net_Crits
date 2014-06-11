function Module_Gui_Main_Menu::Master_Server_Start(%this,%GuiButtonCtrl)
{

Dots_Net_Crits.Bool_Hosting_Master_Server=!Dots_Net_Crits.Bool_Hosting_Master_Server;

if (Dots_Net_Crits.Bool_Hosting_Master_Server)
{

%GuiButtonCtrl.setText("Stop Master Server");

setNetPort(9001);//OVER NINE THOUSAND

Module_Master_Server.Master_Server_Load();

}
else
{

%GuiButtonCtrl.setText("Start Master Server");

Module_Master_Server.Master_Server_Unload();

}

}
