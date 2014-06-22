function Class_Gameplay_Mechanic_Browser_Button::onAction(%this)
{

if (%this.String_Type$="Show")
{

%this.Module_ID_Parent.Gui_Toggle();

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
