function Class_GuiListBoxCtrl_Gameplay_Mechanic_List::onSelect(%this)
{

%Int_Index=%this.getSelectedItem();

for (%x=0;%x<Module_Gameplay_Mechanic_Browser.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=Module_Gameplay_Mechanic_Browser.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

if (%ScriptObject_Gameplay_Mechanic_Module.Int_List_Index==%Int_Index)
{

Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic=%ScriptObject_Gameplay_Mechanic_Module;

}

}

}
