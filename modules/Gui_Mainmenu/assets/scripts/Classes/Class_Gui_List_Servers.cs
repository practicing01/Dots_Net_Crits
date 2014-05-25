function Class_Gui_List_Servers::onDoubleClick(%this)
{

%Server_Name=Gui_List_Servers.getItemText(Gui_List_Servers.getSelectedItem());

%ScriptObject_Server=0;

for (%x=0;%x<Dots_Net_Crits.Simset_Server_List.getCount();%x++)
{

%ScriptObject=Dots_Net_Crits.Simset_Server_List.getObject(%x);

if (%ScriptObject.Connector_Name$=%Server_Name)
{

%ScriptObject_Server=%ScriptObject;

break;

}

}

if (%ScriptObject_Server==0){return;}

if (isObject(Dots_Net_Crits.GameConnection_Master_Server_Query))
{

Dots_Net_Crits.GameConnection_Master_Server_Query.delete("Stopping query, connecting to server.");

}

if (isObject(Dots_Net_Crits.GameConnection_Client_Connection))
{

Dots_Net_Crits.GameConnection_Client_Connection.delete("Connecting to a different server.");

}

Dots_Net_Crits.GameConnection_Client_Connection=new GameConnection();

Dots_Net_Crits.GameConnection_Client_Connection.setConnectArgs
(

$pref::Dots_Net_Crits::Player_Name,//Connector Name

"Client"//Connector Type

);

echo("Connecting to server:" SPC %ScriptObject_Server.Connector_Name SPC "at:" SPC %ScriptObject_Server.IP_Address);

Dots_Net_Crits.GameConnection_Client_Connection.connect(%ScriptObject_Server.IP_Address);

}
