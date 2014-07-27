function Module_Gui_Config_Menu::Key(%this,%GuiButtonCtrl)
{

if (%GuiButtonCtrl.Text$="CLR")
{

%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.setText("");

}
else if (%GuiButtonCtrl.Text$="RET")
{

%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.onReturn();

%this.Set_P2P_Server_IP();

}
else
{

%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.setText(%this.GuiControl_Config_Menu->GuiTextEditCtrl_P2P_IP.getText() @ %GuiButtonCtrl.Text);

}

}
