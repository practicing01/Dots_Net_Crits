function Class_Gui_List_Player_Sprite_List::onSelect(%this)
{

if (isObject(%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module))
{

%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.ScriptObject_Sprite_Data.delete();

ModuleDatabase.unloadExplicit(%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.Module_ID_Player_Sprite_Module);

}

%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module=%this.Module_ID_Parent.SimSet_Player_Sprite_Modules.getObject(%this.getSelectedItem());

ModuleDatabase.LoadExplicit(%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.Module_ID_Player_Sprite_Module);

%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.ScriptObject_Sprite_Data=
%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.Module_ID_Player_Sprite_Module.Player_Sprite_Load();

%this.Module_ID_Parent.Sprite_Player_Sprite_Preview.Visible=true;

%this.Module_ID_Parent.Sprite_Player_Sprite_Preview.Size=%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.ScriptObject_Sprite_Data.Vector_2D_Size;

%this.Module_ID_Parent.Sprite_Player_Sprite_Preview.Animation=%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.ScriptObject_Sprite_Data.Animation_Run_Down;

}
