function Module_Melee_This::Mechanic_Execute(%this)
{

//%this.Bool_Targeting_Object=true;

commandToServer('Relay_Module_Function',Module_Melee_This,"Melee_This",
%this.This_ScriptObject_Client.Sprite_Player_Sprite.Module_ID_Parent,
%this.This_ScriptObject_Client.Sprite_Player_Sprite.ScriptObject_Client_Parent.GameConnection_Handle,
%this.This_ScriptObject_Client.Sprite_Player_Sprite.Int_Index,
%this.This_ScriptObject_Client.Sprite_Player_Sprite.Position
);

}
