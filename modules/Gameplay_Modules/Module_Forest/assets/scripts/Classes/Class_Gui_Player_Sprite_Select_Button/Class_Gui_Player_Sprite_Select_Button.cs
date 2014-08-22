function Class_Gui_Player_Sprite_Select_Button::onAction(%this)
{

if (%this.Module_ID_Parent.GuiControl_Player_Sprite_Select->GuiScrollCtrl_Player_Sprite_List->GuiListBoxCtrl_Player_Sprite_List.getSelectedItem()==-1){return;}

commandToServer('Relay_Module_Function',%this.Module_ID_Parent,"Select_Player_Sprite",%this.Module_ID_Parent.ScriptObject_Player_Sprite_Module.Module_ID_Player_Sprite_Module);

}
