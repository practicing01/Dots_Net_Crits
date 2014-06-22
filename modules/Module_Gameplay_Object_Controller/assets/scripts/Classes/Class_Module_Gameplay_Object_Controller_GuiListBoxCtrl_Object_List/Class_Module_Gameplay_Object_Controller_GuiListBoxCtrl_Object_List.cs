function Class_Module_Gameplay_Object_Controller_GuiListBoxCtrl_Object_List::onDoubleClick(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

%this.Module_ID_Parent.Highlighted_Object=0;

}

%this.Module_ID_Parent.Picked_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Bool_Targeting_Object=false;

//Populate mechanic list.

%this.Module_ID_Parent.Clear_Gameplay_Mechanics();

if (isObject(%this.Module_ID_Parent.Picked_Object.SimSet_Mechanics))
{

for (%x=0;%x<%this.Module_ID_Parent.Picked_Object.SimSet_Mechanics.getCount();%x++)
{

%ScriptObject_Mechanic=%this.Module_ID_Parent.Picked_Object.SimSet_Mechanics.getObject(%x);

%ScriptObject_Mechanic_Copy=new ScriptObject()
{

String_Group=%ScriptObject_Mechanic.String_Group;

String_Mechanic=%ScriptObject_Mechanic.String_Mechanic;

};

%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Modules.add(%ScriptObject_Mechanic_Copy);

%Bool_Group_Exists=false;

for (%y=0;%y<%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Module_Groups.getCount();%y++)
{

%ScriptObject_Module_Group=%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Module_Groups.getObject(%y);

if (%ScriptObject_Module_Group.String_Group$=%ScriptObject_Mechanic_Copy.String_Group)
{

%Bool_Group_Exists=true;

break;

}

}

if (!%Bool_Group_Exists)
{

%ScriptObject_Module_Group=new ScriptObject()
{

String_Group=%ScriptObject_Mechanic_Copy.String_Group;

};

%this.Module_ID_Parent.SimSet_Gameplay_Mechanic_Module_Groups.add(%ScriptObject_Module_Group);

//Add group button to browser.

%GuiButtonCtrl_Group=new GuiButtonCtrl()
{

Profile="Blue_0ButtonProfile";
class="Class_GuiButtonCtrl_Gameplay_Object_Controller_Group";
String_Group=%ScriptObject_Mechanic_Copy.String_Group;
Text=%ScriptObject_Mechanic_Copy.String_Group;
ButtonType="PushButton";
HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
MinExtent="1 1";
useMouseEvents="1";

Module_ID_Parent=%this.Module_ID_Parent;

};

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.add(%GuiButtonCtrl_Group);

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List->GuiDynamicCtrlArrayControl_Gameplay_Mechanic_Tab_List.Extent.X+=80;

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Gameplay_Mechanic_Controller->GuiSpriteCtrl_Gameplay_Mechanic_Tab_List->GuiScrollCtrl_Gameplay_Mechanic_Tab_List.computeSizes();

}

}

}

//Populate statistics.

//Base statistics.

%GuiTextCtrl_Health=new GuiTextCtrl()
{

Profile="GuiTextProfile";
Text="Health:" SPC %this.Module_ID_Parent.Picked_Object.Int_Health;
HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
MinExtent="1 1";

Module_ID_Parent=%this.Module_ID_Parent;

};

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Object_Status->GuiSpriteCtrl_Object_Status_List->GuiScrollCtrl_Object_Base_Status_List->GuiDynamicCtrlArrayControl_Object_Base_Status_List.add(%GuiTextCtrl_Health);

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Object_Status->GuiSpriteCtrl_Object_Status_List->GuiScrollCtrl_Object_Base_Status_List->GuiDynamicCtrlArrayControl_Object_Base_Status_List.Extent.X+=80;

%GuiTextCtrl_Speed=new GuiTextCtrl()
{

Profile="GuiTextProfile";
Text="Speed:" SPC %this.Module_ID_Parent.Picked_Object.Int_Current_Speed;
HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
MinExtent="1 1";

Module_ID_Parent=%this.Module_ID_Parent;

};

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Object_Status->GuiSpriteCtrl_Object_Status_List->GuiScrollCtrl_Object_Base_Status_List->GuiDynamicCtrlArrayControl_Object_Base_Status_List.add(%GuiTextCtrl_Speed);

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Object_Status->GuiSpriteCtrl_Object_Status_List->GuiScrollCtrl_Object_Base_Status_List->GuiDynamicCtrlArrayControl_Object_Base_Status_List.Extent.X+=80;

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Object_Status->GuiSpriteCtrl_Object_Status_List->GuiScrollCtrl_Object_Base_Status_List.computeSizes();

//Dynamic statistics.

for (%x=0;%x<%this.Module_ID_Parent.Picked_Object.SimSet_Status.getCount();%x++)
{

%ScriptObject_Status=%this.Module_ID_Parent.Picked_Object.SimSet_Status.getObject(%x);

%this.Module_ID_Parent.GuiControl_Controller->GuiDragAndDropControl_Object_Status->GuiSpriteCtrl_Object_Status_List->GuiScrollCtrl_Object_Status_List->
GuiListBoxCtrl_Object_Status_List.addItem(%ScriptObject_Status.String_Status);

}

Gui_Dots_Net_Crits_Overlay.remove(%this.Module_ID_Parent.Gui_Object_List);

}

function Class_Module_Gameplay_Object_Controller_GuiListBoxCtrl_Object_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.Highlighted_Object))
{

%this.Module_ID_Parent.Highlighted_Object.BlendColor=%this.Module_ID_Parent.Highlighted_Object_BlendColor;

}

%this.Module_ID_Parent.Highlighted_Object=%this.Module_ID_Parent.SimSet_Picked_Object_List.getObject(%this.getSelectedItem());

%this.Module_ID_Parent.Highlighted_Object_BlendColor=%this.Module_ID_Parent.Highlighted_Object.BlendColor;

%this.Module_ID_Parent.Highlighted_Object.BlendColor="0.5 1.0 1.0 1.0";

}
