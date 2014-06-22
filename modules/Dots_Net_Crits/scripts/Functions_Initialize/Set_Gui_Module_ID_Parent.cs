function Set_Gui_Module_ID_Parent(%GuiControl,%Module_ID_Parent)
{

%GuiControl.Module_ID_Parent=%Module_ID_Parent;

for (%x=0;%x<%GuiControl.getCount();%x++)
{

%GuiControl_Child=%GuiControl.getObject(%x);

Set_Gui_Module_ID_Parent(%GuiControl_Child,%Module_ID_Parent);

}

}
