function Module_Lobby::Load_Gameplay(%this,%Module_ID_Gameplay_Module)
{

for (%x=0;%x<%this.SimSet_Gameplay_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Module=%this.SimSet_Gameplay_Modules.getObject(%x);

//Potential bug to use $= instead of ==?
if (%ScriptObject_Gameplay_Module.Module_ID_Gameplay_Module$=%Module_ID_Gameplay_Module)
{

cancel(%this.Schedule_Rotate_Stars);

%this.GuiControl_Lobby.Visible=false;

ModuleDatabase.LoadExplicit(%Module_ID_Gameplay_Module);

%Module_ID_Gameplay_Module.Scene_Load();

%this.Module_ID_Gameplay_Module=%Module_ID_Gameplay_Module;

return;

}

}

//Disconnect from server because we don't have the gameplay module.

%this.Go_Main_Menu();

}
