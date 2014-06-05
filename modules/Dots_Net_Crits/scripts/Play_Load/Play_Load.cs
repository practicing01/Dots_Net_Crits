function Dots_Net_Crits::Play_Load(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Dots_Net_Crits_Input_Controller";

};

SceneWindow_Dots_Net_Crits.addInputListener(%this.Script_Object_Input_Controller);

/*Load splashes*/

ModuleDatabase.LoadExplicit("Splashes");

Splashes.Scene_Load();

}
