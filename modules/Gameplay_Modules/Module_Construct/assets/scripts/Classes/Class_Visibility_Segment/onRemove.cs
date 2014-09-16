function Visibility_Segment::onRemove(%this)
{

if (isObject(%this.SceneObject_Mount_Parent))
{

if (isObject(%this.SceneObject_Mount_Parent.SimSet_onRemove_Listeners))
{

%this.SceneObject_Mount_Parent.SimSet_onRemove_Listeners.remove(%this);

}

if (isObject(%this.SceneObject_Mount_Parent.SimSet_Animate_Listeners))
{

%this.SceneObject_Mount_Parent.SimSet_Animate_Listeners.remove(%this);

}

}

%this.dismount();

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

}
