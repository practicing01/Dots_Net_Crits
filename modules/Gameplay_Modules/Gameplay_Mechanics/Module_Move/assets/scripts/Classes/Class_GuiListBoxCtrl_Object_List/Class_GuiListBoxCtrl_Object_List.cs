function Class_GuiListBoxCtrl_Object_List::onDoubleClick(%this)
{

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Bool_Targeting_Object=false;

%this.Module_ID_Parent.Bool_Targeting_Position=true;

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.Gui_Object_List);

}
