function Module_NPC_Barricade::Variables_Initialize(%this)
{

%this.SimSet_Gameplay_Objects=new SimSet();//This will hold objects that gameplay modules can interact with.

%this.Int_Gameplay_Object_Counter=0;

%this.Int_Gameplay_Object_Speed=1;

/*****/

%this.Vector_2D_Smoke_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Smoke);

%this.Vector_2D_Summoning_Circle_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Summoning_Circle);

%this.Vector_2D_Barricade_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Barricade);

/*****/

%this.Bool_Targeting_Object=false;

%this.Bool_Targeting_Position=false;

%this.Bool_Targeting_For_Object_Mechanic=false;

%this.Object_Mechanic_First_Target=0;

%this.String_Mechanic="";

/*****/

%this.Simset_Client_List=new SimSet();

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_NPC_Barricade_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Dots_Net_Crits.addInputListener(%this.Script_Object_Input_Controller);

%this.SimSet_Picked_Object_List=new SimSet();

%this.Highlighted_Object_BlendColor=0;

%this.Highlighted_Object=0;

%this.Picked_Object=0;

%this.Gui_Object_List=new GuiControl()
{

Profile="gui_profile_modalless";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="100 50";

MinExtent="1 1";

GuiListBoxCtrl_Object_List=0;

};

%GuiScrollCtrl_Object_List=new GuiScrollCtrl()
{

Profile="GuiLightScrollProfile_0";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="100 50";

MinExtent="1 1";

vScrollBar="dynamic";

hScrollBar="dynamic";

};

%GuiListBoxCtrl_Object_List=new GuiListBoxCtrl()
{

class="Class_Module_NPC_Barricade_GuiListBoxCtrl_Object_List";

Profile="gui_list_profile_colored";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="100 50";

MinExtent="1 1";

AllowMultipleSelections="0";

Module_ID_Parent=%this;

};

%GuiScrollCtrl_Object_List.add(%GuiListBoxCtrl_Object_List);

%this.Gui_Object_List.GuiListBoxCtrl_Object_List=%GuiListBoxCtrl_Object_List;

%this.Gui_Object_List.add(%GuiScrollCtrl_Object_List);

}
