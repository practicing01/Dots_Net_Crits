function Module_Gameplay_Object_Controller::Variables_Initialize(%this)
{

%this.ActionMap_Pick_Object=new ActionMap();

%this.ActionMap_Pick_Object.push();

%this.ActionMap_Pick_Object.bindCmd(keyboard,"space",%this @ ".Enable_Targeting();","");

/******************************/

%this.SimSet_Gameplay_Mechanic_Modules=new SimSet();

%this.SimSet_Gameplay_Mechanic_Module_Groups=new SimSet();

%this.ScriptObject_Selected_Gameplay_Mechanic=0;

%this.Bool_Targeting_Object=false;

/******************************/

%this.GuiControl_Controller=TamlRead("./../gui/GuiControl_Controller.gui.taml");

%this.GuiControl_Controller.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Controller,%this);

Dots_Net_Crits.add(%this.GuiControl_Controller);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Controller);

/******************************/

%this.GuiButtonCtrl_Show=TamlRead("./../gui/GuiButtonCtrl_Show.gui.taml");

%this.GuiButtonCtrl_Show.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiButtonCtrl_Show,%this);

Dots_Net_Crits.add(%this.GuiButtonCtrl_Show);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiButtonCtrl_Show);

/******************************/

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_Gameplay_Object_Controller_Input_Controller";

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

class="Class_Module_Gameplay_Object_Controller_GuiListBoxCtrl_Object_List";

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

/******************************/

}
