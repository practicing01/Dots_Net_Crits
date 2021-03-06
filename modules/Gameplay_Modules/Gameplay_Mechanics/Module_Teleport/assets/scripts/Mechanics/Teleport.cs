function Module_Teleport::Teleport(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position)
{

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

//Smoke effect.

%Sprite_Smoke=new Sprite()
{

Position=%Gameplay_Object.Position;

Size=%this.Vector_2D_Smoke_Size;

Animation="Module_Teleport:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Teleport_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

//Call the object's animation function.

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Vector_2D_World_Position),3);

%Gameplay_Object.Position=%Vector_2D_World_Position;

//Smoke effect.

%Sprite_Smoke=new Sprite()
{

Position=%Gameplay_Object.Position;

Size=%this.Vector_2D_Smoke_Size;

Animation="Module_Teleport:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Teleport_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

return;

}

}

}
