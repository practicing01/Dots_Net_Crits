function Class_Module_NPC_Barricade::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%this.ScriptObject_Client_Parent.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

commandToServer('Relay_Module_Function',Module_NPC_Barricade,"Position_Object",
%Colliding_Object.Module_ID_Parent,
%Colliding_Object.ScriptObject_Client_Parent.GameConnection_Handle,
%Colliding_Object.Int_Index,
%Colliding_Object.Position);

}

}
