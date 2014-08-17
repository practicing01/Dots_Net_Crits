function Module_NPC_Soldier::Synchronize_Module_Data(%this,%GameConnection_Client_Sender)
{

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=%this.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)
{



return;

}

}

}
