function Module_Gameplay_Object_Controller::Clear_Gameplay_Mechanics(%this)
{

if (isObject(%this.SimSet_Gameplay_Mechanic_Module_Groups))
{

%this.SimSet_Gameplay_Mechanic_Module_Groups.deleteObjects();

}

if (isObject(%this.GuiControl_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List))
{

%this.GuiControl_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.deleteObjects();

}

if (isObject(%this.SimSet_Gameplay_Mechanic_Modules))
{

%this.SimSet_Gameplay_Mechanic_Modules.deleteObjects();

}

%this.GuiControl_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.clearItems();

%this.GuiControl_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.Extent=
%this.GuiControl_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.Original_Extent;

%this.GuiControl_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List.computeSizes();

}
