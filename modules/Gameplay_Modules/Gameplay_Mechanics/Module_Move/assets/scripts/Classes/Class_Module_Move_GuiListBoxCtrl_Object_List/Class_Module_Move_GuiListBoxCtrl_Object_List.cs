function Class_Module_Move_GuiListBoxCtrl_Object_List::onDoubleClick(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

%this.Module_ID_Parent.Highlighted_Object=0;

}

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Bool_Targeting_Object=false;

%this.Module_ID_Parent.Bool_Targeting_Position=true;

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_Move_GuiListBoxCtrl_Object_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

}

%this.Module_ID_Parent.Highlighted_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Highlighted_Object_BlendColor=%this.Module_ID_Parent.Highlighted_Object.BlendColor;

%this.Module_ID_Parent.Highlighted_Object.BlendColor="0.5 1.0 1.0 1.0";

}
