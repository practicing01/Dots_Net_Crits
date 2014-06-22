function Module_Sara::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Sara))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Sara.getAssetId());

}

}
