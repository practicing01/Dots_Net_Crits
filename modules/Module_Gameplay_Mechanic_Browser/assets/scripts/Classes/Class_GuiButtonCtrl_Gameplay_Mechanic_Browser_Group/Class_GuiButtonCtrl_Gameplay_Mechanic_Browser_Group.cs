function Class_GuiButtonCtrl_Gameplay_Mechanic_Browser_Group::onAction(%this)
{

GuiListBoxCtrl_Gameplay_Mechanic_List.clearItems();

for (%x=0;%x<Module_Gameplay_Mechanic_Browser.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=Module_Gameplay_Mechanic_Browser.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

%ScriptObject_Gameplay_Mechanic_Module.Int_List_Index=-1;

if (%ScriptObject_Gameplay_Mechanic_Module.Group$=%this.String_Group)
{

GuiListBoxCtrl_Gameplay_Mechanic_List.addItem(%ScriptObject_Gameplay_Mechanic_Module.String_Description);

%ScriptObject_Gameplay_Mechanic_Module.Int_List_Index=GuiListBoxCtrl_Gameplay_Mechanic_List.getItemCount()-1;

}

}

}
