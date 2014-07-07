function Module_Gameplay_Mechanic_Browser::Gui_Unload(%this)
{

if (isObject(%this.ActionMap_Binds))
{

%this.ActionMap_Binds.pop();

}

if (isObject(%this.SimSet_Binds))
{

%FileObject_Binds=new FileObject();

%FileObject_Binds.openForWrite("./Binds.txt");

for (%x=0;%x<%this.SimSet_Binds.getCount();%x++)
{

%ScriptObject_Bind=%this.SimSet_Binds.getObject(%x);

%FileObject_Binds.writeLine(%ScriptObject_Bind.String_Key);

%FileObject_Binds.writeLine(%ScriptObject_Bind.Module_ID);

}

%FileObject_Binds.close();

%this.SimSet_Binds.deleteObjects();

%this.SimSet_Binds.delete();

}

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
