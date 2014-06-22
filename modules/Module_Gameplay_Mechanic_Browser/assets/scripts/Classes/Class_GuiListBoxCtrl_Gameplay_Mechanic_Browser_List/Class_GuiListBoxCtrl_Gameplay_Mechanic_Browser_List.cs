function Class_GuiListBoxCtrl_Gameplay_Mechanic_Browser_List::onSelect(%this)
{

%Int_Index=%this.getSelectedItem();

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

if (%ScriptObject_Gameplay_Mechanic_Module.Int_List_Index==%Int_Index)
{

%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic=%ScriptObject_Gameplay_Mechanic_Module;

}

}

}
