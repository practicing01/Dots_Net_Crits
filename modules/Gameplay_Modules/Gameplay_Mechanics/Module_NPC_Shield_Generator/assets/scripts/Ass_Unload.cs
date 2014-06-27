function Module_NPC_Shield_Generator::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Smoke))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Smoke.getAssetId());

}

if (isObject(%this.Ass_Image_Shield_Generator))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Shield_Generator.getAssetId());

}

if (isObject(%this.Ass_Image_Shield_Generator_0))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Shield_Generator_0.getAssetId());

}

if (isObject(%this.Ass_Image_Summoning_Circle))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Summoning_Circle.getAssetId());

}

if (isObject(%this.Ass_Image_Hex_Cell))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Hex_Cell.getAssetId());

}

}
