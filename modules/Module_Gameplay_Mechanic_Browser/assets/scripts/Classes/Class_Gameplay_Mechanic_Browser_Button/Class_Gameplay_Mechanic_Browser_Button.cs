function Class_Gameplay_Mechanic_Browser_Button::onAction(%this)
{

if (%this.String_Type$="Show")
{

if (!%this.Module_ID_Parent.GuiControl_Browser.Visible)
{

%this.Module_ID_Parent.GuiControl_Browser.Active=true;

%this.Module_ID_Parent.GuiControl_Browser.Visible=true;

}
else
{

%this.Module_ID_Parent.GuiControl_Browser.Active=false;

%this.Module_ID_Parent.GuiControl_Browser.Visible=false;

}

}
else if (%this.String_Type$="Execute")
{

if (isObject(%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic))
{

if (!%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Bool_Loaded)
{

ModuleDatabase.LoadExplicit(%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic);

%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic.Mechanic_Load();

%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Bool_Loaded=true;

commandToServer('Relay_Module_Function',Module_Gameplay_Mechanic_Browser,"Load_Gameplay_Mechanic",%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic);

}

%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic.Mechanic_Execute();

}

}

}
