function Class_Gui_List_Object_List::onDoubleClick(%this)
{

Module_Construct.Picked_Object=Module_Construct.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

Gui_Dots_Net_Crits_Overlay.remove(Gui_Object_Select);

}
