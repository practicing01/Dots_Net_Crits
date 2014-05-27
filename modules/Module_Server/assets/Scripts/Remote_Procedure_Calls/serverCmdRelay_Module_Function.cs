function serverCmdRelay_Module_Function(%GameConnection_Client_Sender,%Module_ID,%Module_Function,
%Parameter_0,%Parameter_1,%Parameter_2,%Parameter_3,%Parameter_4,%Parameter_5,%Parameter_6,
%Parameter_7,%Parameter_8,%Parameter_9,%Parameter_10,%Parameter_11,%Parameter_12)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%GameConnection_Client_Reciever=ClientGroup.getObject(%x);

commandToClient(%GameConnection_Client_Reciever,'Relay_Module_Function',
%GameConnection_Client_Sender,%Module_ID,%Module_Function,
%Parameter_0,%Parameter_1,%Parameter_2,%Parameter_3,%Parameter_4,%Parameter_5,%Parameter_6,
%Parameter_7,%Parameter_8,%Parameter_9,%Parameter_10,%Parameter_11,%Parameter_12);

}

}
