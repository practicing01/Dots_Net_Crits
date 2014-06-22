function Module_Snare::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Snare))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Snare.getAssetId());

}

}
