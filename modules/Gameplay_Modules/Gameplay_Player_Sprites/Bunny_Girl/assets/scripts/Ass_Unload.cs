function Module_Bunny_Girl::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Bunny_Girl))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bunny_Girl.getAssetId());

}

if (isObject(%this.Ass_Image_Bunny_Girl_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bunny_Girl_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Bunny_Girl_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bunny_Girl_Cast.getAssetId());

}

}
