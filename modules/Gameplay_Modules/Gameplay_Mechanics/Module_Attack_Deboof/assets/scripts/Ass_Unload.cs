function Module_Attack_Deboof::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Attack_Deboof))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Attack_Deboof.getAssetId());

}

}
