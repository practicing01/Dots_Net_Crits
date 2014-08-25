function Module_Bard::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Bard))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bard.getAssetId());

}

if (isObject(%this.Ass_Image_Bard_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bard_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Bard_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bard_Cast.getAssetId());

}

}
