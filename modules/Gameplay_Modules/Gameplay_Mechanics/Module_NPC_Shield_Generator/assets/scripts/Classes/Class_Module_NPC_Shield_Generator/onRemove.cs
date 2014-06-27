function Class_Module_NPC_Shield_Generator::onRemove(%this)
{

for (%x=0;%x<%this.SimSet_Linked_Parents.getCount();%x++)
{

%Linked_Object=%this.SimSet_Linked_Parents.getObject(%x);

%Linked_Object.SimSet_Linked_Children.remove(%this);

}

for (%x=0;%x<%this.SimSet_Linked_Parents.getCount();%x++)
{

%Linked_Object=%this.SimSet_Linked_Parents.getObject(%x);

%Linked_Object.SimSet_Hex_Cells.deleteObjects();

%Linked_Object.SimSet_Hex_Cells.clear();

%Linked_Object.Relink_Hex_Cells();

}

if (isObject(%this.SimSet_Linked_Parents))
{

%this.SimSet_Linked_Parents.delete();

}

if (isObject(%this.SimSet_Linked_Children))
{

%this.SimSet_Linked_Children.delete();

}

if (isObject(%this.SimSet_Hex_Cells))
{

%this.SimSet_Hex_Cells.deleteObjects();

%this.SimSet_Hex_Cells.delete();

}

if (isObject(%this.Sprite_Shield_Generator_Top))
{

%this.Sprite_Shield_Generator_Top.dismount();

%this.Sprite_Shield_Generator_Top.safeDelete();

}

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
