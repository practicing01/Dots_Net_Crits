function Module_Construct::Gui_Toggle(%this)
{

//%this.Toggle_Deaths_Visibility();

if (isObject(Module_Gameplay_Mechanic_Browser))
{

Module_Gameplay_Mechanic_Browser.Gui_Toggle();

}

if (isObject(Module_Gameplay_Object_Controller))
{

Module_Gameplay_Object_Controller.Gui_Toggle();

}

}
