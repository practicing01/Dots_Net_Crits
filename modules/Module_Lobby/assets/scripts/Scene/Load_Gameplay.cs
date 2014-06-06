function Module_Lobby::Load_Gameplay(%this,%Module_ID_Gameplay_Module)
{

for (%x=0;%x<%this.SimSet_Gameplay_Modules.getCount();%x++)
{

%ScriptObject_Gameplay_Module=%this.SimSet_Gameplay_Modules.getObject(%x);

//Potential bug to use $= instead of ==?
if (%ScriptObject_Gameplay_Module.Module_ID_Gameplay_Module$=%Module_ID_Gameplay_Module)
{

cancel(%this.Schedule_Rotate_Stars);

Canvas.popDialog(Gui_Lobby);

ModuleDatabase.LoadExplicit(%Module_ID_Gameplay_Module);

%Module_ID_Gameplay_Module.Scene_Load();

return;

}

}

//Disconnect from server because we don't have the gameplay module.

Gui_Lobby.Go_Main_Menu();

}
