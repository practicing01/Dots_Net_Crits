function Module_Construct::Check_Object_Visibility(%this)
{

//Go through all of the rows and recheck their objects.

for (%x=0;%x<%this.SimSet_Visibility_Rays.getCount();%x++)
{

%SimSet_Column=%this.SimSet_Visibility_Rays.getObject(%x);

for (%y=0;%y<%SimSet_Column.getCount();%y++)
{

%SceneObject_Segment=%SimSet_Column.getObject(%y);

if (%SceneObject_Segment.SimSet_Colliding_Objects.getCount())
{

for (%z=0;%z<%SceneObject_Segment.SimSet_Colliding_Objects.getCount();%z++)
{

%SceneObject_Segment.SimSet_Colliding_Objects.getObject(%z).Visible=true;

}

break;

}

}

}

}
