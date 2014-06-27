function Module_NPC_Shield_Generator::NPC_Shield_Generator(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position,%Int_Gameplay_Object_Counter)
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

Image="Module_NPC_Shield_Generator:Image_Summoning_Circle";

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

Animation="Module_NPC_Shield_Generator:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_NPC_Shield_Generator_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

/***************************************************/

//Shield_Generator sprite.

%Sprite_Shield_Generator=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Shield_Generator_Size;

FixedAngle=true;

Image="Module_NPC_Shield_Generator:Image_Shield_Generator";

Animation="Module_NPC_Shield_Generator:Animation_Shield_Generator_Stand_Down";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_Module_NPC_Shield_Generator";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name="Shield_Generator" SPC %this.Int_Gameplay_Object_Counter;

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

Sprite_Shield_Generator_Top=0;

SimSet_Linked_Parents=0;

SimSet_Linked_Children=0;

SimSet_Hex_Cells=0;

};

%Sprite_Shield_Generator.SimSet_Linked_Parents=new SimSet();

%Sprite_Shield_Generator.SimSet_Linked_Children=new SimSet();

%Sprite_Shield_Generator.SimSet_Hex_Cells=new SimSet();

%Sprite_Shield_Generator.SimSet_Foreign_Status=new SimSet();

%Sprite_Shield_Generator.SimSet_Status=new SimSet();

%Sprite_Shield_Generator.SimSet_onRemove_Listeners=new SimSet();

%Sprite_Shield_Generator.SimSet_Animate_Listeners=new SimSet();

%Sprite_Shield_Generator.Collision_Shape_Index=%Sprite_Shield_Generator.createPolygonBoxCollisionShape(
%Sprite_Shield_Generator.Size.X SPC
%Sprite_Shield_Generator.Size.Y+%this.Vector_2D_Shield_Generator_Top_Size.Y,
0 SPC %Sprite_Shield_Generator.Size.Y);

%Sprite_Shield_Generator.setCollisionShapeIsSensor(%Sprite_Shield_Generator.Collision_Shape_Index,true);

%this.SimSet_Gameplay_Objects.add(%Sprite_Shield_Generator);

Scene_Dots_Net_Crits.add(%Sprite_Shield_Generator);

/***************************************************/

/***************************************************/

//Shield_Generator sprite, top part.

%Sprite_Shield_Generator_Top=new Sprite()
{

Size=%this.Vector_2D_Shield_Generator_Top_Size;

FixedAngle=true;

Image="Module_NPC_Shield_Generator:Image_Shield_Generator_0";

SceneLayer=15;

PickingAllowed=false;

};

%Sprite_Shield_Generator.Sprite_Shield_Generator_Top=%Sprite_Shield_Generator_Top;

Scene_Dots_Net_Crits.add(%Sprite_Shield_Generator_Top);

%Sprite_Shield_Generator_Top.mount(%Sprite_Shield_Generator,
0 SPC (%this.Vector_2D_Shield_Generator_Size.Y*0.5)+
(%this.Vector_2D_Shield_Generator_Top_Size.Y*0.5),0,0);

/***************************************************/

return;

}

}

}
