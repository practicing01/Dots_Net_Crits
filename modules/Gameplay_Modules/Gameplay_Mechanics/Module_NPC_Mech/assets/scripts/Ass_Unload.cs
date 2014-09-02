function Module_NPC_Mech::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Mech))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Mech.getAssetId());

}

if (isObject(%this.Ass_Image_Mech_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Mech_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Mech_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Mech_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
