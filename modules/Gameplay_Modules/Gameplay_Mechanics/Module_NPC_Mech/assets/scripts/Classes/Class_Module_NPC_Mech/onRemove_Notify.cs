function Class_Kitsune_Mask::onRemove_Notify(%this,%Object)
{

if (%Object==%this.Object_Mounted)
{

%Object.dismount();

}

}
