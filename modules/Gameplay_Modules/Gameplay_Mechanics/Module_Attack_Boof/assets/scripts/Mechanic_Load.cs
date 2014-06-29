exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Mechanic_Initialize.cs");
exec("./Mechanic_Execute.cs");
exec("./Classes/Classes.cs");
exec("./Synchronize_Clients.cs");
exec("./Synchronize_Module_Data.cs");
exec("./Relay_Module_Function/Relay_Module_Function.cs");
exec("./Mechanics/Mechanics.cs");

function Module_Attack_Boof::Mechanic_Load(%this)
{

%this.Ass_Load();

%this.Variables_Initialize();

%this.Mechanic_Initialize();

}
