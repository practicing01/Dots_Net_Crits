function Module_Gui_Instructions_Menu::Variables_Initialize(%this)
{

%this.Gui_Text_ML=0;

%this.GuiControl_Instructions_Menu=TamlRead("./../../gui/GuiControl_Instructions_Menu.gui.taml");

%this.GuiControl_Instructions_Menu.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

%this.GuiControl_Instructions_Menu.Module_ID_Parent=%this;

for (%x=0;%x<%this.GuiControl_Instructions_Menu.getCount();%x++)
{

%GuiControl_Child=%this.GuiControl_Instructions_Menu.getObject(%x);

%GuiControl_Child.Module_ID_Parent=%this;

}

Dots_Net_Crits.add(%this.GuiControl_Instructions_Menu);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Instructions_Menu);

}
 