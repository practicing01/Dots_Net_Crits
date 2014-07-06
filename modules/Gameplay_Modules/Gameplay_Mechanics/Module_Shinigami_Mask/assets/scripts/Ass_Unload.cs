function Module_Shinigami_Mask::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Shinigami_Mask))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Shinigami_Mask.getAssetId());

}

}
