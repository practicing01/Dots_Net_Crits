function Module_Construct::Select_Player_Sprite(%this,%GameConnection_Client_Sender,%Module_ID_Player_Sprite_Module)
{

for (%x=0;%x<%this.Simset_Client_List.getCount();%x++)
{

%ScriptObject_Client_Copy=%this.Simset_Client_List.getObject(%x);

if (%ScriptObject_Client_Copy.GameConnection_Handle==%GameConnection_Client_Sender)
{

%ScriptObject_Client_Copy.Module_ID_Player_Sprite_Module=%Module_ID_Player_Sprite_Module;

//Load player sprite.

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite_Module);

%ScriptObject_Client_Copy.ScriptObject_Player_Sprite_Data=%Module_ID_Player_Sprite_Module.Player_Sprite_Load();

%ScriptObject_Client_Copy.Sprite_Player_Sprite=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X*0.5
SPC
%this.Vector_2D_World_Limits.Y*0.5;

Size=%ScriptObject_Client_Copy.ScriptObject_Player_Sprite_Data.Vector_2D_Size;

Animation=%ScriptObject_Client_Copy.ScriptObject_Player_Sprite_Data.Animation_Stand_Down;

SceneLayer=16;

Module_ID_Parent=%this;

ScriptObject_Client_Parent=%ScriptObject_Client_Copy;

class="Class_Player_Sprite";

SceneGroup=0;

Collision_Shape_Index=-1;

String_Name=%ScriptObject_Client_Copy.Connector_Name;

};

%ScriptObject_Client_Copy.Sprite_Player_Sprite.Collision_Shape_Index=%ScriptObject_Client_Copy.Sprite_Player_Sprite.createPolygonBoxCollisionShape(%ScriptObject_Client_Copy.Sprite_Player_Sprite.Size);

//%ScriptObject_Client_Copy.Sprite_Player_Sprite.setUseInputEvents(true);

Scene_Dots_Net_Crits.add(%ScriptObject_Client_Copy.Sprite_Player_Sprite);

//Close player sprite select gui and load map.

if (%ScriptObject_Client_Copy.GameConnection_Handle==Dots_Net_Crits.GameConnection_Client_Connection_Server_Side)
{

Canvas.popDialog(Gui_Player_Sprite_Select);

%this.Sprite_Player_Sprite_Preview.safeDelete();

%this.World_Limits_Initialize();

%this.Floor_Initialize();

ModuleDatabase.LoadExplicit(Module_Gameplay_Mechanic_Browser);

Module_Gameplay_Mechanic_Browser.Gui_Load();

}

break;

}

}

}
