function Class_Module_NPC_Soldier_GuiListBoxCtrl_Object_List::onDoubleClick(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

%this.Module_ID_Parent.Highlighted_Object=0;

}

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

if (%this.Module_ID_Parent.Bool_Targeting_Object)
{

%this.Module_ID_Parent.Bool_Targeting_Object=false;

%this.Module_ID_Parent.Bool_Targeting_Position=true;

}
else if (%this.Module_ID_Parent.Bool_Targeting_For_Object_Mechanic)
{

%this.Module_ID_Parent.Bool_Targeting_For_Object_Mechanic=false;

%this.Module_ID_Parent.Object_Mechanic_Second_Target=%this.Module_ID_Parent.Picked_Object;

commandToServer('Relay_Module_Function',Module_NPC_Soldier,%this.Module_ID_Parent.String_Mechanic,
%this.Module_ID_Parent.Object_Mechanic_First_Target.Module_ID_Parent,
%this.Module_ID_Parent.Object_Mechanic_First_Target.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Object_Mechanic_First_Target.Int_Index,
%this.Module_ID_Parent.Object_Mechanic_Second_Target.Module_ID_Parent,
%this.Module_ID_Parent.Object_Mechanic_Second_Target.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Object_Mechanic_Second_Target.Int_Index);

}

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_NPC_Soldier_GuiListBoxCtrl_Object_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

}

%this.Module_ID_Parent.Highlighted_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Highlighted_Object_BlendColor=%this.Module_ID_Parent.Highlighted_Object.BlendColor;

%this.Module_ID_Parent.Highlighted_Object.BlendColor="0.5 1.0 1.0 1.0";

}
