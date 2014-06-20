function Class_Gameplay_Object_Controller_Button::onAction(%this)
{

if (%this.String_Type$="Show")
{

if (!%this.Module_ID_Parent.GuiControl_Controller.Visible)
{

%this.Module_ID_Parent.GuiControl_Controller.Active=true;

%this.Module_ID_Parent.GuiControl_Controller.Visible=true;

}
else
{

%this.Module_ID_Parent.GuiControl_Controller.Active=false;

%this.Module_ID_Parent.GuiControl_Controller.Visible=false;

}

}
else if (%this.String_Type$="Pick")
{

%this.Module_ID_Parent.Bool_Targeting_Object=true;

}
else if (%this.String_Type$="Execute")
{

if (isObject(%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic))
{

%this.Module_ID_Parent.Picked_Object.Module_ID_Parent.Object_Mechanic_Execute(
%this.Module_ID_Parent.Picked_Object,%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.String_Mechanic);

return;

}

}

}
