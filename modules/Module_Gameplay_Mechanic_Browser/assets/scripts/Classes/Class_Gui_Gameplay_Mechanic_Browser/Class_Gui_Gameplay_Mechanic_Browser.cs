function Class_GuiSpriteCtrl_Gameplay_Mechanic_Browser_Background::onControlDropped(%this,%Vector_2D_Position)
{

%this.getParent().onControlDropped(%Vector_2D_Position);

}

function Class_Gui_Gameplay_Mechanic_Browser::onControlDropped(%this,%Vector_2D_Position)
{

if (%this.Position.X<0){%this.Position.X=0;}

if (%this.Position.Y<0){%this.Position.Y=0;}

if (%this.Position.X>Gui_Dots_Net_Crits_Overlay.Extent.X-%this.Extent.X){%this.Position.X=Gui_Dots_Net_Crits_Overlay.Extent.X-%this.Extent.X;}

if (%this.Position.Y>Gui_Dots_Net_Crits_Overlay.Extent.Y-%this.Extent.Y){%this.Position.Y=Gui_Dots_Net_Crits_Overlay.Extent.Y-%this.Extent.Y;}

}
