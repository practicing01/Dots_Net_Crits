function Module_Camera::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Camera_Up))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Camera_Up.getAssetId());

}

if (isObject(%this.Ass_Image_Camera_Down))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Camera_Down.getAssetId());

}

if (isObject(%this.Ass_Image_Camera_Left))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Camera_Left.getAssetId());

}

if (isObject(%this.Ass_Image_Camera_Right))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Camera_Right.getAssetId());

}

if (isObject(%this.Ass_Image_Camera_Mount))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Camera_Mount.getAssetId());

}

}
