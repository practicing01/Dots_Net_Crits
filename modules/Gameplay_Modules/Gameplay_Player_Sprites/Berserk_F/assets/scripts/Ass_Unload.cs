function Module_Berserk_F::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Berserk_F))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Berserk_F.getAssetId());

}

if (isObject(%this.Ass_Image_Berserk_F_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Berserk_F_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Berserk_F_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Berserk_F_Cast.getAssetId());

}

}
