function Module_Camera::Ass_Load(%this)
{

%this.Ass_Image_Camera_Up=AssetDatabase.acquireAsset("Module_Camera:Image_Camera_Up");

%this.Ass_Image_Camera_Down=AssetDatabase.acquireAsset("Module_Camera:Image_Camera_Down");

%this.Ass_Image_Camera_Left=AssetDatabase.acquireAsset("Module_Camera:Image_Camera_Left");

%this.Ass_Image_Camera_Right=AssetDatabase.acquireAsset("Module_Camera:Image_Camera_Right");

%this.Ass_Image_Camera_Mount=AssetDatabase.acquireAsset("Module_Camera:Image_Camera_Mount");

}
