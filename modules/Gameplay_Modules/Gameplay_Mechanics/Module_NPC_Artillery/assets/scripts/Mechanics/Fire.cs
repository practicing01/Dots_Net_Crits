function Module_NPC_Artillery::Fire(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position)
{

%Gameplay_Object=0;

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

break;

}

}

//Call the object's animation function.

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Vector_2D_World_Position),2);

//Shell sprites.

for (%x=0;%x<360;%x+=45)
{

%Vector_2D_Projection=Vector2Direction(%x,Vector2Mult(%this.Vector_2D_Artillery_Size,"0.5 0.5"));

%Vector_2D_Position=Vector2Add(%Gameplay_Object.Position,%Vector_2D_Projection);

%Float_Magnitude=Vector2Distance(%Vector_2D_Position,%Vector_2D_World_Position);

%Sprite_Shell=new Sprite()
{

Position=%Vector_2D_Position;

Size=%this.Vector_2D_Shell_Size;

Angle=%x;

Image="Module_NPC_Artillery:Image_Shell";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_NPC_Artillery_Shell";

SceneGroup=0;

Collision_Shape_Index=-1;

PickingAllowed=false;

Int_Base_Attack=%Gameplay_Object.Int_Base_Attack;

Int_Current_Attack=%Gameplay_Object.Int_Current_Attack;

CollisionCallback="true";

Sprite_Parent=%Gameplay_Object;

};

%Sprite_Shell.Collision_Shape_Index=%Sprite_Shell.createPolygonBoxCollisionShape(%Sprite_Shell.Size);

%Sprite_Shell.setCollisionShapeIsSensor(%Sprite_Shell.Collision_Shape_Index,true);

Scene_Dots_Net_Crits.add(%Sprite_Shell);

%Vector_2D_Projection=Vector2Add(%Sprite_Shell.Position,Vector2Direction(%x,%Float_Magnitude));

%Sprite_Shell.moveTo(%Vector_2D_Projection,50,true,false);

}

}
