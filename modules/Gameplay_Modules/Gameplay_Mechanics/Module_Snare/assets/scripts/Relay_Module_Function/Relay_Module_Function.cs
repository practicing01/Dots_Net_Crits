function Module_Snare::Relay_Module_Function(%this,%GameConnection_Client_Sender,%Module_Function,
%Parameter_0,%Parameter_1,%Parameter_2,%Parameter_3,%Parameter_4,%Parameter_5,%Parameter_6,
%Parameter_7,%Parameter_8,%Parameter_9,%Parameter_10,%Parameter_11,%Parameter_12)
{

if (%Module_Function$="Snare")
{

%this.Snare(%GameConnection_Client_Sender,%Parameter_0,%Parameter_1,%Parameter_2,%Parameter_3,%Parameter_4,%Parameter_5);

}
else if (%Module_Function$="Synchronize_Module_Data")
{

%this.Synchronize_Module_Data(%GameConnection_Client_Sender);

}

}
