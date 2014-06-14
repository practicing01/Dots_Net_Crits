function Module_Camera::Mount(%this)
{

if (isObject(%this.Picked_Object))
{

if (isObject(%this.SceneObject_Camera.GuiControl_Mounted))
{

%this.SceneObject_Camera.setLinearVelocity("0 0");

SceneWindow_Dots_Net_Crits.dismount();

%this.SceneObject_Camera.GuiControl_Mounted=0;

}

SceneWindow_Dots_Net_Crits.mount(%this.Picked_Object,"0 0",0,true,false);

%this.Mounted_Object=%this.Picked_Object;

}

}
