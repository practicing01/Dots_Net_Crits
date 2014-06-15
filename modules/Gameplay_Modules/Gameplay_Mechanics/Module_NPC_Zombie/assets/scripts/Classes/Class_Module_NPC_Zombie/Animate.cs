function Class_Module_NPC_Zombie::Animate(%this,%Float_Angle,%Int_Animation_Type)
{

//Animation types:
//0=stand
//1=run
//2=melee
//3=ranged

%this.Float_Angle=%Float_Angle;

if (%Float_Angle>=45&&%Float_Angle<135)//Up
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Stand_Up";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Up";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Up";//Attack

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Up";//Cast

}

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Stand_Down";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Down";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Down";//Attack

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Down";//Cast

}

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Stand_Left";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Left";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Left";//Attack

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Left";//Cast

}

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

if (%Int_Animation_Type==0)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Stand_Right";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Right";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Right";//Attack

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_NPC_Zombie:Animation_Zombie_Run_Right";//Cast

}

}

}
