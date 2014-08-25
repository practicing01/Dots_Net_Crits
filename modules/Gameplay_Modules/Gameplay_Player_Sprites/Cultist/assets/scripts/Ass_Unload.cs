function Module_Cultist::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Cultist))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Cultist.getAssetId());

}

if (isObject(%this.Ass_Image_Cultist_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Cultist_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Cultist_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Cultist_Cast.getAssetId());

}

}
