exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");

function Module_Sara::Player_Sprite_Load(%this)
{

%this.Ass_Load();

%ScriptObject_Sprite_Data=new ScriptObject()
{

Vector_2D_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Sara);

Animation_Stand_Up="Module_Sara:Animation_Sara_Stand_Up";

Animation_Stand_Down="Module_Sara:Animation_Sara_Stand_Down";

Animation_Stand_Left="Module_Sara:Animation_Sara_Stand_Left";

Animation_Stand_Right="Module_Sara:Animation_Sara_Stand_Right";

Animation_Run_Up="Module_Sara:Animation_Sara_Run_Up";

Animation_Run_Down="Module_Sara:Animation_Sara_Run_Down";

Animation_Run_Left="Module_Sara:Animation_Sara_Run_Left";

Animation_Run_Right="Module_Sara:Animation_Sara_Run_Right";

Animation_Attack_Up="Module_Sara:Animation_Sara_Attack_Up";

Animation_Attack_Down="Module_Sara:Animation_Sara_Attack_Down";

Animation_Attack_Left="Module_Sara:Animation_Sara_Attack_Left";

Animation_Attack_Right="Module_Sara:Animation_Sara_Attack_Right";

Animation_Cast_Up="Module_Sara:Animation_Sara_Cast_Up";

Animation_Cast_Down="Module_Sara:Animation_Sara_Cast_Down";

Animation_Cast_Left="Module_Sara:Animation_Sara_Cast_Left";

Animation_Cast_Right="Module_Sara:Animation_Sara_Cast_Right";

};

return %ScriptObject_Sprite_Data;

}
