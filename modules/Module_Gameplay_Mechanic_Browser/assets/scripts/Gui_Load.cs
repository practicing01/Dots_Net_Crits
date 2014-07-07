exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Bound_Execute.cs");
exec("./Variables_Initialize.cs");
exec("./Gui_Initialize.cs");
exec("./Classes/Classes.cs");
exec("./Browser/Browser.cs");
exec("./Relay_Module_Function/Relay_Module_Function.cs");

function Module_Gameplay_Mechanic_Browser::Gui_Load(%this)
{

%this.Ass_Load();

%this.Variables_Initialize();

%this.Gui_Initialize();

}
