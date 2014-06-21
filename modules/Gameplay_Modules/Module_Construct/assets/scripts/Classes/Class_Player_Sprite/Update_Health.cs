function Class_Player_Sprite::Update_Health(%this,%Int_Amount,%Char_Mode,%Bool_Camera_Shake,%Float_Shake_Magnitude,%Float_Shake_Time)
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

if (%Bool_Camera_Shake)
{

SceneWindow_Dots_Net_Crits.startCameraShake(%Float_Shake_Magnitude,%Float_Shake_Time);

}

if (%this.Int_Health<=0)
{

%this.Module_ID_Parent.Increment_Death_Count(%this);

%this.Int_Health=100;

}

}
