function Module_NPC_Dagger::Update_Speed(%this,%GameConnection_Handle,%Int_Index,%Int_Amount,%Char_Mode)
{

for (%x=0;%x<%this.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%this.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

%Gameplay_Object.Update_Speed(%Int_Amount,%Char_Mode);

return;

}

}

}
