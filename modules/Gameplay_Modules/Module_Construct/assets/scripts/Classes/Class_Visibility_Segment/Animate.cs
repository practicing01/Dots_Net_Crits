function Visibility_Segment::Animate(%this,%Float_Angle,%Int_Animation_Type)
{

//Animation types:
//0=stand
//1=run
//2=melee
//3=ranged

if (%Float_Angle>=45&&%Float_Angle<135)//Up
{

%this.Angle=90;

}
else if (%Float_Angle<=-45&&%Float_Angle>-135)//Down
{

%this.Angle=-90;

}
else if (%Float_Angle>=135||%Float_Angle<-135)//Left
{

%this.Angle=180;

}
else if (%Float_Angle<45||%Float_Angle>-45)//Right
{

%this.Angle=0;

}

%this.mount(%this.SceneObject_Mount_Parent,"0 0",1,mDegToRad(%this.Angle));

}
