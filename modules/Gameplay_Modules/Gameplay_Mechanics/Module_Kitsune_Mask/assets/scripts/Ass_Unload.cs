function Module_Kitsune_Mask::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Kitsune_Mask))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Kitsune_Mask.getAssetId());

}

}
