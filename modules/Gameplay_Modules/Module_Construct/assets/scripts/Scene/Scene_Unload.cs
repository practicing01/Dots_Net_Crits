function Module_Construct::Scene_Unload(%this)
{

if (isObject(Module_Gameplay_Mechanic_Browser))
{

Module_Gameplay_Mechanic_Browser.Gui_Unload();

ModuleDatabase.unloadExplicit(Module_Gameplay_Mechanic_Browser);

}

if (isObject(Module_Gameplay_Object_Controller))
{

Module_Gameplay_Object_Controller.Gui_Unload();

ModuleDatabase.unloadExplicit(Module_Gameplay_Object_Controller);

}

if (isObject(%this.SimSet_Gameplay_Objects))
{

%this.SimSet_Gameplay_Objects.delete();

}

if (isObject(%this.Simset_Client_List))
{

%this.Simset_Client_List.deleteObjects();

%this.Simset_Client_List.delete();

}

if (Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.isMember(%this))
{

Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.remove(%this);

}

if (isObject(%this.Script_Object_Input_Controller))
{

SceneWindow_Dots_Net_Crits.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

if (isObject(%this.SimSet_Picked_Object_List))
{

%this.SimSet_Picked_Object_List.delete();

}

%this.Ass_Unload();

if (isObject(%this.SimSet_Floor_Grid))
{

%this.SimSet_Floor_Grid.deleteObjects();

%this.SimSet_Floor_Grid.delete();

}

if (isObject(%this.GuiControl_Player_Sprite_Select))
{

%this.GuiControl_Player_Sprite_Select.deleteObjects();

%this.GuiControl_Player_Sprite_Select.delete();

}

if (isObject(%this.GuiButtonCtrl_Main_Menu))
{

%this.GuiButtonCtrl_Main_Menu.deleteObjects();

%this.GuiButtonCtrl_Main_Menu.delete();

}

if (isObject(%this.GuiControl_Object_Select))
{

%this.GuiControl_Object_Select.deleteObjects();

%this.GuiControl_Object_Select.delete();

}

}
