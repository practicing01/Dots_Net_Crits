function Module_Ninja_F::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Ninja_F))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ninja_F.getAssetId());

}

if (isObject(%this.Ass_Image_Ninja_F_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ninja_F_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Ninja_F_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ninja_F_Cast.getAssetId());

}

}
