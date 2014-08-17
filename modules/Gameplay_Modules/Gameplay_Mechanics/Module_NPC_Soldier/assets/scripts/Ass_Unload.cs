function Module_NPC_Soldier::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Soldier))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Soldier.getAssetId());

}

if (isObject(%this.Ass_Image_Soldier_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Soldier_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Soldier_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Soldier_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
