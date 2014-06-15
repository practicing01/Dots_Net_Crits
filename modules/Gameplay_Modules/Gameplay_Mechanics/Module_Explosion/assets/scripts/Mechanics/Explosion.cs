function Module_Explosion::Explosion(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position)
{

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

//Call the object's animation function.

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Vector_2D_World_Position),3);

//Explosion effect.

%Sprite_Explosion=new Sprite()
{

Position=%Vector_2D_World_Position;

Size=%this.Vector_2D_Explosion_Size;

Animation="Module_Explosion:Animation_Explosion";

SceneLayer=15;

Module_ID_Parent=%this;

class="Class_Explosion";

};

Scene_Dots_Net_Crits.add(%Sprite_Explosion);

/***********************************************/

if (%GameConnection_Client_Sender==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

%Vector_2D_Top_Left=%Vector_2D_World_Position.X-(%this.Vector_2D_Explosion_Size.X*0.5) SPC %Vector_2D_World_Position.Y+(%this.Vector_2D_Explosion_Size.Y*0.5);

%Vector_2D_Bottom_Right=%Vector_2D_World_Position.X+(%this.Vector_2D_Explosion_Size.X*0.5) SPC %Vector_2D_World_Position.Y-(%this.Vector_2D_Explosion_Size.Y*0.5);

%String_Object_List=Scene_Dots_Net_Crits.pickArea(%Vector_2D_Top_Left,%Vector_2D_Bottom_Right,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else
{

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

commandToServer('Relay_Module_Function',%Object.Module_ID_Parent,"Update_Health",
%Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Object.ScriptObject_Client_Parent.Int_Index,
10,
-1,
1,
5,
0.25
);

}

}

}

/***********************************************/

return;

}

}

}
