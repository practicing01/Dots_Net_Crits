function Visibility_Segment::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object==%this.Parent_Player_Sprite){return;}

%this.SimSet_Colliding_Objects.add(%Colliding_Object);

%Colliding_Object.Visible=false;

%this.Module_ID_Parent.Check_Object_Visibility();

}

function Visibility_Segment::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object==%this.Parent_Player_Sprite){return;}

%this.SimSet_Colliding_Objects.remove(%Colliding_Object);

%Colliding_Object.Visible=false;

%this.Module_ID_Parent.Check_Object_Visibility();

}
