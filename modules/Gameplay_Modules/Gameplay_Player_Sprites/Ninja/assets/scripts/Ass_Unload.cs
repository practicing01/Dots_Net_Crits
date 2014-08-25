function Module_Ninja::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Ninja))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ninja.getAssetId());

}

if (isObject(%this.Ass_Image_Ninja_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ninja_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Ninja_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ninja_Cast.getAssetId());

}

}
