function Class_NPC_Artillery_Shell::onMoveToComplete(%this)
{

if (%this.ScriptObject_Client_Parent.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

%Vector_2D_Top_Left=%this.Position.X-(%this.Module_ID_Parent.Vector_2D_Explosion_Size.X*0.5) SPC %this.Position.Y+(%this.Module_ID_Parent.Vector_2D_Explosion_Size.Y*0.5);

%Vector_2D_Bottom_Right=%this.Position.X+(%this.Module_ID_Parent.Vector_2D_Explosion_Size.X*0.5) SPC %this.Position.Y-(%this.Module_ID_Parent.Vector_2D_Explosion_Size.Y*0.5);

%String_Object_List=Scene_Dots_Net_Crits.pickArea(%Vector_2D_Top_Left,%Vector_2D_Bottom_Right,"","","any");

//if (getWordCount(%String_Object_List)==0){return;}
//else
//{

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

commandToServer('Relay_Module_Function',%Object.Module_ID_Parent,"Update_Health",
%Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Object.Int_Index,
%this.Int_Current_Attack,
-1,
1,
5,
0.25
);

}

//}

}

//Explosion effect.

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;

Size=%this.Module_ID_Parent.Vector_2D_Explosion_Size;

Animation="Module_NPC_Artillery:Animation_Explosion";

SceneLayer=15;

Module_ID_Parent=%this.Module_ID_Parent;

class="Class_NPC_Artillery_Explosion";

PickingAllowed=false;

};

Scene_Dots_Net_Crits.add(%Sprite_Explosion);

%this.safeDelete();

}
