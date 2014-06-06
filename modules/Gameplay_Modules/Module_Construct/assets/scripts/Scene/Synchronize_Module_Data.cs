function Module_Construct::Synchronize_Module_Data(%this,%GameConnection_Client_Sender,%Module_ID_Player_Sprite_Module)
{

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=%this.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client.GameConnection_Handle==%GameConnection_Client_Sender)
{

%ScriptObject_Client.Module_ID_Player_Sprite_Module=%Module_ID_Player_Sprite_Module;

%this.Select_Player_Sprite(%GameConnection_Client_Sender,%Parameter_0);

return;

}

}

}
