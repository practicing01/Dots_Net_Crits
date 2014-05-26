function clientCmdQuery_Response(%Bool_Done,%Connector_Name,%IP_Address)
{

if (!%Bool_Done)
{

%ScriptObject_Server=new ScriptObject()
{

Connector_Name=%Connector_Name;

IP_Address=%IP_Address;

};

if (!isObject(Dots_Net_Crits.Simset_Server_List))
{

Dots_Net_Crits.Simset_Server_List=new SimSet();

}

Dots_Net_Crits.Simset_Server_List.add(%ScriptObject_Server);

Gui_List_Servers.addItem(%Connector_Name);

}
else
{

Dots_Net_Crits.GameConnection_Master_Server_Query.delete("Done querying master server.");

}

}
