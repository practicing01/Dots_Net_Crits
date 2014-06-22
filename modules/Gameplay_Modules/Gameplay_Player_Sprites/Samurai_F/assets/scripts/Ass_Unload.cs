function Module_Samurai_F::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Samurai_F))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Samurai_F.getAssetId());

}

if (isObject(%this.Ass_Image_Samurai_F_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Samurai_F_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Samurai_F_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Samurai_F_Cast.getAssetId());

}

}
