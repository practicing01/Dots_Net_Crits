function Module_Lobby::Variables_Initialize(%this)
{

//Copy the global client simset so we can add fields to the clients, specific to this module.

%this.Simset_Client_List=new SimSet();

/********************************/

%this.SimSet_Gameplay_Modules=new SimSet();

/********************************/

%this.Module_ID_Gameplay_Module=0;

/********************************/

%this.SimSet_Stars=new SimSet();

%this.Schedule_Rotate_Stars=0;

%this.Float_Magnitude=10;

%this.Vector_3D_Rotation="0 0 0";

%this.Int_Rotation_Speed=1;

%this.SimSet_Sine_Table=new SimSet();

%this.SimSet_Cosine_Table=new SimSet();

/******************************/

%this.GuiControl_Lobby=TamlRead("./../../gui/GuiControl_Lobby.gui.taml");

%this.GuiControl_Lobby.resize(0,0,Gui_Dots_Net_Crits_Overlay.Extent.X,Gui_Dots_Net_Crits_Overlay.Extent.Y);

%this.GuiControl_Lobby.Module_ID_Parent=%this;

for (%x=0;%x<%this.GuiControl_Lobby.getCount();%x++)
{

%GuiControl_Child=%this.GuiControl_Lobby.getObject(%x);

%GuiControl_Child.Module_ID_Parent=%this;

}

Dots_Net_Crits.add(%this.GuiControl_Lobby);

Gui_Dots_Net_Crits_Overlay.add(%this.GuiControl_Lobby);

/******************************/

}
