function Class_Module_Reset_Base_Status_GuiListBoxCtrl_Object_List::onDoubleClick(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

%this.Module_ID_Parent.Highlighted_Object=0;

}

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Bool_Targeting_Object=false;

commandToServer('Relay_Module_Function',Module_Reset_Base_Status,"Reset_Base_Status",
%this.Module_ID_Parent.Picked_Object.Module_ID_Parent,
%this.Module_ID_Parent.Picked_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Picked_Object.Int_Index);

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_Reset_Base_Status_GuiListBoxCtrl_Object_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

}

%this.Module_ID_Parent.Highlighted_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Highlighted_Object_BlendColor=%this.Module_ID_Parent.Highlighted_Object.BlendColor;

%this.Module_ID_Parent.Highlighted_Object.BlendColor="0.5 1.0 1.0 1.0";

}

function Class_Module_Reset_Base_Status_GuiListBoxCtrl_Object_List::onMouseDragged(%this)
{

%this.onDoubleClick();

}
