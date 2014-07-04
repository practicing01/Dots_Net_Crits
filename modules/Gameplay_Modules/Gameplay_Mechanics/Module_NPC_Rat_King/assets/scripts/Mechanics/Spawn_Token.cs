function Module_NPC_Rat_King::Spawn_Token(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Int_Gameplay_Object_Counter)
{

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

//Call the object's animation function.

%Gameplay_Object.Animate(%Gameplay_Object.Float_Angle,3);

//Summoning circle effect.

%Sprite_Summoning_Circle=new Sprite()
{

Position=%Gameplay_Object.Position;

Size=%this.Vector_2D_Summoning_Circle_Size;

Image="Module_NPC_Rat_King:Image_Summoning_Circle";

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

Position=%Gameplay_Object.Position;

Size=%this.Vector_2D_Smoke_Size;

Animation="Module_NPC_Rat_King:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_NPC_Rat_King_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

/***************************************************/

//Rat sprite.

%Sprite_Rat=new Sprite()
{

Position=%Gameplay_Object.Position;

Size=%this.Vector_2D_Rat_Size;

FixedAngle=true;

Image="Module_NPC_Rat_King:Image_Rat";

Animation="Module_NPC_Rat_King:Animation_Rat_Stand_Down";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_Module_NPC_Rat_King";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name="Rat" SPC %this.Int_Gameplay_Object_Counter;

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

Int_Base_Attack=10;

Int_Current_Attack=10;

Bool_Is_King=false;

};

%Sprite_Rat.SimSet_Foreign_Status=new SimSet();

%Sprite_Rat.SimSet_Status=new SimSet();

%Sprite_Rat.SimSet_onRemove_Listeners=new SimSet();

%Sprite_Rat.SimSet_Animate_Listeners=new SimSet();

%Sprite_Rat.Collision_Shape_Index=%Sprite_Rat.createPolygonBoxCollisionShape(%Sprite_Rat.Size);

%Sprite_Rat.setCollisionShapeIsSensor(%Sprite_Rat.Collision_Shape_Index,true);

%this.SimSet_Gameplay_Objects.add(%Sprite_Rat);

Scene_Dots_Net_Crits.add(%Sprite_Rat);

/***************************************************/

return;

}

}

}
