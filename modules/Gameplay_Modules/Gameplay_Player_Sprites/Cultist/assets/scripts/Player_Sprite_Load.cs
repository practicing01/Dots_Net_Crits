exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");

function Module_Cultist::Player_Sprite_Load(%this)
{

%this.Ass_Load();

%ScriptObject_Sprite_Data=new ScriptObject()
{

Vector_2D_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Cultist);

Animation_Stand_Up="Module_Cultist:Animation_Cultist_Stand_Up";

Animation_Stand_Down="Module_Cultist:Animation_Cultist_Stand_Down";

Animation_Stand_Left="Module_Cultist:Animation_Cultist_Stand_Left";

Animation_Stand_Right="Module_Cultist:Animation_Cultist_Stand_Right";

Animation_Run_Up="Module_Cultist:Animation_Cultist_Run_Up";

Animation_Run_Down="Module_Cultist:Animation_Cultist_Run_Down";

Animation_Run_Left="Module_Cultist:Animation_Cultist_Run_Left";

Animation_Run_Right="Module_Cultist:Animation_Cultist_Run_Right";

Animation_Attack_Up="Module_Cultist:Animation_Cultist_Attack_Up";

Animation_Attack_Down="Module_Cultist:Animation_Cultist_Attack_Down";

Animation_Attack_Left="Module_Cultist:Animation_Cultist_Attack_Left";

Animation_Attack_Right="Module_Cultist:Animation_Cultist_Attack_Right";

Animation_Cast_Up="Module_Cultist:Animation_Cultist_Cast_Up";

Animation_Cast_Down="Module_Cultist:Animation_Cultist_Cast_Down";

Animation_Cast_Left="Module_Cultist:Animation_Cultist_Cast_Left";

Animation_Cast_Right="Module_Cultist:Animation_Cultist_Cast_Right";

};

return %ScriptObject_Sprite_Data;

}
