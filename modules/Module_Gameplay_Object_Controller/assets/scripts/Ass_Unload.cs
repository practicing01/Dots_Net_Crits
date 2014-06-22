function Module_Gameplay_Object_Controller::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Game_Mechanic_Controller))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Game_Mechanic_Controller.getAssetId());

}

if (isObject(%this.Ass_Image_Skull_Button))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Skull_Button.getAssetId());

}

}
