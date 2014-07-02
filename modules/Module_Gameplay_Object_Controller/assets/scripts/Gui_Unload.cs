function Module_Gameplay_Object_Controller::Gui_Unload(%this)
{

%this.ActionMap_Pick_Object.pop();

if (isObject(%this.SimSet_Gameplay_Mechanic_Module_Groups))
{

%this.SimSet_Gameplay_Mechanic_Module_Groups.deleteObjects();

%this.SimSet_Gameplay_Mechanic_Module_Groups.delete();

}

if (isObject(%this.SimSet_Gameplay_Mechanic_Modules))
{

for (%x=0;%x<%this.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=%this.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

if (%ScriptObject_Gameplay_Mechanic_Module.Bool_Loaded&&isObject(%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic))
{

ModuleDatabase.unloadExplicit(%ScriptObject_Gameplay_Mechanic_Module.Module_ID_Gameplay_Mechanic);

}

}

%this.SimSet_Gameplay_Mechanic_Modules.deleteObjects();

%this.SimSet_Gameplay_Mechanic_Modules.delete();

}

if (isObject(%this.GuiControl_Controller))
{

%this.GuiControl_Controller.deleteObjects();

%this.GuiControl_Controller.delete();

}

if (isObject(%this.GuiButtonCtrl_Show))
{

%this.GuiButtonCtrl_Show.deleteObjects();

%this.GuiButtonCtrl_Show.delete();

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

if (isObject(%this.Gui_Object_List))
{

%this.Gui_Object_List.delete();

}

%this.Ass_Unload();

}
