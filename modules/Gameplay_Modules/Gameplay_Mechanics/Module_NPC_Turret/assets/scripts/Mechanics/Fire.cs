function Module_NPC_Turret::Fire(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
{

%Gameplay_Object=0;

%Second_Gameplay_Object=0;

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

break;

}

}

for (%x=0;%x<%Second_Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Second_Gameplay_Object=%Second_Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Second_Gameplay_Object.Int_Index==%Second_Int_Index&&%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Second_GameConnection_Handle)
{

break;

}

}

if (!isObject(%Gameplay_Object)||!isObject(%Second_Module_ID_Parent)){return;}

//Call the object's animation function.

%Float_Angle=Vector2AngleToPoint(%Gameplay_Object.Position,%Second_Gameplay_Object.Position);

%Gameplay_Object.Animate(%Float_Angle,2);

//Shell sprites.

%Vector_2D_Projection=Vector2Direction(%Float_Angle,Vector2Mult(%this.Vector_2D_Turret_Size,"0.5 0.5"));

%Vector_2D_Position=Vector2Add(%Gameplay_Object.Position,%Vector_2D_Projection);

%Float_Magnitude=Vector2Distance(%Vector_2D_Position,%Second_Gameplay_Object.Position);

%Sprite_Shell=new Sprite()
{

Position=%Vector_2D_Position;

Size=%this.Vector_2D_Shell_Size;

Angle=%Float_Angle;

Image="Module_NPC_Turret:Image_Shell";

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%Gameplay_Object.ScriptObject_Client_Parent;

class="Class_NPC_Turret_Shell";

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

%Vector_2D_Projection=Vector2Add(%Sprite_Shell.Position,Vector2Direction(%Float_Angle,%Float_Magnitude));

%Sprite_Shell.moveTo(%Vector_2D_Projection,50,true,false);

}
