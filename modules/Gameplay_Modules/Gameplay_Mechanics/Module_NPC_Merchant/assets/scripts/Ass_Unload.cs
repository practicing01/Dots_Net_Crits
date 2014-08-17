function Module_NPC_Merchant::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Merchant))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Merchant.getAssetId());

}

if (isObject(%this.Ass_Image_Merchant_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Merchant_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Merchant_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Merchant_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
