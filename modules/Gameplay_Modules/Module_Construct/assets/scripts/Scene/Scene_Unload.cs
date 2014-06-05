function Module_Construct::Scene_Unload(%this)
{

%this.Ass_Unload();

if (isObject(%this.SimSet_Floor_Grid))
{

%this.SimSet_Floor_Grid.deleteObjects();

%this.SimSet_Floor_Grid.delete();

}

if (isObject(Gui_Sprite_Select))
{

Canvas.popDialog(Gui_Sprite_Select);

}

}
