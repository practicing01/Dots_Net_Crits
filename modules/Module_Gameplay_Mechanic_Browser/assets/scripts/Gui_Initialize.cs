function Module_Gameplay_Mechanic_Browser::Gui_Initialize(%this)
{

//Search for gameplay mechanic modules and populate the browser.

if (isObject(%this.SimSet_Gameplay_Mechanic_Module_Groups))
{

%this.SimSet_Gameplay_Mechanic_Module_Groups.deleteObjects();

}

if (isObject(GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List))
{

GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.deleteObjects();

}

%String_Gameplay_Mechanic_Modules=ModuleDatabase.findModuleTypes("Gameplay_Mechanic",false);

if (isObject(%this.SimSet_Gameplay_Mechanic_Modules))
{

%this.SimSet_Gameplay_Mechanic_Modules.deleteObjects();

}

%Int_Module_Count=getWordCount(%String_Gameplay_Mechanic_Modules);

for (%x=0;%x<%Int_Module_Count;%x++)
{

%Module_ID_Gameplay_Mechanic_Module=getWord(%String_Gameplay_Mechanic_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Gameplay_Mechanic_Module.ModuleId);

%ScriptObject_Gameplay_Mechanic_Module=new ScriptObject()
{

Module_ID_Gameplay_Mechanic_Module=%Module_ID_Gameplay_Mechanic_Module.ModuleId;

String_Description=%Module_ID_Gameplay_Mechanic_Module.Description;

Group=%Module_ID_Gameplay_Mechanic_Module.Group;

Int_List_Index=-1;

};

%this.SimSet_Gameplay_Mechanic_Modules.add(%ScriptObject_Gameplay_Mechanic_Module);

ModuleDatabase.unloadExplicit(%Module_ID_Gameplay_Mechanic_Module.ModuleId);

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

Profile="blackButtonProfile";
class="Class_GuiButtonCtrl_Gameplay_Mechanic_Browser_Group";
String_Group=%ScriptObject_Gameplay_Mechanic_Module.Group;
Text=%ScriptObject_Gameplay_Mechanic_Module.Group;
ButtonType="PushButton";
HorizSizing="relative";
VertSizing="relative";
//Position="0 0";
Extent="50 50";
MinExtent="1 1";
useMouseEvents="1";

};

GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.add(%GuiButtonCtrl_Group);

GuiScrollCtrl_Gameplay_Mechanic_Tab_List.computeSizes();

}

}

}
