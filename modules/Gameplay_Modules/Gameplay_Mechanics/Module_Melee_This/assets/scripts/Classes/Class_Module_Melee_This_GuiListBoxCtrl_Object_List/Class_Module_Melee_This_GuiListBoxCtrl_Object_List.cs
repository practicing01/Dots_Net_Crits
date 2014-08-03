function Class_Module_Melee_This_GuiListBoxCtrl_Object_List::onDoubleClick(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

%this.Module_ID_Parent.Highlighted_Object=0;

}

if (%this.Module_ID_Parent.Bool_Targeting_Object)
{

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Bool_Targeting_Object=false;

%this.Module_ID_Parent.Bool_Targeting_Second_Object=true;

}
else if (%this.Module_ID_Parent.Bool_Targeting_Second_Object)
{

%this.Module_ID_Parent.Picked_Second_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Bool_Targeting_Second_Object=false;

commandToServer('Relay_Module_Function',Module_Melee_This,"Melee_This",
%this.Module_ID_Parent.Picked_Object.Module_ID_Parent,
%this.Module_ID_Parent.Picked_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Picked_Object.Int_Index,
%this.Module_ID_Parent.Picked_Second_Object.Module_ID_Parent,
%this.Module_ID_Parent.Picked_Second_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Picked_Second_Object.Int_Index
);

}

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_Melee_This_GuiListBoxCtrl_Object_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

}

%this.Module_ID_Parent.Highlighted_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Highlighted_Object_BlendColor=%this.Module_ID_Parent.Highlighted_Object.BlendColor;

%this.Module_ID_Parent.Highlighted_Object.BlendColor="0.5 1.0 1.0 1.0";

}
