function Module_Gameplay_Mechanic_Browser::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Game_Mechanic_Browser))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Game_Mechanic_Browser.getAssetId());

}

if (isObject(%this.Ass_Image_Skull_Button))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Skull_Button.getAssetId());

}

}
