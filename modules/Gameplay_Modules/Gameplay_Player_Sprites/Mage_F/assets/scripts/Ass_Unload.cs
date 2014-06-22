function Module_Mage_F::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Mage_F))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Mage_F.getAssetId());

}

if (isObject(%this.Ass_Image_Mage_F_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Mage_F_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Mage_F_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Mage_F_Cast.getAssetId());

}

}
