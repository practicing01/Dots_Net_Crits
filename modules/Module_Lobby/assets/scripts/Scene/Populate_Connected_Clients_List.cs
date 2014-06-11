function Module_Lobby::Populate_Connected_Clients_List(%this)
{

%this.GuiControl_Lobby->GuiScrollCtrl_Connected_Clients->GuiListBoxCtrl_Connected_Clients.clearItems();

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client=%this.Simset_Client_List.getObject(%x);

%String_Client_Entry=%ScriptObject_Client.Connector_Name;

if (%ScriptObject_Client.Bool_Ready)
{

%String_Client_Entry=%String_Client_Entry SPC "Ready";

}
else
{

%String_Client_Entry=%String_Client_Entry SPC "Not Ready";

}

%this.GuiControl_Lobby->GuiScrollCtrl_Connected_Clients->GuiListBoxCtrl_Connected_Clients.addItem(%String_Client_Entry);

}

}
