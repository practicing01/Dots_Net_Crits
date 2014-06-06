function Class_Module_Construct_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

%String_Object_List=Scene_Dots_Net_Crits.pickPoint(%Vector_2D_World_Position,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else if (getWordCount(%String_Object_List)==1)
{

%this.Module_ID_Parent.Picked_Object=getWord(%String_Object_List,0);

return;

}

%this.Module_ID_Parent.SimSet_Picked_Object_List.clear();

Gui_List_Object_List.clearItems();

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

%this.Module_ID_Parent.SimSet_Picked_Object_List.add(%Object);

Gui_List_Object_List.addItem(%Object.String_Name);

}

Gui_Object_Select.Position=SceneWindow_Dots_Net_Crits.getWindowPoint(%Vector_2D_World_Position);

Gui_Dots_Net_Crits_Overlay.add(Gui_Object_Select);

}

function Class_Module_Construct_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_Module_Construct_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{



}
