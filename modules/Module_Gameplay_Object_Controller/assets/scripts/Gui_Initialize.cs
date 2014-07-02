function Module_Gameplay_Object_Controller::Gui_Initialize(%this)
{

if (isObject(%this.SimSet_Gameplay_Mechanic_Module_Groups))
{

%this.SimSet_Gameplay_Mechanic_Module_Groups.deleteObjects();

}

if (isObject(%this.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List))
{

%this.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.deleteObjects();

}

if (isObject(%this.SimSet_Gameplay_Mechanic_Modules))
{

%this.SimSet_Gameplay_Mechanic_Modules.deleteObjects();

}

}
