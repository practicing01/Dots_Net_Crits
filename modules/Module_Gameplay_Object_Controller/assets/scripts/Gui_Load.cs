exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Gui_Initialize.cs");
exec("./Classes/Classes.cs");
exec("./Controller/Controller.cs");
exec("./Relay_Module_Function/Relay_Module_Function.cs");

function Module_Gameplay_Object_Controller::Gui_Load(%this)
{

%this.Ass_Load();

%this.Variables_Initialize();

%this.Gui_Initialize();

}
