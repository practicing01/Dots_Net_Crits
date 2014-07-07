function Module_Construct::Floor_Initialize(%this)
{

%this.CompositeSprite_Grid=new CompositeSprite()
{

SceneLayer=29;

BodyType="static";

PickingAllowed=false;

Visible=false;

};

%this.CompositeSprite_Grid.SetBatchLayout("off");
%this.CompositeSprite_Grid.SetBatchSortMode("z");
%this.CompositeSprite_Grid.SetBatchIsolated(true);

%this.CompositeSprite_Floor=new CompositeSprite()
{

SceneLayer=30;

BodyType="static";

PickingAllowed=false;

};

%this.CompositeSprite_Floor.SetBatchLayout("off");
%this.CompositeSprite_Floor.SetBatchSortMode("z");
%this.CompositeSprite_Floor.SetBatchIsolated(true);

%Vector_2D_World_Limits_Half_Offset=
%this.Vector_2D_World_Limits.X*0.5
SPC
%this.Vector_2D_World_Limits.Y*0.5;

for (%y=0;%y<%this.Vector_2D_World_Limits.Y;%y+=%this.Vector_2D_Floor_Tile_Size.Y)
{

for (%x=0;%x<%this.Vector_2D_World_Limits.X;%x+=%this.Vector_2D_Floor_Tile_Size.X)
{

%Vector_2D_Position=
%x+(%this.Vector_2D_Floor_Tile_Size.X*0.5)
SPC
%y+(%this.Vector_2D_Floor_Tile_Size.Y*0.5);

%this.CompositeSprite_Floor.addSprite();

%this.CompositeSprite_Floor.setSpriteLocalPosition(%Vector_2D_Position);

%this.CompositeSprite_Floor.setSpriteSize(%this.Vector_2D_Floor_Tile_Size);

%this.CompositeSprite_Floor.setSpriteImage("Module_Construct:Image_Floor_Tile");

%this.CompositeSprite_Grid.addSprite();

%this.CompositeSprite_Grid.setSpriteLocalPosition(%Vector_2D_Position);

%this.CompositeSprite_Grid.setSpriteSize(%this.Vector_2D_Grid_Highlighted_Tile_Size);

%this.CompositeSprite_Grid.setSpriteImage("Module_Construct:Image_Grid_Highlighted_Tile");

%this.CompositeSprite_Grid.setSpriteBlendAlpha(0.15);

/*******/

%SceneObject_Floor_Grid_Tile=new ScriptObject()
{

Vector_2D_Position=%x/%this.Vector_2D_Floor_Tile_Size.X SPC %y/%this.Vector_2D_Floor_Tile_Size.Y;

Bool_Obstructed=false;

};

%this.SimSet_Floor_Grid.add(%SceneObject_Floor_Grid_Tile);

/*******/

}

}

Scene_Dots_Net_Crits.add(%this.CompositeSprite_Floor);

Scene_Dots_Net_Crits.add(%this.CompositeSprite_Grid);

SceneWindow_Dots_Net_Crits.setCameraPosition(%Vector_2D_World_Limits_Half_Offset);

}
