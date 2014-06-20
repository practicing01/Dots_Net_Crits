function Module_Gui_Main_Menu::Variables_Initialize(%this)
{

Dots_Net_Crits.Bool_Local_Connection=false;

/******************************/

%this.GuiControl_Main_Menu=TamlRead("./../../gui/GuiControl_Main_Menu.gui.taml");

%this.GuiControl_Main_Menu.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Main_Menu,%this);

Dots_Net_Crits.add(%this.GuiControl_Main_Menu);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Main_Menu);

/******************************/

}
