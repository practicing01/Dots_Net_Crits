function Class_Module_NPC_Shield_Generator::Relink_Hex_Cells(%this)
{

for (%Int_Child_Step=0;%Int_Child_Step<%this.SimSet_Linked_Children.getCount();%Int_Child_Step++)
{

%Linked_Object=%this.SimSet_Linked_Children.getObject(%Int_Child_Step);

for (%Int_Y_Step=0;%Int_Y_Step<%this.Module_ID_Parent.Int_Hex_Cell_Y_Interval;%Int_Y_Step++)
{

//Code by http://www.gamedev.net/page/resources/_/technical/game-programming/line-drawing-algorithm-explained-r1275

%x1=%this.Position.X;

%y1=%this.Position.Y+(%Int_Y_Step*%this.Module_ID_Parent.Vector_2D_Hex_Cell_Size.Y)+(%this.Module_ID_Parent.Vector_2D_Shield_Generator_Size.Y*0.5);

%x2=%Linked_Object.Position.X;

%y2=%Linked_Object.Position.Y+(%Int_Y_Step*%this.Module_ID_Parent.Vector_2D_Hex_Cell_Size.Y)+(%this.Module_ID_Parent.Vector_2D_Shield_Generator_Size.Y*0.5);

%xinc1=0;
%xinc2=0;
%yinc1=0;
%yinc2=0;

%deltax = mAbs(%x2 - %x1);		// The difference between the x's
%deltay = mAbs(%y2 - %y1);		// The difference between the y's
%x = %x1;				   	// Start x off at the first pixel
%y = %y1;				   	// Start y off at the first pixel

if (%x2 >= %x1)			 	// The x-values are increasing
{
  %xinc1 = 1;
  %xinc2 = 1;
}
else						  // The x-values are decreasing
{
  %xinc1 = -1;
  %xinc2 = -1;
}

if (%y2 >= %y1)			 	// The y-values are increasing
{
  %yinc1 = 1;
  %yinc2 = 1;
}
else						  // The y-values are decreasing
{
  %yinc1 = -1;
  %yinc2 = -1;
}

if (%deltax >= %deltay)	 	// There is at least one x-value for every y-value
{
  %xinc1 = 0;				  // Don't change the x when %numerator >= %denominator
  %yinc2 = 0;				  // Don't change the y for every iteration
  %den = %deltax;
  %num = %deltax / 2;
  %numadd = %deltay;
  %numpixels = %deltax;	 	// There are more x-values than y-values
}
else						  // There is at least one y-value for every x-value
{
  %xinc2 = 0;				  // Don't change the x for every iteration
  %yinc1 = 0;				  // Don't change the y when %numerator >= %denominator
  %den = %deltay;
  %num = %deltay / 2;
  %numadd = %deltax;
  %numpixels = %deltay;	 	// There are more y-values than x-values
}

for (%curpixel = 0; %curpixel <= %numpixels; %curpixel++)
{
  //PutPixel(%x, %y);		 	// Draw the current pixel

/***********************************************************************************************************************/

%Float_Angle=Vector2AngleBetween(%x SPC %y,%Linked_Object.Position);

%Sprite_Hex_Cell=new Sprite()
{

Position=%x SPC %y;

Size=%this.Module_ID_Parent.Vector_2D_Hex_Cell_Size;

Angle=%Float_Angle;

Image="Module_NPC_Shield_Generator:Image_Hex_Cell";

BlendColor="1 1 1 0.25";

BodyType="static";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Module_NPC_Shield_Generator_Hex_Cell";

SceneGroup=30;//Walls

Collision_Shape_Index=-1;

PickingAllowed=false;

};

%Sprite_Hex_Cell.Collision_Shape_Index=%Sprite_Hex_Cell.createPolygonBoxCollisionShape(%Sprite_Hex_Cell.Size);

%Sprite_Hex_Cell.setCollisionShapeIsSensor(%Sprite_Hex_Cell.Collision_Shape_Index,true);

Scene_Dots_Net_Crits.add(%Sprite_Hex_Cell);

%this.SimSet_Hex_Cells.add(%Sprite_Hex_Cell);

/***********************************************************************************************************************/

  %num += %numadd;			  // Increase the %numerator by the top of the fraction
  if (%num >= %den)		 	// Check if %numerator >= %denominator
  {
	%num -= %den;		   	// Calculate the new %numerator value
	%x += %xinc1;		   	// Change the x as appropriate
	%y += %yinc1;		   	// Change the y as appropriate
  }
  %x += %xinc2;			 	// Change the x as appropriate
  %y += %yinc2;			 	// Change the y as appropriate
}

}

}

}
