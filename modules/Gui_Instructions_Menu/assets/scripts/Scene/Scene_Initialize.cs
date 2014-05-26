function Module_Gui_Instructions_Menu::Scene_Initialize(%this)
{

%Text="Refresh the server list,";
%Text=%Text NL "";
%Text=%Text NL "Double click a server entry.";

%this.Gui_Text_ML=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Text; 
Extent=Dots_Net_Crits.Resolution;
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";
};

Gui_Instructions_Menu.addGuiControl(%this.Gui_Text_ML);

}
