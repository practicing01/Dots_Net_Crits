function Class_Module_Teleport_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (!%this.Module_ID_Parent.Bool_Targeting_Object&&!%this.Module_ID_Parent.Bool_Targeting_Position){return;}

if (%this.Module_ID_Parent.Bool_Targeting_Position)
{

%this.Module_ID_Parent.Bool_Targeting_Position=false;

commandToServer('Relay_Module_Function',Module_Teleport,"Teleport",
%this.Module_ID_Parent.Picked_Object.Module_ID_Parent,
%this.Module_ID_Parent.Picked_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Module_ID_Parent.Picked_Object.Int_Index,
%Vector_2D_World_Position);

return;

}

%String_Object_List=Scene_Dots_Net_Crits.pickPoint(%Vector_2D_World_Position,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else if (getWordCount(%String_Object_List)==1)
{

%this.Module_ID_Parent.Picked_Object=getWord(%String_Object_List,0);

%this.Module_ID_Parent.Bool_Targeting_Object=false;

%this.Module_ID_Parent.Bool_Targeting_Position=true;

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

//Fracked on android.
//%this.Module_ID_Parent.Gui_Object_List.Position=SceneWindow_Dots_Net_Crits.getWindowPoint(%Vector_2D_World_Position);

%this.Module_ID_Parent.Gui_Object_List.Position=
(Dots_Net_Crits.Resolution.X*0.5)-(%this.Module_ID_Parent.Gui_Object_List.Extent.X*0.5)
SPC
(Dots_Net_Crits.Resolution.Y*0.5)-(%this.Module_ID_Parent.Gui_Object_List.Extent.Y*0.5);

Gui_Dots_Net_Crits_Overlay.add(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_Teleport_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_Module_Teleport_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{



}
