function Module_NPC_Artillery::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Artillery))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Artillery.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

if (isObject(%this.Ass_Image_Shell))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Shell.getAssetId());

}

if (isObject(%this.Ass_Image_Explosion))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Explosion.getAssetId());

}

}
