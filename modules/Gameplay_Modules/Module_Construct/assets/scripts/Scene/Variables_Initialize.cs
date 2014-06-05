function Module_Construct::Variables_Initialize(%this)
{

%this.SimSet_Floor_Grid=new SimSet();

%this.CompositeSprite_Floor=0;

%this.SimSet_Player_Sprite_Modules=new SimSet();

%this.Int_Player_Sprite_Selection=-1;

/*****/

%this.Vector_2D_Camera_Size=SceneWindow_Dots_Net_Crits.getCameraSize();

%this.Vector_2D_Floor_Screen_Area_Size="1 1";

%this.Vector_2D_World_Limits=
%this.Vector_2D_Floor_Screen_Area_Size.X*%this.Vector_2D_Camera_Size.X
SPC
%this.Vector_2D_Floor_Screen_Area_Size.Y*%this.Vector_2D_Camera_Size.Y;

%this.Vector_2D_Floor_Tile_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Floor_Tile);

}
