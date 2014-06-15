function Module_Cloak::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Cloak))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Cloak.getAssetId());

}

}
