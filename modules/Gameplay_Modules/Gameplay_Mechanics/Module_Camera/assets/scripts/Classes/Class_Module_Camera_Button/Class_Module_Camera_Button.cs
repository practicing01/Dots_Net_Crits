function Class_Module_Camera_Button::onAction(%this)
{

if (%this.String_Type$="Minimize")
{

if (!%this.Module_ID_Parent.GuiControl_Camera.Visible)
{

%this.Module_ID_Parent.GuiControl_Camera.Active=true;

%this.Module_ID_Parent.GuiControl_Camera.Visible=true;

}
else
{

%this.Module_ID_Parent.GuiControl_Camera.Active=false;

%this.Module_ID_Parent.GuiControl_Camera.Visible=false;

}

}
else if (%this.String_Type$="Mount")
{

if (isObject(%this.Module_ID_Parent.Mounted_Object))
{

%this.Module_ID_Parent.Mounted_Object=0;

SceneWindow_Dots_Net_Crits.dismount();

}
else
{

%this.Module_ID_Parent.Bool_Targeting_Object=true;

}

}
else if (%this.String_Type$="Up")
{

if (isObject(%this.Module_ID_Parent.Mounted_Object))
{

%this.Module_ID_Parent.Mounted_Object=0;

SceneWindow_Dots_Net_Crits.dismount();

}

if (%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted!=%this)
{

%this.Module_ID_Parent.SceneObject_Camera.Position=SceneWindow_Dots_Net_Crits.getCameraPosition();

SceneWindow_Dots_Net_Crits.mount(%this.Module_ID_Parent.SceneObject_Camera,"0 0",0,true,false);

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=%this;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("0 15");

}
else
{

SceneWindow_Dots_Net_Crits.dismount();

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=0;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("0 0");

}

}
else if (%this.String_Type$="Down")
{

if (isObject(%this.Module_ID_Parent.Mounted_Object))
{

%this.Module_ID_Parent.Mounted_Object=0;

SceneWindow_Dots_Net_Crits.dismount();

}

if (%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted!=%this)
{

%this.Module_ID_Parent.SceneObject_Camera.Position=SceneWindow_Dots_Net_Crits.getCameraPosition();

SceneWindow_Dots_Net_Crits.mount(%this.Module_ID_Parent.SceneObject_Camera,"0 0",0,true,false);

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=%this;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("0 -15");

}
else
{

SceneWindow_Dots_Net_Crits.dismount();

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=0;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("0 0");

}

}
else if (%this.String_Type$="Left")
{

if (isObject(%this.Module_ID_Parent.Mounted_Object))
{

%this.Module_ID_Parent.Mounted_Object=0;

SceneWindow_Dots_Net_Crits.dismount();

}

if (%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted!=%this)
{

%this.Module_ID_Parent.SceneObject_Camera.Position=SceneWindow_Dots_Net_Crits.getCameraPosition();

SceneWindow_Dots_Net_Crits.mount(%this.Module_ID_Parent.SceneObject_Camera,"0 0",0,true,false);

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=%this;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("-15 0");

}
else
{

SceneWindow_Dots_Net_Crits.dismount();

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=0;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("0 0");

}

}
else if (%this.String_Type$="Right")
{

if (isObject(%this.Module_ID_Parent.Mounted_Object))
{

%this.Module_ID_Parent.Mounted_Object=0;

SceneWindow_Dots_Net_Crits.dismount();

}

if (%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted!=%this)
{

%this.Module_ID_Parent.SceneObject_Camera.Position=SceneWindow_Dots_Net_Crits.getCameraPosition();

SceneWindow_Dots_Net_Crits.mount(%this.Module_ID_Parent.SceneObject_Camera,"0 0",0,true,false);

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=%this;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("15 0");

}
else
{

SceneWindow_Dots_Net_Crits.dismount();

%this.Module_ID_Parent.SceneObject_Camera.GuiControl_Mounted=0;

%this.Module_ID_Parent.SceneObject_Camera.setLinearVelocity("0 0");

}

}
else if (%this.String_Type$="Zoom_In")
{

SceneWindow_Dots_Net_Crits.setCameraZoom(SceneWindow_Dots_Net_Crits.getCameraZoom()+$pref::Dots_Net_Crits::cameraMouseZoomRate);

}
else if (%this.String_Type$="Zoom_Out")
{

SceneWindow_Dots_Net_Crits.setCameraZoom(SceneWindow_Dots_Net_Crits.getCameraZoom()-$pref::Dots_Net_Crits::cameraMouseZoomRate);

}

}
