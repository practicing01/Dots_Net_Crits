function Module_NPC_Artillery::NPC_Artillery(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position,%Int_Gameplay_Object_Counter)
{

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

//Call the object's animation function.

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Vector_2D_World_Position),3);

//Summoning circle effect.

%Sprite_Summoning_Circle=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Summoning_Circle_Size;

Image="Module_NPC_Artillery:Image_Summoning_Circle";

SceneLayer=15;

Module_ID_Parent=%this;

AngularVelocity=100;

LifeTime=2;

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Summoning_Circle);

//Smoke effect.

%Sprite_Smoke=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Smoke_Size;

Animation="Module_NPC_Artillery:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_NPC_Artillery_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

/***************************************************/

//Artillery sprite.

%Sprite_Artillery=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Artillery_Size;

FixedAngle=true;

Image="Module_NPC_Artillery:Image_Artillery";

Animation="Module_NPC_Artillery:Animation_Artillery_Stand_Down";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_Module_NPC_Artillery";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name="Artillery" SPC %this.Int_Gameplay_Object_Counter;

Int_Index=%Int_Gameplay_Object_Counter;

Int_Base_Speed=%this.Int_Gameplay_Object_Speed;

Int_Current_Speed=%this.Int_Gameplay_Object_Speed;

Float_Angle=-90;

Bool_Is_Moving=false;

Int_Base_Health=100;

Int_Current_Health=100;

SimSet_onRemove_Listeners=0;

SimSet_Animate_Listeners=0;

Int_Animation_Type=0;

SimSet_Mechanics=%this.Get_Mechanics_List();

SimSet_Status=0;//Objects's statistics.

SimSet_Foreign_Status=0;//Objects this object has affected.

Int_Base_Attack=50;

Int_Current_Attack=50;

};

%Sprite_Artillery.SimSet_Foreign_Status=new SimSet();

%Sprite_Artillery.SimSet_Status=new SimSet();

%Sprite_Artillery.SimSet_onRemove_Listeners=new SimSet();

%Sprite_Artillery.SimSet_Animate_Listeners=new SimSet();

%Sprite_Artillery.Collision_Shape_Index=%Sprite_Artillery.createPolygonBoxCollisionShape(%Sprite_Artillery.Size);

%Sprite_Artillery.setCollisionShapeIsSensor(%Sprite_Artillery.Collision_Shape_Index,true);

%this.SimSet_Gameplay_Objects.add(%Sprite_Artillery);

Scene_Dots_Net_Crits.add(%Sprite_Artillery);

/***************************************************/

return;

}

}

}
