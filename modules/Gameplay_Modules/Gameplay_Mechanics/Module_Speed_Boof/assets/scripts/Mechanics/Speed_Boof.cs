function Module_Speed_Boof::Speed_Boof(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
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

//Speed_Boof effect.

%Sprite_Speed_Boof=new Sprite()
{

Position=%Second_Gameplay_Object.Position;

Size=%this.Vector_2D_Speed_Boof_Size;

Animation="Module_Speed_Boof:Animation_Speed_Boof";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Speed_Boof";

};

Scene_Dots_Net_Crits.add(%Sprite_Speed_Boof);

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

commandToServer('Relay_Module_Function',%Second_Gameplay_Object.Module_ID_Parent,"Update_Speed",
%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Second_Gameplay_Object.ScriptObject_Client_Parent.Int_Index,
10,
1
);

}

if (%Second_GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)//Shake camera.
{

SceneWindow_Dots_Net_Crits.startCameraShake(5,0.25);

}

}

}
