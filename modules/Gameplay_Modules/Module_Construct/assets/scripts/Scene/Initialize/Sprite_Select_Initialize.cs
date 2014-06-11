function Module_Construct::Sprite_Select_Initialize(%this)
{

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Player_Sprite_Select);

//Populate player sprite list.

%this.GuiControl_Player_Sprite_Select->GuiScrollCtrl_Player_Sprite_List->GuiListBoxCtrl_Player_Sprite_List.clearItems();

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

ScriptObject_Sprite_Data=0;

};

%this.SimSet_Player_Sprite_Modules.add(%ScriptObject_Player_Sprite_Module);

%this.GuiControl_Player_Sprite_Select->GuiScrollCtrl_Player_Sprite_List->GuiListBoxCtrl_Player_Sprite_List.addItem(%Module_ID_Player_Sprite_Module.Description);

ModuleDatabase.unloadExplicit(%Module_ID_Player_Sprite_Module.ModuleId);

}

/****/

%this.Sprite_Player_Sprite_Preview=new Sprite()
{

Position=SceneWindow_Dots_Net_Crits.getCameraSize().X*0.25 SPC 0;

//Size=SceneWindow_Dots_Net_Crits.getCameraSize().X*0.5 SPC SceneWindow_Dots_Net_Crits.getCameraSize().Y*0.5;

Visible=false;

};

Scene_Dots_Net_Crits.add(%this.Sprite_Player_Sprite_Preview);

}
