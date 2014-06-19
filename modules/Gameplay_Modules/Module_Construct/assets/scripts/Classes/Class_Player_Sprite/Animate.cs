function Class_Player_Sprite::Animate(%this,%Float_Angle,%Int_Animation_Type)
{

//Animation types:
//0=stand
//1=run
//2=melee
//3=ranged

%this.Float_Angle=%Float_Angle;

%this.Int_Animation_Type=%Int_Animation_Type;

if (%Float_Angle>=45&&%Float_Angle<135)//Up
{

if (%Int_Animation_Type==0)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Stand_Up;

}
else if (%Int_Animation_Type==1)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Run_Up;

}
else if (%Int_Animation_Type==2)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Attack_Up;

}
else if (%Int_Animation_Type==3)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Cast_Up;

}

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

if (%Int_Animation_Type==0)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Stand_Down;

}
else if (%Int_Animation_Type==1)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Run_Down;

}
else if (%Int_Animation_Type==2)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Attack_Down;

}
else if (%Int_Animation_Type==3)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Cast_Down;

}

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

if (%Int_Animation_Type==0)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Stand_Left;

}
else if (%Int_Animation_Type==1)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Run_Left;

}
else if (%Int_Animation_Type==2)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Attack_Left;

}
else if (%Int_Animation_Type==3)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Cast_Left;

}

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

if (%Int_Animation_Type==0)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Stand_Right;

}
else if (%Int_Animation_Type==1)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Run_Right;

}
else if (%Int_Animation_Type==2)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Attack_Right;

}
else if (%Int_Animation_Type==3)
{

%this.Animation=%this.ScriptObject_Client_Parent.ScriptObject_Player_Sprite_Data.Animation_Cast_Right;

}

}

for (%x=0;%x<%this.SimSet_Animate_Listeners.getCount();%x++)
{

%Object_Listener=%this.SimSet_Animate_Listeners.getObject(%x);

%Object_Listener.Animate(%Float_Angle,%Int_Animation_Type);

}

}
