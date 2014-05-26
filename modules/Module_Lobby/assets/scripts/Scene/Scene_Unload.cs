function Module_Lobby::Scene_Unload(%this)
{

if (isObject(%this.SimSet_Gameplay_Modules))
{

%this.SimSet_Gameplay_Modules.deleteObjects();

%this.SimSet_Gameplay_Modules.delete();

}

if (isObject(%this.Simset_Client_List))
{

%this.Simset_Client_List.deleteObjects();

%this.Simset_Client_List.delete();

}

cancel(%this.Schedule_Rotate_Stars);

%this.SimSet_Stars.deleteObjects();

%this.SimSet_Stars.delete();

%this.SimSet_Sine_Table.deleteObjects();

%this.SimSet_Sine_Table.delete();

%this.SimSet_Cosine_Table.deleteObjects();

%this.SimSet_Cosine_Table.delete();

Canvas.popDialog(Gui_Lobby);

%this.Ass_Unload();

}
