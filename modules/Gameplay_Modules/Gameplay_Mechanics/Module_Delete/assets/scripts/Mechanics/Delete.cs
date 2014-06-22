function Module_Delete::Delete(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index)
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

Animation="Module_Delete:Animation_Smoke";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Delete_Smoke";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Smoke);

%Gameplay_Object.safeDelete();

return;

}

}

}
