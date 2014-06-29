function Module_Attack_Boof::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Attack_Boof))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Attack_Boof.getAssetId());

}

}
