function Module_NPC_Zombie::NPC_Zombie(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position,%Int_Gameplay_Object_Counter)
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

Image="Module_NPC_Zombie:Image_Summoning_Circle";

SceneLayer=15;

Module_ID_Parent=%this;

AngularVelocity=100;

LifeTime=2;

};

Scene_Dots_Net_Crits.add(%Sprite_Summoning_Circle);

//Smoke effect.

%Sprite_Smoke=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Smoke_Size;

Animation="Module_NPC_Zombie:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_NPC_Zombie_Smoke";

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

/***************************************************/

//Zombie sprite.

%Sprite_Zombie=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Zombie_Size;

FixedAngle=true;

Image="Module_NPC_Zombie:Image_Zombie";

Animation="Module_NPC_Zombie:Animation_Zombie_Stand_Down";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_Module_NPC_Zombie";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name="Zombie" SPC %this.Int_Gameplay_Object_Counter;

Int_Index=%Int_Gameplay_Object_Counter;

Int_Base_Speed=%this.Int_Gameplay_Object_Speed;

Int_Current_Speed=%this.Int_Gameplay_Object_Speed;

Float_Angle=-90;

Bool_Is_Moving=false;

Int_Health=100;

};

%Sprite_Zombie.Collision_Shape_Index=%Sprite_Zombie.createPolygonBoxCollisionShape(%Sprite_Zombie.Size);

%Sprite_Zombie.setCollisionShapeIsSensor(%Sprite_Zombie.Collision_Shape_Index,true);

%this.SimSet_Gameplay_Objects.add(%Sprite_Zombie);

Scene_Dots_Net_Crits.add(%Sprite_Zombie);

/***************************************************/

return;

}

}

}
