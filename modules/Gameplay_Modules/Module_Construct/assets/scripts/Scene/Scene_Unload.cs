function Module_Construct::Scene_Unload(%this)
{

if (isObject(Module_Gameplay_Mechanic_Browser))
{

ModuleDatabase.UnloadExplicit(Module_Gameplay_Mechanic_Browser);

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

if (isObject(Gui_Sprite_Select))
{

Canvas.popDialog(Gui_Sprite_Select);

}

}
