function Module_NPC_Turret::Scan_For_Targets(%this)
{

%Float_Radius=%this.Object_Mechanic_First_Target.Size.X;

if (%this.Object_Mechanic_First_Target.Size.X<%this.Object_Mechanic_First_Target.Size.Y)
{

%Float_Radius=%this.Object_Mechanic_First_Target.Size.Y;

}

%String_Object_List=Scene_Dots_Net_Crits.pickCircle(%this.Object_Mechanic_First_Target.Position,%Float_Radius*10,"","","any");

if (getWordCount(%String_Object_List)==0){return;}
else
{

%this.SimSet_Picked_Object_List.clear();

%this.Gui_Object_List.GuiListBoxCtrl_Object_List.clearItems();

%this.SimSet_Picked_Object_List.add(%this.ScriptObject_Cancel);

%this.Gui_Object_List.GuiListBoxCtrl_Object_List.addItem(%this.ScriptObject_Cancel.String_Name);

for (%x=0;%x<getWordCount(%String_Object_List);%x++)
{

%Object=getWord(%String_Object_List,%x);

%this.SimSet_Picked_Object_List.add(%Object);

%this.Gui_Object_List.GuiListBoxCtrl_Object_List.addItem(%Object.String_Name);

}

//Fracked on android.
//%this.Gui_Object_List.Position=SceneWindow_Dots_Net_Crits.getWindowPoint(%this.Object_Mechanic_First_Target.Position);

%this.Gui_Object_List.Position=
(Dots_Net_Crits.Resolution.X*0.5)-(%this.Gui_Object_List.Extent.X*0.5)
SPC
(Dots_Net_Crits.Resolution.Y*0.5)-(%this.Gui_Object_List.Extent.Y*0.5);

Gui_Dots_Net_Crits_Overlay.add(%this.Gui_Object_List);

}

}
