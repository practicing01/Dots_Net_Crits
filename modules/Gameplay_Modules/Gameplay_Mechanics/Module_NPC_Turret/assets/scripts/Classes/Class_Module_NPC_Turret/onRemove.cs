function Class_Module_NPC_Turret::onRemove(%this)
{

if (isObject(%this.SimSet_Foreign_Status))
{

%this.SimSet_Foreign_Status.deleteObjects();

%this.SimSet_Foreign_Status.delete();

}

if (isObject(%this.SimSet_Status))
{

%this.SimSet_Status.deleteObjects();

%this.SimSet_Status.delete();

}

if (isObject(%this.SimSet_Mechanics))
{

%this.SimSet_Mechanics.deleteObjects();

%this.SimSet_Mechanics.delete();

}

if (isObject(%this.SimSet_onRemove_Listeners))
{

for (%x=0;%x<%this.SimSet_onRemove_Listeners.getCount();%x++)
{

%Object_Listener=%this.SimSet_onRemove_Listeners.getObject(%x);

if (isObject(%Object_Listener))
{

%Object_Listener.onRemove_Notify(%this);

}

}

%this.SimSet_onRemove_Listeners.delete();

}

if (isObject(%this.SimSet_Animate_Listeners))
{

%this.SimSet_Animate_Listeners.delete();

}

if (isObject(%this.Module_ID_Parent.SimSet_Gameplay_Objects))
{

%this.Module_ID_Parent.SimSet_Gameplay_Objects.remove(%this);

}

}
