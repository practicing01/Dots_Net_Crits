function Module_Grid_Move_This::Variables_Initialize(%this)
{

for (%x=0;%x<Module_Lobby.Module_ID_Gameplay_Module.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=Module_Lobby.Module_ID_Gameplay_Module.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

%this.This_ScriptObject_Client=%ScriptObject_Client;

break;

}

}

/*****/

%this.Bool_Targeting_Object=false;

%this.Bool_Targeting_Position=false;

/*****/

%this.Simset_Client_List=new SimSet();

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_Grid_Move_This_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Dots_Net_Crits.addInputListener(%this.Script_Object_Input_Controller);

%this.SimSet_Picked_Object_List=new SimSet();

%this.Highlighted_Object_BlendColor=0;

%this.Highlighted_Object=0;

%this.Picked_Object=%this.This_ScriptObject_Client.Sprite_Player_Sprite;

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

class="Class_Module_Grid_Move_This_GuiListBoxCtrl_Object_List";

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
