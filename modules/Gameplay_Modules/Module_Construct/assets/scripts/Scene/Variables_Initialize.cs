function Module_Construct::Variables_Initialize(%this)
{

%this.ActionMap_Toggle_Grid=new ActionMap();

%this.ActionMap_Toggle_Grid.push();

%this.ActionMap_Toggle_Grid.bindCmd(keyboard,"f",%this @ ".Gui_Toggle();","");

%this.ActionMap_Toggle_Grid.bindCmd(keyboard,"d",%this @ ".Grid_Toggle();","");

/******************************/

%this.SimSet_Player_Deaths=new SimSet();

/*****/

%this.Simset_Client_List=new SimSet();

/*****/

%this.SimSet_Floor_Grid=new SimSet();

%this.CompositeSprite_Floor=0;

%this.CompositeSprite_Grid=0;

/*****/

%this.SimSet_Player_Sprite_Modules=new SimSet();

%this.ScriptObject_Player_Sprite_Module=-1;

%this.Sprite_Player_Sprite_Preview=0;

/*****/

%this.SimSet_Gameplay_Objects=new SimSet();//This will hold objects that gameplay modules can interact with. This includes player sprites.

/*****/

%this.Int_Gameplay_Object_Speed=1;

/*****/

%this.Vector_2D_Camera_Size=SceneWindow_Dots_Net_Crits.getCameraSize();

%this.Vector_2D_Floor_Screen_Area_Size="1 1";

%this.Vector_2D_World_Limits=
%this.Vector_2D_Floor_Screen_Area_Size.X*%this.Vector_2D_Camera_Size.X
SPC
%this.Vector_2D_Floor_Screen_Area_Size.Y*%this.Vector_2D_Camera_Size.Y;

%this.Vector_2D_Floor_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Floor_Tile);

%this.Vector_2D_Grid_Highlighted_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Grid_Highlighted_Tile);

/*****/

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_Construct_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Dots_Net_Crits.addInputListener(%this.Script_Object_Input_Controller);

%this.SimSet_Picked_Object_List=new SimSet();

%this.Highlighted_Object_BlendColor=0;

%this.Highlighted_Object=0;

%this.Picked_Object=0;

/******************************/

%this.GuiButtonCtrl_Main_Menu=TamlRead("./../../Gui/GuiButtonCtrl_Main_Menu.gui.taml");

%this.GuiButtonCtrl_Main_Menu.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiButtonCtrl_Main_Menu,%this);

Dots_Net_Crits.add(%this.GuiButtonCtrl_Main_Menu);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiButtonCtrl_Main_Menu);

/******************************/

/******************************/

%this.GuiControl_Object_Select=TamlRead("./../../Gui/GuiControl_Object_Select.gui.taml");

Set_Gui_Module_ID_Parent(%this.GuiControl_Object_Select,%this);

Dots_Net_Crits.add(%this.GuiControl_Object_Select);

/******************************/

/******************************/

%this.GuiControl_Player_Sprite_Select=TamlRead("./../../Gui/GuiControl_Player_Sprite_Select.gui.taml");

%this.GuiControl_Player_Sprite_Select.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Player_Sprite_Select,%this);

Dots_Net_Crits.add(%this.GuiControl_Player_Sprite_Select);

/******************************/

/******************************/

%this.GuiControl_Player_Deaths=TamlRead("./../../Gui/GuiControl_Player_Deaths.gui.taml");

%this.GuiControl_Player_Deaths.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Player_Deaths,%this);

Dots_Net_Crits.add(%this.GuiControl_Player_Deaths);

/******************************/

/******************************/

%this.GuiButtonCtrl_Grid_Toggle=TamlRead("./../../Gui/GuiButtonCtrl_Grid_Toggle.gui.taml");

%this.GuiButtonCtrl_Grid_Toggle.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiButtonCtrl_Grid_Toggle,%this);

Dots_Net_Crits.add(%this.GuiButtonCtrl_Grid_Toggle);

/******************************/

/******************************/

%this.GuiButtonCtrl_Gui_Toggle=TamlRead("./../../Gui/GuiButtonCtrl_Gui_Toggle.gui.taml");

%this.GuiButtonCtrl_Gui_Toggle.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiButtonCtrl_Gui_Toggle,%this);

Dots_Net_Crits.add(%this.GuiButtonCtrl_Gui_Toggle);

/******************************/

}
