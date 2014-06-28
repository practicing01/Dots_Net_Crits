function Module_Plague_Doctor_Mask::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Plague_Doctor_Mask))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Plague_Doctor_Mask.getAssetId());

}

}
