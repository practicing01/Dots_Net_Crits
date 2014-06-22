function Class_Gameplay_Object_Controller_Button::onAction(%this)
{

if (%this.String_Type$="Show")
{

%this.Module_ID_Parent.Gui_Toggle();

}
else if (%this.String_Type$="Pick")
{

%this.Module_ID_Parent.Bool_Targeting_Object=true;

}
else if (%this.String_Type$="Update_Statistics")
{



}
else if (%this.String_Type$="Update_All_Statistics")
{



}
else if (%this.String_Type$="Execute")
{

if (isObject(%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic)&&isObject(%this.Module_ID_Parent.Picked_Object))
{

%this.Module_ID_Parent.Picked_Object.Module_ID_Parent.Object_Mechanic_Execute(
%this.Module_ID_Parent.Picked_Object,%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.String_Mechanic);

return;

}

}

}
