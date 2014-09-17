function Module_Construct::Visibility_Rays_Initialize(%this)
{

%Player_Sprite=0;

//Find this client's sprite.

for (%z=0;%z<%this.SimSet_Gameplay_Objects.getCount();%z++)
{

%Player_Sprite=%this.SimSet_Gameplay_Objects.getObject(%z);

if (%Player_Sprite.ScriptObject_Client_Parent.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

break;

}

}

%Resolution_X_Half=Dots_Net_Crits.Resolution.X*0.60;

%Vector_2D_Camera_World_Scale=SceneWindow_Dots_Net_Crits.getCameraWorldScale();

%Vector_2D_Segment_Size=Vector2Mult("16 16",%Vector_2D_Camera_World_Scale);

for (%x=90;%x>=-90;%x-=20)//Columns (angle)
{

%SimSet_Column=new SimSet();

%this.SimSet_Visibility_Rays.add(%SimSet_Column);

%Int_Row_Size_Scale_Counter=0;

%Int_Row_Counter=0;

for (%y=0;%y<%Resolution_X_Half;%y+=16)//Rows (magnitude)
{

%Scaled_Magnitude=%y*%Vector_2D_Camera_World_Scale.Y;

%Vector_2D_Position=Vector2Direction(%x,%Scaled_Magnitude);

%SceneObject_Segment=new SceneObject()
{

Position=%Vector_2D_Position;

Size=%Vector_2D_Segment_Size.X SPC %Vector_2D_Segment_Size.Y+(%Int_Row_Size_Scale_Counter*%Vector_2D_Camera_World_Scale.Y);

Angle=%x;

SimSet_Column=%SimSet_Column;

Module_ID_Parent=%this;

class="Visibility_Segment";

SimSet_onRemove_Listeners=0;

SceneObject_Mount_Parent=0;

PickingAllowed=false;

Collision_Shape_Index=0;

Int_Row_Index=%Int_Row_Counter;

CollisionCallback="true";

SleepingAllowed=false;

SceneGroup=29;//Visibility Segments

SimSet_Colliding_Objects=0;

Parent_Player_Sprite=%Player_Sprite;

};

%SceneObject_Segment.setCollisionGroups("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 30 31");

%SceneObject_Segment.Collision_Shape_Index=%SceneObject_Segment.createPolygonBoxCollisionShape(%SceneObject_Segment.Size);

%SceneObject_Segment.setCollisionShapeIsSensor(%SceneObject_Segment.Collision_Shape_Index,true);

Scene_Dots_Net_Crits.add(%SceneObject_Segment);

%SceneObject_Segment.SimSet_onRemove_Listeners=new SimSet();

%SceneObject_Segment.SimSet_Colliding_Objects=new SimSet();

if (%SimSet_Column.getCount()>0)
{

%SceneObject_Mount_Parent=%SimSet_Column.getObject(0);

%SceneObject_Segment.SceneObject_Mount_Parent=%SceneObject_Mount_Parent;

%SceneObject_Segment.mount(%SceneObject_Mount_Parent,%SceneObject_Segment.Position,1,mDegToRad(%SceneObject_Segment.Angle));

%SceneObject_Mount_Parent.SimSet_onRemove_Listeners.add(%SceneObject_Segment);

}

%Int_Row_Size_Scale_Counter+=5;

%Int_Row_Counter++;

%SimSet_Column.add(%SceneObject_Segment);

}

//Mount column parent to player sprite.

//Find this client's sprite.

%SceneObject_Segment=%SimSet_Column.getObject(0);

%SceneObject_Segment.SceneObject_Mount_Parent=%Player_Sprite;

%SceneObject_Segment.mount(%Player_Sprite,"0 0",1,mDegToRad(%SceneObject_Segment.Angle));

%Player_Sprite.SimSet_onRemove_Listeners.add(%SceneObject_Segment);

%Player_Sprite.SimSet_Animate_Listeners.add(%SceneObject_Segment);

%SceneObject_Segment.Animate(%Player_Sprite.Float_Angle,0);

}

}
