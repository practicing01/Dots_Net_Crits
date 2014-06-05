function Class_Dots_Net_Crits_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Dots_Net_Crits.setCameraZoom(SceneWindow_Dots_Net_Crits.getCameraZoom()+$pref::Dots_Net_Crits::cameraMouseZoomRate);

}

function Class_Dots_Net_Crits_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

SceneWindow_Dots_Net_Crits.setCameraZoom(SceneWindow_Dots_Net_Crits.getCameraZoom()-$pref::Dots_Net_Crits::cameraMouseZoomRate);

}
