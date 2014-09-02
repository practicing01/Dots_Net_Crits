function Class_Module_NPC_Mech::Update_Attack(%this,%Int_Amount,%Char_Mode)
{

if (%Char_Mode==-1)//Decrease attack.
{

%this.Int_Current_Attack-=%Int_Amount;

}
else if (%Char_Mode==1)//Increase attack.
{

%this.Int_Current_Attack+=%Int_Amount;

}
else//Set attack.
{

%this.Int_Current_Attack=%Int_Amount;

}

if (%this.Int_Current_Attack<0)
{

%this.Int_Current_Attack=0;

}

}
