function Module_Explosion::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Explosion))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Explosion.getAssetId());

}

}
