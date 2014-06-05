function Module_Construct::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Floor_Tile))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile.getAssetId());

}

}
