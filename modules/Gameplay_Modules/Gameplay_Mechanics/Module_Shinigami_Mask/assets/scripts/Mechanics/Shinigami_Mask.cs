function Module_Shinigami_Mask::Shinigami_Mask(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
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

//Call the object's animation function.

if (isObject(%Gameplay_Object))
{

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Second_Gameplay_Object.Position),3);

}

if (isObject(%Second_Gameplay_Object))
{

for (%x=0;%x<%this.SimSet_Masks.getCount();%x++)
{

%Sprite_Mask=%this.SimSet_Masks.getObject(%x);

if (%Sprite_Mask.Sprite_Mount_Parent==%Second_Gameplay_Object)
{

%Sprite_Mask.Visible=!%Sprite_Mask.Visible;

return;

}

}

//Shinigami_Mask.

%Sprite_Shinigami_Mask=new Sprite()
{

Image="Module_Shinigami_Mask:Image_Shinigami_Mask";

Position=%Second_Gameplay_Object.Position;

Size=%this.Vector_2D_Shinigami_Mask_Size;

BodyType="static";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Shinigami_Mask";

Sprite_Mount_Parent=%Second_Gameplay_Object;

PickingAllowed=false;

Float_Angle=%Second_Gameplay_Object.Float_Angle;

Int_Animation_Type=%Second_Gameplay_Object.Int_Animation_Type;

};

Scene_Dots_Net_Crits.add(%Sprite_Shinigami_Mask);

%Sprite_Shinigami_Mask.Animate(%Second_Gameplay_Object.Float_Angle,%Second_Gameplay_Object.Int_Animation_Type);

%Sprite_Shinigami_Mask.setAnimationFrame(%Second_Gameplay_Object.getAnimationFrame());

%Second_Gameplay_Object.SimSet_onRemove_Listeners.add(%Sprite_Shinigami_Mask);

%Second_Gameplay_Object.SimSet_Animate_Listeners.add(%Sprite_Shinigami_Mask);

%Sprite_Shinigami_Mask.mount(%Second_Gameplay_Object,"0 0",0,0);

%this.SimSet_Masks.add(%Sprite_Shinigami_Mask);

}

}
