function Module_NPC_Dagger::NPC_Dagger(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position,%Int_Gameplay_Object_Counter)
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

Image="Module_NPC_Dagger:Image_Summoning_Circle";

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

Animation="Module_NPC_Dagger:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_NPC_Dagger_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

/***************************************************/

//Dagger sprite.

%Sprite_Dagger=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Dagger_Size;

FixedAngle=true;

Image="Module_NPC_Dagger:Image_Dagger";

Animation="Module_NPC_Dagger:Animation_Dagger_Stand_Down";

SceneLayer=17;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_Module_NPC_Dagger";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name="Dagger" SPC %this.Int_Gameplay_Object_Counter;

Int_Index=%Int_Gameplay_Object_Counter;

Int_Base_Speed=%this.Int_Gameplay_Object_Speed;

Int_Current_Speed=%this.Int_Gameplay_Object_Speed;

Float_Angle=%Gameplay_Object.Float_Angle;

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

Sprite_Mount_Parent=%Gameplay_Object;

};

%Sprite_Dagger.SimSet_Foreign_Status=new SimSet();

%Sprite_Dagger.SimSet_Status=new SimSet();

%Sprite_Dagger.SimSet_onRemove_Listeners=new SimSet();

%Sprite_Dagger.SimSet_Animate_Listeners=new SimSet();

%Sprite_Dagger.Collision_Shape_Index=%Sprite_Dagger.createPolygonBoxCollisionShape(%Sprite_Dagger.Size);

%Sprite_Dagger.setCollisionShapeIsSensor(%Sprite_Dagger.Collision_Shape_Index,true);

%this.SimSet_Gameplay_Objects.add(%Sprite_Dagger);

Scene_Dots_Net_Crits.add(%Sprite_Dagger);

%Sprite_Dagger.Animate(%Gameplay_Object.Float_Angle,%Gameplay_Object.Int_Animation_Type);

%Sprite_Dagger.setAnimationFrame(%Gameplay_Object.getAnimationFrame());

%Gameplay_Object.SimSet_onRemove_Listeners.add(%Sprite_Dagger);

%Gameplay_Object.SimSet_Animate_Listeners.add(%Sprite_Dagger);

%Sprite_Dagger.mount(%Gameplay_Object,"0 0",0,0);

/***************************************************/

return;

}

}

}
