function Class_Module_NPC_Zombie::onMoveToComplete(%this)
{

%this.Bool_Is_Moving=false;

%this.Animate(%this.Float_Angle,0);

}
