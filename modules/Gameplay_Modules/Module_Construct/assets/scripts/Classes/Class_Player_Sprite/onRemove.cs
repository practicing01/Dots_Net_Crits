function Class_Player_Sprite::onRemove(%this)
{

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

}
