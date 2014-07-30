function Class_Module_NPC_King_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (!%this.Module_ID_Parent.Bool_Targeting_Object&&!%this.Module_ID_Parent.Bool_Targeting_Position&&!%this.Module_ID_Parent.Bool_Targeting_For_Object_Mechanic){return;}

if (%this.Module_ID_Parent.Bool_Targeting_Position)
{

%this.Module_ID_Parent.Int_Gameplay_Object_Counter++;

%this.Module_ID_Parent.Bool_Targeting_Position=false;

commandToServer('Relay_Module_Function',Module_NPC_King,"NPC_King",
%this.Module_ID_Parent.Picked_Object.Module_ID_Parent,
%this.Module_ID_Parent.Picked_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Picked_Object.Int_Index,
%Vector_2D_World_Position,
%this.Module_ID_Parent.Int_Gameplay_Object_Counter);

return;

}

%String_Object_List=Scene_Dots_Net_Crits.pickPoint(%Vector_2D_World_Position,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else if (getWordCount(%String_Object_List)==1)
{

%this.Module_ID_Parent.Picked_Object=getWord(%String_Object_List,0);

if (%this.Module_ID_Parent.Bool_Targeting_Object)
{

%this.Module_ID_Parent.Bool_Targeting_Object=false;

%this.Module_ID_Parent.Bool_Targeting_Position=true;

}
else if (%this.Module_ID_Parent.Bool_Targeting_For_Object_Mechanic)
{

%this.Module_ID_Parent.Bool_Targeting_For_Object_Mechanic=false;

%this.Module_ID_Parent.Object_Mechanic_Second_Target=%this.Module_ID_Parent.Picked_Object;

commandToServer('Relay_Module_Function',Module_NPC_King,%this.Module_ID_Parent.String_Mechanic,
%this.Module_ID_Parent.Object_Mechanic_First_Target.Module_ID_Parent,
%this.Module_ID_Parent.Object_Mechanic_First_Target.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Object_Mechanic_First_Target.Int_Index,
%this.Module_ID_Parent.Object_Mechanic_Second_Target.Module_ID_Parent,
%this.Module_ID_Parent.Object_Mechanic_Second_Target.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Object_Mechanic_Second_Target.Int_Index);

}

return;

}

%this.Module_ID_Parent.SimSet_Picked_Object_List.clear();

%this.Module_ID_Parent.Gui_Object_List.GuiListBoxCtrl_Object_List.clearItems();

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

%this.Module_ID_Parent.SimSet_Picked_Object_List.add(%Object);

%this.Module_ID_Parent.Gui_Object_List.GuiListBoxCtrl_Object_List.addItem(%Object.String_Name);

}

%this.Module_ID_Parent.Gui_Object_List.Position=SceneWindow_Dots_Net_Crits.getWindowPoint(%Vector_2D_World_Position);

Gui_Dots_Net_Crits_Overlay.add(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_NPC_King_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_Module_NPC_King_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{



}
