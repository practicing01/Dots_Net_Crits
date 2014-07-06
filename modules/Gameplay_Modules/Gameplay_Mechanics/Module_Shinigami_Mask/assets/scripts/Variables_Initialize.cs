function Module_Shinigami_Mask::Variables_Initialize(%this)
{

%this.SimSet_Masks=new SimSet();//For toggling.

/*****/

%this.Vector_2D_Shinigami_Mask_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Shinigami_Mask);

/*****/

%this.Bool_Targeting_Object=false;

%this.Bool_Targeting_Second_Object=false;

/*****/

%this.Simset_Client_List=new SimSet();

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_Shinigami_Mask_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Dots_Net_Crits.addInputListener(%this.Script_Object_Input_Controller);

%this.SimSet_Picked_Object_List=new SimSet();

%this.Highlighted_Object_BlendColor=0;

%this.Highlighted_Object=0;

%this.Picked_Object=0;

%this.Picked_Second_Object=0;

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

class="Class_Module_Shinigami_Mask_GuiListBoxCtrl_Object_List";

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
