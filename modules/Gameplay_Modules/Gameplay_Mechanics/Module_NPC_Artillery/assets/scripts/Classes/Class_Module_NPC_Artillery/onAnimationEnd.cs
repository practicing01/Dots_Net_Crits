function Class_Module_NPC_Artillery::onAnimationEnd(%this)
{

if (%this.Bool_Is_Moving)
{

%this.Animate(%this.Float_Angle,1);

}
else
{

%this.Animate(%this.Float_Angle,0);

}

}
