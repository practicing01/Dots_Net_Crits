function Module_NPC_King::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_King))
{

AssetDatabase.releaseAsset(%this.Ass_Image_King.getAssetId());

}

if (isObject(%this.Ass_Image_King_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_King_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_King_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_King_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
