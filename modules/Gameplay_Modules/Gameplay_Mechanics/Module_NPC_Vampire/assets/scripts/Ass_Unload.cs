function Module_NPC_Vampire::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Vampire))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Vampire.getAssetId());

}

if (isObject(%this.Ass_Image_Vampire_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Vampire_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Vampire_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Vampire_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
