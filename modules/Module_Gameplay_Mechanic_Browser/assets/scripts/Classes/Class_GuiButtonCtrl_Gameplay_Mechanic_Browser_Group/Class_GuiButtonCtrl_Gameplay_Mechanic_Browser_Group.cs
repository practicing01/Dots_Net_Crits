function Class_GuiButtonCtrl_Gameplay_Mechanic_Browser_Group::onAction(%this)
{

%this.Module_ID_Parent.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.clearItems();

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Mechanic_Module=%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

%ScriptObject_Gameplay_Mechanic_Module.Int_List_Index=-1;

if (%ScriptObject_Gameplay_Mechanic_Module.Group$=%this.String_Group)
{

%this.Module_ID_Parent.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.addItem(%ScriptObject_Gameplay_Mechanic_Module.String_Description);

%ScriptObject_Gameplay_Mechanic_Module.Int_List_Index=%this.Module_ID_Parent.GuiControl_Browser->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.getItemCount()-1;

}

}

}
