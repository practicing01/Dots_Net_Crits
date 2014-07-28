function Module_NPC_Berserker::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Berserker))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Berserker.getAssetId());

}

if (isObject(%this.Ass_Image_Berserker_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Berserker_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Berserker_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Berserker_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
