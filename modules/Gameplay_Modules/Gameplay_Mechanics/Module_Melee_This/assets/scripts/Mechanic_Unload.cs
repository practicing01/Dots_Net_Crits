function Module_Melee_This::Mechanic_Unload(%this)
{

if (isObject(%this.Simset_Client_List))
{

%this.Simset_Client_List.deleteObjects();

%this.Simset_Client_List.delete();

}

if (Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.isMember(%this))
{

Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.remove(%this);

}

if (isObject(%this.Script_Object_Input_Controller))
{

SceneWindow_Dots_Net_Crits.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

if (isObject(%this.SimSet_Picked_Object_List))
{

%this.SimSet_Picked_Object_List.delete();

}

if (isObject(%this.Gui_Object_List))
{

%this.Gui_Object_List.delete();

}

%this.Ass_Unload();

}
