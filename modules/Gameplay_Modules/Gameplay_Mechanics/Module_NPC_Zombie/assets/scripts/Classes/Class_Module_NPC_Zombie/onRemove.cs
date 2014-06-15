function Class_Module_NPC_Zombie::onRemove(%this)
{

if (isObject(%this.Module_ID_Parent.SimSet_Gameplay_Objects))
{

%this.Module_ID_Parent.SimSet_Gameplay_Objects.remove(%this);

}

}
