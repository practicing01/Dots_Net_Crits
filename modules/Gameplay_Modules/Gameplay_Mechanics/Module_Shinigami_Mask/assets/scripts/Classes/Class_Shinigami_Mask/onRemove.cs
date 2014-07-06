function Class_Shinigami_Mask::onRemove(%this)
{

if (isObject(%this.Sprite_Mount_Parent))
{

if (isObject(%this.Sprite_Mount_Parent.SimSet_onRemove_Listeners))
{

%this.Sprite_Mount_Parent.SimSet_onRemove_Listeners.remove(%this);

}

if (isObject(%this.Sprite_Mount_Parent.SimSet_Animate_Listeners))
{

%this.Sprite_Mount_Parent.SimSet_Animate_Listeners.remove(%this);

}

}

%this.dismount();

}
