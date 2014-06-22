function Module_Raven::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Raven))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Raven.getAssetId());

}

}
