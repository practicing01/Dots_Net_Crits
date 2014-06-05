function Module_Construct::Sprite_Select_Initialize(%this)
{

Dots_Net_Crits.add(TamlRead("./../../../Gui/Gui_Player_Sprite_Select.gui.taml"));

Canvas.pushDialog(Gui_Player_Sprite_Select);

//Populate player sprite list.

Gui_List_Player_Sprite_List.clearItems();

%String_Player_Sprite_Modules=ModuleDatabase.findModuleTypes("Gameplay_Player_Sprite",false);

if (isObject(%this.SimSet_Player_Sprite_Modules))
{

%this.SimSet_Player_Sprite_Modules.deleteObjects();

}

%Int_Module_Count=getWordCount(%String_Player_Sprite_Modules);

for (%x=0;%x<%Int_Module_Count;%x++)
{

%Module_ID_Player_Sprite_Module=getWord(%String_Player_Sprite_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite_Module.ModuleId);

%ScriptObject_Player_Sprite_Module=new ScriptObject()
{

Module_ID_Player_Sprite_Module=%Module_ID_Player_Sprite_Module.ModuleId;

String_Description=%Module_ID_Player_Sprite_Module.Description;

};

%this.SimSet_Player_Sprite_Modules.add(%ScriptObject_Player_Sprite_Module);

Gui_List_Player_Sprite_List.addItem(%Module_ID_Player_Sprite_Module.Description);

ModuleDatabase.unloadExplicit(%Module_ID_Player_Sprite_Module.ModuleId);

}

}