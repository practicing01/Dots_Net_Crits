function Class_Kitsune_Mask::Animate(%this,%Float_Angle,%Int_Animation_Type)
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

%this.SceneLayer=17;

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Stand_Up";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Run_Up";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Attack_Up";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Cast_Up";

}

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

%this.SceneLayer=15;

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Stand_Down";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Run_Down";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Attack_Down";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Cast_Down";

}

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

%this.SceneLayer=15;

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Stand_Left";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Run_Left";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Attack_Left";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Cast_Left";

}

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

%this.SceneLayer=15;

if (%Int_Animation_Type==0)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Stand_Right";

}
else if (%Int_Animation_Type==1)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Run_Right";

}
else if (%Int_Animation_Type==2)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Attack_Right";

}
else if (%Int_Animation_Type==3)
{

%this.Animation="Module_Kitsune_Mask:Animation_Kitsune_Mask_Cast_Right";

}

}

}
