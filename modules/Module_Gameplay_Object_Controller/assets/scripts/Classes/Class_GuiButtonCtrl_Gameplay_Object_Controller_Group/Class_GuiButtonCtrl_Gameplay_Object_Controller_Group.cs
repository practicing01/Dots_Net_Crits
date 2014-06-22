function Class_GuiButtonCtrl_Gameplay_Object_Controller_Group::onAction(%this)
{

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.clearItems();

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.getCount();%x++)
{

%ScriptObject_Mechanic=%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.getObject(%x);

%ScriptObject_Mechanic.Int_List_Index=-1;

if (%ScriptObject_Mechanic.String_Group$=%this.String_Group)
{

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.addItem(%ScriptObject_Mechanic.String_Mechanic);

%ScriptObject_Mechanic.Int_List_Index=%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_List->GuiListBoxCtrl_Gameplay_Mechanic_List.getItemCount()-1;

}

}

}
