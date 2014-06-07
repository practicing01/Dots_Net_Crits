function Class_Gameplay_Mechanic_Browser_Button::onAction(%this)
{

if (%this.String_Type$="Minimize")
{

//%this.getParent().Active=false;

//%this.getParent().Visible=false;

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Visible=true;

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Active=true;

}
else if (%this.String_Type$="Show")
{

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Visible=false;

//GuiButtonCtrl_Gameplay_Mechanic_Browser_Show.Active=false;

if (!Gui_Gameplay_Mechanic_Browser.Visible)
{

Gui_Gameplay_Mechanic_Browser.Active=true;

Gui_Gameplay_Mechanic_Browser.Visible=true;

}
else
{

Gui_Gameplay_Mechanic_Browser.Active=false;

Gui_Gameplay_Mechanic_Browser.Visible=false;

}

}

}
