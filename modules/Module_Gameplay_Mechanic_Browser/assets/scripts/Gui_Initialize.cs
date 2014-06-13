function Module_Gameplay_Mechanic_Browser::Gui_Initialize(%this)
{

//Search for gameplay mechanic modules and populate the browser.

if (isObject(%this.SimSet_Gameplay_Mechanic_Module_Groups))
{

%this.SimSet_Gameplay_Mechanic_Module_Groups.deleteObjects();

}

if (isObject(%this.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List))
{

%this.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.deleteObjects();

}

%String_Gameplay_Mechanic_Modules=ModuleDatabase.findModuleTypes("Gameplay_Mechanic",false);

if (isObject(%this.SimSet_Gameplay_Mechanic_Modules))
{

%this.SimSet_Gameplay_Mechanic_Modules.deleteObjects();

}

%Int_Module_Count=getWordCount(%String_Gameplay_Mechanic_Modules);

for (%x=0;%x<%Int_Module_Count;%x++)
{

%Module_ID_Gameplay_Mechanic=getWord(%String_Gameplay_Mechanic_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Gameplay_Mechanic.ModuleId);

%ScriptObject_Gameplay_Mechanic_Module=new ScriptObject()
{

Module_ID_Gameplay_Mechanic=%Module_ID_Gameplay_Mechanic.ModuleId;

String_Description=%Module_ID_Gameplay_Mechanic.Description;

Group=%Module_ID_Gameplay_Mechanic.Group;

Int_List_Index=-1;

Bool_Loaded=false;

};

%this.SimSet_Gameplay_Mechanic_Modules.add(%ScriptObject_Gameplay_Mechanic_Module);

ModuleDatabase.unloadExplicit(%Module_ID_Gameplay_Mechanic.ModuleId);

//Check if this group is new.

%Bool_Group_Exists=false;

for (%y=0;%y<%this.SimSet_Gameplay_Mechanic_Module_Groups.getCount();%y++)
{

%ScriptObject_Module_Group=%this.SimSet_Gameplay_Mechanic_Module_Groups.getObject(%y);

if (%ScriptObject_Module_Group.Group$=%ScriptObject_Gameplay_Mechanic_Module.Group)
{

%Bool_Group_Exists=true;

break;

}

}

if (!%Bool_Group_Exists)
{

%ScriptObject_Module_Group=new ScriptObject()
{

Group=%ScriptObject_Gameplay_Mechanic_Module.Group;

};

%this.SimSet_Gameplay_Mechanic_Module_Groups.add(%ScriptObject_Module_Group);

//Add group button to browser.

%GuiButtonCtrl_Group=new GuiButtonCtrl()
{

Profile="Blue_0ButtonProfile";
class="Class_GuiButtonCtrl_Gameplay_Mechanic_Browser_Group";
String_Group=%ScriptObject_Gameplay_Mechanic_Module.Group;
Text=%ScriptObject_Gameplay_Mechanic_Module.Group;
ButtonType="PushButton";
HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
MinExtent="1 1";
useMouseEvents="1";

Module_ID_Parent=%this;

};

%this.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.add(%GuiButtonCtrl_Group);

%this.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.Extent.X+=80;

%this.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List.computeSizes();

}

}

}
