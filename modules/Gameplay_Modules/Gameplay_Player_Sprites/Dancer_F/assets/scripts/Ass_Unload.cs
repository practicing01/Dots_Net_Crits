function Module_Dancer_F::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Dancer_F))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Dancer_F.getAssetId());

}

if (isObject(%this.Ass_Image_Dancer_F_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Dancer_F_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Dancer_F_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Dancer_F_Cast.getAssetId());

}

}
