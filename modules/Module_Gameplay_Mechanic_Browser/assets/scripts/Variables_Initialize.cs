function Module_Gameplay_Mechanic_Browser::Variables_Initialize(%this)
{

%this.ActionMap_Binds=new ActionMap();

%this.ActionMap_Binds.push();

%this.SimSet_Binds=new SimSet();

%FileObject_Binds=new FileObject();

%FileObject_Binds.openForRead("./Binds.txt");

%String_Key=%FileObject_Binds.readLine();

while (1)
{

if (%FileObject_Binds.isEOF()){break;}

%String_Module_ID=%FileObject_Binds.readLine();

%ScriptObject_Bind=new ScriptObject()
{

String_Key=%String_Key;

Module_ID=%String_Module_ID;

};

%this.SimSet_Binds.add(%ScriptObject_Bind);

%this.ActionMap_Binds.bindCmd(keyboard,%ScriptObject_Bind.String_Key,%this @ ".Bound_Execute(" @ %ScriptObject_Bind.Module_ID @ ");","");

%String_Key=%FileObject_Binds.readLine();

}

%FileObject_Binds.close();

/******************************/

%this.SimSet_Gameplay_Mechanic_Modules=new SimSet();

%this.SimSet_Gameplay_Mechanic_Module_Groups=new SimSet();

%this.ScriptObject_Selected_Gameplay_Mechanic=0;

/******************************/

%this.GuiControl_Browser=TamlRead("./../gui/GuiControl_Browser.gui.taml");

%this.GuiControl_Browser.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiControl_Browser,%this);

Dots_Net_Crits.add(%this.GuiControl_Browser);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Browser);

/******************************/

/******************************/

%this.GuiButtonCtrl_Show=TamlRead("./../gui/GuiButtonCtrl_Show.gui.taml");

%this.GuiButtonCtrl_Show.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

Set_Gui_Module_ID_Parent(%this.GuiButtonCtrl_Show,%this);

Dots_Net_Crits.add(%this.GuiButtonCtrl_Show);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiButtonCtrl_Show);

/******************************/

}
