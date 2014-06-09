function Class_Player_Sprite::Update_Health(%this,%Int_Amount,%Char_Mode)
{

if (%Char_Mode==-1)//Decrease health.
{

%this.Int_Health-=%Int_Amount;

}
else if (%Char_Mode==1)//Increase health.
{

%this.Int_Health+=%Int_Amount;

}
else//Set health.
{

%this.Int_Health=%Int_Amount;

}

}
