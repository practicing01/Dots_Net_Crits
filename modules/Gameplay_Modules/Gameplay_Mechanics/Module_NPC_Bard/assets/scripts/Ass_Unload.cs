function Module_NPC_Bard::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Bard))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bard.getAssetId());

}

if (isObject(%this.Ass_Image_Bard_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bard_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Bard_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Bard_Cast.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

}
