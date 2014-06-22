function Class_Player_Sprite::onAnimationEnd(%this)
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
