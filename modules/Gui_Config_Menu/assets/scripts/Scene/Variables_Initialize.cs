function Module_Gui_Config_Menu::Variables_Initialize(%this)
{

/******************************/

%this.GuiControl_Config_Menu=TamlRead("./../../gui/GuiControl_Config_Menu.gui.taml");

%this.GuiControl_Config_Menu.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

%this.GuiControl_Config_Menu.Module_ID_Parent=%this;

for (%x=0;%x<%this.GuiControl_Config_Menu.getCount();%x++)
{

%GuiControl_Child=%this.GuiControl_Config_Menu.getObject(%x);

%GuiControl_Child.Module_ID_Parent=%this;

}

Dots_Net_Crits.add(%this.GuiControl_Config_Menu);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Config_Menu);

/******************************/


}
