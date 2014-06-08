function Class_Gameplay_Mechanic_Browser_Button::onAction(%this)
{

if (%this.String_Type$="Minimize")
{

//%this.getParent().Active=false;

//%this.getParent().Visible=false;

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Visible=true;

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Active=true;

}
else if (%this.String_Type$="Show")
{

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Visible=false;

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Active=false;

if (!Gui_Gameplay_Mechanic_Browser.Visible)
{

Gui_Gameplay_Mechanic_Browser.Active=true;

Gui_Gameplay_Mechanic_Browser.Visible=true;

}
else
{

Gui_Gameplay_Mechanic_Browser.Active=false;

Gui_Gameplay_Mechanic_Browser.Visible=false;

}

}
else if (%this.String_Type$="Execute")
{

if (isObject(Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic))
{

if (!Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic.Bool_Loaded)
{

ModuleDatabase.LoadExplicit(Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic);

Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic.Mechanic_Load();

Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic.Bool_Loaded=true;

commandToServer('Relay_Module_Function',Module_Gameplay_Mechanic_Browser,"Load_Gameplay_Mechanic",Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic);

}

Module_Gameplay_Mechanic_Browser.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic.Mechanic_Execute();

}

}

}
