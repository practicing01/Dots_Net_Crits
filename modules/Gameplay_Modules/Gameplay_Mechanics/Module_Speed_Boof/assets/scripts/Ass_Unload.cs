function Module_Speed_Boof::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Speed_Boof))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Speed_Boof.getAssetId());

}

}
