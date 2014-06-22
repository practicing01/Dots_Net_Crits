function Module_Gameplay_Mechanic_Browser::Gui_Unload(%this)
{

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

if (isObject(%this.GuiControl_Browser))
{

%this.GuiControl_Browser.deleteObjects();

%this.GuiControl_Browser.delete();

}

if (isObject(%this.GuiButtonCtrl_Show))
{

%this.GuiButtonCtrl_Show.deleteObjects();

%this.GuiButtonCtrl_Show.delete();

}

%this.Ass_Unload();

}
