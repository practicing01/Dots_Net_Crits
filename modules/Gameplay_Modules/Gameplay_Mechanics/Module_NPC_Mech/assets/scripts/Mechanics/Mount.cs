function Module_NPC_Mech::Mount(%this,%GameConnection_Client_Sender,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Second_Module_ID_Parent,%Second_GameConnection_Handle,%Second_Int_Index)
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

//Call the object's animation function.

if (isObject(%Gameplay_Object))
{

//%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Second_Gameplay_Object.Position),3);

}

if (isObject(%Second_Gameplay_Object))
{

if (%Gameplay_Object!=%Second_Gameplay_Object&&%Gameplay_Object.Object_Mounted==0)//Mounting something into the mech.
{

%Second_Gameplay_Object.SimSet_onRemove_Listeners.add(%Gameplay_Object);

%Second_Gameplay_Object.Visible=false;

%Second_Gameplay_Object.setPickingAllowed(false);

%Second_Gameplay_Object.mount(%Gameplay_Object,"0 0",0,0);

%Gameplay_Object.Object_Mounted=%Second_Gameplay_Object;

}
else if (%Gameplay_Object==%Second_Gameplay_Object&&%Gameplay_Object.Object_Mounted!=0)
{

if (isObject(%Gameplay_Object.Object_Mounted))
{

if (isObject(%Gameplay_Object.Object_Mounted.SimSet_onRemove_Listeners))
{

%Gameplay_Object.Object_Mounted.SimSet_onRemove_Listeners.remove(%Gameplay_Object);

}

%Gameplay_Object.Object_Mounted.Visible=true;

%Gameplay_Object.Object_Mounted.setPickingAllowed(true);//Bug if the object originally didn't allow it :P

%Gameplay_Object.Object_Mounted.dismount();

}

%Gameplay_Object.Object_Mounted=0;

}

}

}
