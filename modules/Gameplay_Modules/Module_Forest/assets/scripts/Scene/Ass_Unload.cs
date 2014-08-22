function Module_Forest::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Floor_Tile))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile.getAssetId());

}

if (isObject(%this.Ass_Image_Grid_Highlighted_Tile))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Grid_Highlighted_Tile.getAssetId());

}

}
