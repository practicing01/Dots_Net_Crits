function Class_Module_NPC_Bard::Update_Speed(%this,%Int_Amount,%Char_Mode)
{

if (%Char_Mode==-1)//Decrease speed.
{

%this.Int_Current_Speed-=%Int_Amount;

}
else if (%Char_Mode==1)//Increase speed.
{

%this.Int_Current_Speed+=%Int_Amount;

}
else//Set speed.
{

%this.Int_Current_Speed=%Int_Amount;

}

if (%this.Int_Current_Speed<0)
{

%this.Int_Current_Speed=0;

}

}
