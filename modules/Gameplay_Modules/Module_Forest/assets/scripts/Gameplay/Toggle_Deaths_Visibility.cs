function Module_Forest::Toggle_Deaths_Visibility(%this)
{

%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths.Visible=!%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths.Visible;

%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths.Active=!%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths.Active;

}
