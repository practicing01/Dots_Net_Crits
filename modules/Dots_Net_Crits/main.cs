function Dots_Net_Crits::create(%this)
{

/*Core Misc*/

exec("./scripts/Misc/Misc_Initialize.cs");

initializeCanvas("Dots_Net_Crits");

Canvas.BackgroundColor="black";

Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/

exec("./scripts/Variables_Initialize.cs");

%this.Variables_Initialize();

/*Global Functions*/
exec("./scripts/Functions_Initialize/Functions_Initialize.cs");

/*Core Scene*/
exec("./scenes/Scene_Dots_Net_Crits.cs");

/*Pause Menu*/
exec("./gui/Gui_Pause_Menu/Gui_Pause_Menu.cs");

/*Network*/
exec("./scripts/Network/Network.cs");

Window_Create_Dots_Net_Crits();

Scene_Create_Dots_Net_Crits();

Dots_Net_Crits.add(TamlRead("./gui/ConsoleDialog.gui.taml"));

GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{

Image="Dots_Net_Crits:CannotRender";

};

Dots_Net_Crits.add(CannotRenderProxy);

Dots_Net_Crits.Camera_Size=SceneWindow_Dots_Net_Crits.getCameraSize();

%Local_Time=getLocalTime();

%Local_Time=stripChars(%Local_Time,":/");

%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);

setRandomSeed(%Local_Time);

/*Load Play*/
exec("./scripts/Play_Load/Play_Load.cs");

%this.Play_Load();

}

function Dots_Net_Crits::destroy(%this)
{
Window_Destroy_Dots_Net_Crits();
}
