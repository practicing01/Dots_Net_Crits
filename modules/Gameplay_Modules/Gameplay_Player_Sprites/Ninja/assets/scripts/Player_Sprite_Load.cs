exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");

function Module_Ninja::Player_Sprite_Load(%this)
{

%this.Ass_Load();

%ScriptObject_Sprite_Data=new ScriptObject()
{

Vector_2D_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Ninja);

Animation_Stand_Up="Module_Ninja:Animation_Ninja_Stand_Up";

Animation_Stand_Down="Module_Ninja:Animation_Ninja_Stand_Down";

Animation_Stand_Left="Module_Ninja:Animation_Ninja_Stand_Left";

Animation_Stand_Right="Module_Ninja:Animation_Ninja_Stand_Right";

Animation_Run_Up="Module_Ninja:Animation_Ninja_Run_Up";

Animation_Run_Down="Module_Ninja:Animation_Ninja_Run_Down";

Animation_Run_Left="Module_Ninja:Animation_Ninja_Run_Left";

Animation_Run_Right="Module_Ninja:Animation_Ninja_Run_Right";

Animation_Attack_Up="Module_Ninja:Animation_Ninja_Attack_Up";

Animation_Attack_Down="Module_Ninja:Animation_Ninja_Attack_Down";

Animation_Attack_Left="Module_Ninja:Animation_Ninja_Attack_Left";

Animation_Attack_Right="Module_Ninja:Animation_Ninja_Attack_Right";

Animation_Cast_Up="Module_Ninja:Animation_Ninja_Cast_Up";

Animation_Cast_Down="Module_Ninja:Animation_Ninja_Cast_Down";

Animation_Cast_Left="Module_Ninja:Animation_Ninja_Cast_Left";

Animation_Cast_Right="Module_Ninja:Animation_Ninja_Cast_Right";

};

return %ScriptObject_Sprite_Data;

}
