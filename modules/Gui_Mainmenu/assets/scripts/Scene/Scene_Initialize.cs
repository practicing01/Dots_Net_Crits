function Module_Gui_Main_Menu::Scene_Initialize(%this)
{

%Sprite_BG_Render=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_BG_Render);
Image="Module_Gui_Main_Menu:Image_BG_Render";

BodyType="static";

};

Scene_Dots_Net_Crits.add(%Sprite_BG_Render);

ModuleDatabase.LoadExplicit("Module_Master_Server");

ModuleDatabase.LoadExplicit("Module_Server");

ModuleDatabase.LoadExplicit("Module_Lobby");

}
