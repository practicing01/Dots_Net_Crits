function Module_NPC_Medic::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Medic))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Medic.getAssetId());

}

if (isObject(%this.Ass_Image_Medic_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Medic_Attack.getAssetId());

}

if (isObject(%this.Image_Medic_Cast))
{

AssetDatabase.releaseAsset(%this.Image_Medic_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
