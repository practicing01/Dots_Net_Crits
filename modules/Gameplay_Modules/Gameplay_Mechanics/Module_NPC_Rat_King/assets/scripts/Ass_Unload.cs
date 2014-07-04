function Module_NPC_Rat_King::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Rat_King))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rat_King.getAssetId());

}

if (isObject(%this.Ass_Image_Rat_King_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rat_King_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Rat_King_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rat_King_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Rat))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rat.getAssetId());

}

if (isObject(%this.Ass_Image_Rat_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rat_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Rat_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rat_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
