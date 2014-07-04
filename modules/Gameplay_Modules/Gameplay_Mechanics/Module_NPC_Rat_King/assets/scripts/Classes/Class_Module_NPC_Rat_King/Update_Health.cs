function Class_Module_NPC_Rat_King::Update_Health(%this,%Int_Amount,%Char_Mode,%Bool_Camera_Shake,%Float_Shake_Magnitude,%Float_Shake_Time)
{

if (%Char_Mode==-1)//Decrease health.
{

%this.Int_Current_Health-=%Int_Amount;

/*************************************************/

//Spawn token.

if (%this.Bool_Is_King)
{

%this.Module_ID_Parent.Int_Gameplay_Object_Counter++;

commandToServer('Relay_Module_Function',Module_NPC_Rat_King,"Spawn_Token",
%this.Module_ID_Parent,
%this.ScriptObject_Client_Parent.GameConnection_Handle,
%this.Int_Index,
%this.Module_ID_Parent.Int_Gameplay_Object_Counter);

}

/*************************************************/

}
else if (%Char_Mode==1)//Increase health.
{

%this.Int_Current_Health+=%Int_Amount;

}
else//Set health.
{

%this.Int_Current_Health=%Int_Amount;

}

/*if (%Bool_Camera_Shake)
{

SceneWindow_Dots_Net_Crits.startCameraShake(%Float_Shake_Magnitude,%Float_Shake_Time);

}*/

if (%this.Int_Current_Health<=0)
{

%this.SafeDelete();

}

}
