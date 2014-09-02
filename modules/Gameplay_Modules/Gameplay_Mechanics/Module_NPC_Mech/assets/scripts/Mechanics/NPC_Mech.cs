function Module_NPC_Mech::NPC_Mech(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position,%Int_Gameplay_Object_Counter)
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

Image="Module_NPC_Mech:Image_Summoning_Circle";

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

Animation="Module_NPC_Mech:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_NPC_Mech_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

/***************************************************/

//Mech sprite.

%Sprite_Mech=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Mech_Size;

FixedAngle=true;

Image="Module_NPC_Mech:Image_Mech";

Animation="Module_NPC_Mech:Animation_Mech_Stand_Down";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_Module_NPC_Mech";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name="Mech" SPC %this.Int_Gameplay_Object_Counter;

Int_Index=%Int_Gameplay_Object_Counter;

Int_Base_Speed=%this.Int_Gameplay_Object_Speed;

Int_Current_Speed=%this.Int_Gameplay_Object_Speed;

Float_Angle=-90;

Bool_Is_Moving=false;

Int_Base_Health=1000;

Int_Current_Health=1000;

SimSet_onRemove_Listeners=0;

SimSet_Animate_Listeners=0;

Int_Animation_Type=0;

SimSet_Mechanics=%this.Get_Mechanics_List();

SimSet_Status=0;//Objects's statistics.

SimSet_Foreign_Status=0;//Objects this object has affected.

Int_Base_Attack=100;

Int_Current_Attack=100;

};

%Sprite_Mech.SimSet_Foreign_Status=new SimSet();

%Sprite_Mech.SimSet_Status=new SimSet();

%Sprite_Mech.SimSet_onRemove_Listeners=new SimSet();

%Sprite_Mech.SimSet_Animate_Listeners=new SimSet();

%Sprite_Mech.Collision_Shape_Index=%Sprite_Mech.createPolygonBoxCollisionShape(%Sprite_Mech.Size);

%Sprite_Mech.setCollisionShapeIsSensor(%Sprite_Mech.Collision_Shape_Index,true);

%this.SimSet_Gameplay_Objects.add(%Sprite_Mech);

Scene_Dots_Net_Crits.add(%Sprite_Mech);

/***************************************************/

return;

}

}

}
