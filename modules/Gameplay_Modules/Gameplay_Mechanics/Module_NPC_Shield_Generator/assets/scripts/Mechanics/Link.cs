function Module_NPC_Shield_Generator::Link(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
{

%Gameplay_Object=0;

%Second_Gameplay_Object=0;

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

break;

}

}

for (%x=0;%x<%Second_Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Second_Gameplay_Object=%Second_Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Second_Gameplay_Object.Int_Index==%Second_Int_Index&&%Second_Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%Second_GameConnection_Handle)
{

break;

}

}

for (%x=0;%x<%Gameplay_Object.SimSet_Linked_Children.getCount();%x++)
{

%Linked_Object=%Gameplay_Object.SimSet_Linked_Children.getObject(%x);

if (%Second_Gameplay_Object==%Linked_Object){return;}

}

//Call the object's animation function.

if (isObject(%Gameplay_Object)&&isObject(%Second_Gameplay_Object))
{

%Gameplay_Object.SimSet_Linked_Children.add(%Second_Gameplay_Object);
echo("added child" SPC %Second_Gameplay_Object);
%Second_Gameplay_Object.SimSet_Linked_Parents.add(%Gameplay_Object);

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Second_Gameplay_Object.Position),2);

}

}
