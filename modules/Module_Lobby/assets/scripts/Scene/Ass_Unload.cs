function Module_Lobby::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Star))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Star.getAssetId());

}

}
