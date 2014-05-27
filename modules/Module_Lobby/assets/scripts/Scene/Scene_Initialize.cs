function Module_Lobby::Scene_Initialize(%this)
{

//Register the lobby for client synchronization.

if (!Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.isMember(%this))
{

Dots_Net_Crits.SimSet_Modules_That_Synchronize_Clients.add(%this);

}

//Populate the connected clients list.

%this.Populate_Connected_Clients_List();

//Search for gameplay modules and populate the list.

Gui_List_Gameplay_Modules.clearItems();

%String_Gameplay_Modules=ModuleDatabase.findModuleTypes("Gameplay_Module",false);

if (isObject(%this.SimSet_Gameplay_Modules))
{

%this.SimSet_Gameplay_Modules.deleteObjects();

}

%Int_Module_Count=getWordCount(%String_Gameplay_Modules);

for (%x=0;%x<%Int_Module_Count;%x++)
{

%Module_ID_Gameplay_Module=getWord(%String_Gameplay_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Gameplay_Module.ModuleId);

%ScriptObject_Gameplay_Module=new ScriptObject()
{

Module_ID_Gameplay_Module=%Module_ID_Gameplay_Module.ModuleId;

String_Description=%Module_ID_Gameplay_Module.Description;

};

%this.SimSet_Gameplay_Modules.add(%ScriptObject_Gameplay_Module);

Gui_List_Gameplay_Modules.addItem(%Module_ID_Gameplay_Module.Description);

ModuleDatabase.unloadExplicit(%Module_ID_Gameplay_Module.ModuleId);

}

//Generate trigonometry tables.

for (%x=0;%x<360;%x++)
{

%ScriptObject_Theta_Sine=new ScriptObject()
{

Theta_Sine=mSin(%x);

};

%this.SimSet_Sine_Table.add(%ScriptObject_Theta_Sine);

%ScriptObject_Theta_Cosine=new ScriptObject()
{

Theta_Cosine=mCos(%x);

};

%this.SimSet_Cosine_Table.add(%ScriptObject_Theta_Cosine);

}

//Spawn stars.

%Vector_2D_World_Position="0 0";

for (%x=0;%x<360;%x+=45)
{

%Float_Angle=%x;

%Vector_2D_World_Position=Vector2Direction(%Float_Angle,%this.Float_Magnitude);

%Sprite_Star=new Sprite()
{

Position=%Vector_2D_World_Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Star);
Image="Module_Lobby:Image_Star";
SceneLayer=16;
class="Class_Lobby_Star";
Module_ID_Parent=%this;
BlendColor="0 0.5 1 0.5";

Z=0;

Vector_2D_Position=%Vector_2D_World_Position;

};

%this.SimSet_Stars.add(%Sprite_Star);

Scene_Dots_Net_Crits.add(%Sprite_Star);

}

exec("./Schedule_Rotate_Stars.cs");

%this.Schedule_Rotate_Stars();

}
