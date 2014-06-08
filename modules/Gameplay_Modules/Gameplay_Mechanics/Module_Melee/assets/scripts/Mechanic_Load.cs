exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Mechanic_Initialize.cs");
exec("./Mechanic_Execute.cs");

function Module_Melee::Mechanic_Load(%this)
{

%this.Ass_Load();

%this.Variables_Initialize();

%this.Mechanic_Initialize();

}
