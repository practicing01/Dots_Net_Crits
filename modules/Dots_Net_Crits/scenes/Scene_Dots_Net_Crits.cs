function Window_Create_Dots_Net_Crits()
{

if (!isObject(SceneWindow_Dots_Net_Crits))
{

new SceneWindow(SceneWindow_Dots_Net_Crits);   

SceneWindow_Dots_Net_Crits.Profile=Gui_Profile_SceneWindow_Dots_Net_Crits;

Canvas.setContent(SceneWindow_Dots_Net_Crits);                     

}

SceneWindow_Dots_Net_Crits.stopCameraMove();
SceneWindow_Dots_Net_Crits.dismount();
SceneWindow_Dots_Net_Crits.setViewLimitOff();
SceneWindow_Dots_Net_Crits.setRenderGroups(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setRenderLayers(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setObjectInputEventGroupFilter(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setObjectInputEventLayerFilter(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setUseObjectInputEvents(true);
SceneWindow_Dots_Net_Crits.setLockMouse(true);
SceneWindow_Dots_Net_Crits.setCameraPosition(0,0);
SceneWindow_Dots_Net_Crits.setCameraZoom(1);
SceneWindow_Dots_Net_Crits.setCameraAngle(0);

Dots_Net_Crits.Resolution=getRes();
%Y_Times_100=100*Dots_Net_Crits.Resolution.Y;
%Cam_Y=%Y_Times_100/Dots_Net_Crits.Resolution.X;

SceneWindow_Dots_Net_Crits.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Dots_Net_Crits_Overlay))
{

new GuiControl(Gui_Dots_Net_Crits_Overlay)
{

Position="0 0";

Extent=Dots_Net_Crits.Resolution;

Profile=gui_profile_modalless;

class="Class_Gui_Dots_Net_Crits_Overlay";

};   

SceneWindow_Dots_Net_Crits.addGuiControl(Gui_Dots_Net_Crits_Overlay);

Gui_Dots_Net_Crits_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Dots_Net_Crits()
{
    
if (isObject(SceneWindow_Dots_Net_Crits))
{

SceneWindow_Dots_Net_Crits.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Dots_Net_Crits()
{

if (isObject(Scene_Dots_Net_Crits))
{

Scene_Dots_Net_Crits.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Dots_Net_Crits))
{

error("Cannot set Dots_Net_Crits Scene to Window as the Scene is invalid.");
return;

}
    
SceneWindow_Dots_Net_Crits.setScene(Scene_Dots_Net_Crits);

SceneWindow_Dots_Net_Crits.stopCameraMove();
SceneWindow_Dots_Net_Crits.dismount();
SceneWindow_Dots_Net_Crits.setViewLimitOff();
SceneWindow_Dots_Net_Crits.setRenderGroups(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setRenderLayers(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setObjectInputEventGroupFilter(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setObjectInputEventLayerFilter(Dots_Net_Crits.All_Bits);
SceneWindow_Dots_Net_Crits.setUseObjectInputEvents(true);
SceneWindow_Dots_Net_Crits.setLockMouse(true);
SceneWindow_Dots_Net_Crits.setCameraPosition(0,0);
SceneWindow_Dots_Net_Crits.setCameraZoom(1);
SceneWindow_Dots_Net_Crits.setCameraAngle(0);

Dots_Net_Crits.Resolution=getRes();
%Y_Times_100=100*Dots_Net_Crits.Resolution.Y;
%Cam_Y=%Y_Times_100/Dots_Net_Crits.Resolution.X;

SceneWindow_Dots_Net_Crits.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Dots_Net_Crits()
{

//Scene_Destroy_Dots_Net_Crits();

//new Scene(Scene_Dots_Net_Crits);

if (!isObject(SceneWindow_Dots_Net_Crits))
{

error("Dots_Net_Crits: did not create scene; no window available.");

//error("Dots_Net_Crits: Created scene but no window available.");

return;

}

Scene_Destroy_Dots_Net_Crits();

new Scene(Scene_Dots_Net_Crits);

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Dots_Net_Crits to use an invalid Scene.");
return;

}
   
Scene_Destroy_Dots_Net_Crits();

%Scene.setName("Scene_Dots_Net_Crits");

//%Scene.class="Class_Scene_Dots_Net_Crits";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Dots_Net_Crits::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/

function Class_Gui_Dots_Net_Crits_Overlay::onControlDropped(%this,%GuiControl_Target,%Vector_2D_Position)
{

%GuiControl_Target.onControlDropped(%Vector_2D_Position);

}
