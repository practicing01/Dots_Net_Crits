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

if (%ScriptObject_Gameplay_Mechanic_Module.Bool_Loaded)
{

ModuleDatabase.unloadExplicit(%ScriptObject_Gameplay_Mechanic_Module.ModuleId);

}

}

%this.SimSet_Gameplay_Mechanic_Modules.deleteObjects();

%this.SimSet_Gameplay_Mechanic_Modules.delete();

}

//Canvas.popDialog(Gui_Gameplay_Mechanic_Browser);

Gui_Dots_Net_Crits_Overlay.remove(Gui_Gameplay_Mechanic_Browser);

Gui_Dots_Net_Crits_Overlay.remove(GuiButtonCtrl_Gameplay_Mechanic_Browser_Show);

%this.Ass_Unload();

}
