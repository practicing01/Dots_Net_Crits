function Module_Construct::Variables_Initialize(%this)
{

%this.Simset_Client_List=new SimSet();

/*****/

%this.SimSet_Floor_Grid=new SimSet();

%this.CompositeSprite_Floor=0;

/*****/

%this.SimSet_Player_Sprite_Modules=new SimSet();

%this.ScriptObject_Player_Sprite_Module=-1;

%this.Sprite_Player_Sprite_Preview=0;

/*****/

%this.SimSet_Gameplay_Objects=new SimSet();//This will hold objects that gameplay modules can interact with. This includes player sprites.

/*****/

%this.Int_Gameplay_Object_Speed=10;

/*****/

%this.Vector_2D_Camera_Size=SceneWindow_Dots_Net_Crits.getCameraSize();

%this.Vector_2D_Floor_Screen_Area_Size="1 1";

%this.Vector_2D_World_Limits=
%this.Vector_2D_Floor_Screen_Area_Size.X*%this.Vector_2D_Camera_Size.X
SPC
%this.Vector_2D_Floor_Screen_Area_Size.Y*%this.Vector_2D_Camera_Size.Y;

%this.Vector_2D_Floor_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Floor_Tile);

/*****/

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_Construct_Input_Controller";

Module_ID_Parent=%this;

};

SceneWindow_Dots_Net_Crits.addInputListener(%this.Script_Object_Input_Controller);

%this.SimSet_Picked_Object_List=new SimSet();

%this.Picked_Object=0;

/******************************/

%this.GuiButtonCtrl_Main_Menu=TamlRead("./../../Gui/GuiButtonCtrl_Main_Menu.gui.taml");

%this.GuiButtonCtrl_Main_Menu.Module_ID_Parent=%this;

for (%x=0;%x<%this.GuiButtonCtrl_Main_Menu.getCount();%x++)
{

%GuiControl_Child=%this.GuiButtonCtrl_Main_Menu.getObject(%x);

%GuiControl_Child.Module_ID_Parent=%this;

}

Dots_Net_Crits.add(%this.GuiButtonCtrl_Main_Menu);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiButtonCtrl_Main_Menu);

/******************************/

/******************************/

%this.GuiControl_Object_Select=TamlRead("./../../Gui/GuiControl_Object_Select.gui.taml");

%this.GuiControl_Object_Select.Module_ID_Parent=%this;

for (%x=0;%x<%this.GuiControl_Object_Select.getCount();%x++)
{

%GuiControl_Child=%this.GuiControl_Object_Select.getObject(%x);

%GuiControl_Child.Module_ID_Parent=%this;

}

Dots_Net_Crits.add(%this.GuiControl_Object_Select);

/******************************/

/******************************/

%this.GuiControl_Player_Sprite_Select=TamlRead("./../../Gui/GuiControl_Player_Sprite_Select.gui.taml");

%this.GuiControl_Player_Sprite_Select.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

%this.GuiControl_Player_Sprite_Select.Module_ID_Parent=%this;

for (%x=0;%x<%this.GuiControl_Player_Sprite_Select.getCount();%x++)
{

%GuiControl_Child=%this.GuiControl_Player_Sprite_Select.getObject(%x);

%GuiControl_Child.Module_ID_Parent=%this;

}

Dots_Net_Crits.add(%this.GuiControl_Player_Sprite_Select);

/******************************/

}
