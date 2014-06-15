function Module_Cloak::Cloak(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
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

//Cloak effect.

%Sprite_Cloak=new Sprite()
{

Position=%Second_Gameplay_Object.Position;

Size=%this.Vector_2D_Cloak_Size;

Animation="Module_Cloak:Animation_Cloak";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Cloak";

};

Scene_Dots_Net_Crits.add(%Sprite_Cloak);

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)//Half translucency.
{

if (%Second_Gameplay_Object.getBlendAlpha()==1)
{

%Second_Gameplay_Object.setBlendAlpha(0.5);//Cloak on.

}
else
{

%Second_Gameplay_Object.setBlendAlpha(1);//Cloak off.

}

}
else//Full transparency.
{

if (%Second_Gameplay_Object.getBlendAlpha()==1)
{

%Second_Gameplay_Object.setBlendAlpha(0);//Cloak on.

}
else
{

%Second_Gameplay_Object.setBlendAlpha(1);//Cloak off.

}

}

}

}
