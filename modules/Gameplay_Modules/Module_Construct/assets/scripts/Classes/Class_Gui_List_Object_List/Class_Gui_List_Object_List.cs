function Class_Gui_List_Object_List::onDoubleClick(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

%this.Module_ID_Parent.Highlighted_Object=0;

}

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.GuiControl_Object_Select);

}

function Class_Gui_List_Object_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

}

%this.Module_ID_Parent.Highlighted_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Highlighted_Object_BlendColor=%this.Module_ID_Parent.Highlighted_Object.BlendColor;

%this.Module_ID_Parent.Highlighted_Object.BlendColor="0.5 1.0 1.0 1.0";

}

function Class_Gui_List_Object_List::onMouseDragged(%this)
{

%this.onDoubleClick();

}
