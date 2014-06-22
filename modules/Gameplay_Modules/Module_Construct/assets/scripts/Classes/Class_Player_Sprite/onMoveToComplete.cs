function Class_Player_Sprite::onMoveToComplete(%this)
{

%this.Bool_Is_Moving=false;

%this.Animate(%this.Float_Angle,0);

}
