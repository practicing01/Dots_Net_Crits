function Module_Forest::Increment_Death_Count(%this,%Sprite_Player)
{

for (%x=0;%x<%this.SimSet_Player_Deaths.getCount();%x++)
{

%ScriptObject_Death_Counter=%this.SimSet_Player_Deaths.getObject(%x);

if (%ScriptObject_Death_Counter.Sprite_Player==%Sprite_Player)
{

%ScriptObject_Death_Counter.Int_Deaths++;

%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths->GuiScrollCtrl_Player_List->GuiListBoxCtrl_Player_List.setItemText(
%ScriptObject_Death_Counter.Int_List_Index,%ScriptObject_Death_Counter.Sprite_Player.String_Name SPC %ScriptObject_Death_Counter.Int_Deaths);

return;

}

}

%ScriptObject_Death_Counter=new ScriptObject()
{

Sprite_Player=%Sprite_Player;

Int_Deaths=1;

Int_List_Index=-1;

};

%this.SimSet_Player_Deaths.add(%ScriptObject_Death_Counter);

%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths->GuiScrollCtrl_Player_List->GuiListBoxCtrl_Player_List.addItem(
%ScriptObject_Death_Counter.Sprite_Player.String_Name SPC %ScriptObject_Death_Counter.Int_Deaths);

%ScriptObject_Death_Counter.Int_List_Index=%this.GuiControl_Player_Deaths->GuiSpriteCtrl_Player_Deaths->GuiScrollCtrl_Player_List->GuiListBoxCtrl_Player_List.getItemCount()-1;

}
