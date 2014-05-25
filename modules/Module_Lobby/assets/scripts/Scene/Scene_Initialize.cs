function Module_Lobby::Scene_Initialize(%this)
{

//Generate trigonometry tables.

for (%x=0;%x<360;%x++)
{

%ScriptObject_Theta_Sine=new ScriptObject()
{

Theta_Sine=mSin(%x);

};

%this.SimSet_Sine_Table.add(%ScriptObject_Theta_Sine);

%ScriptObject_Theta_Cosine=new ScriptObject()
{

Theta_Cosine=mCos(%x);

};

%this.SimSet_Cosine_Table.add(%ScriptObject_Theta_Cosine);

}

//Spawn stars.

%Vector_2D_World_Position="0 0";

for (%x=0;%x<360;%x+=45)
{

%Float_Angle=%x;

%Vector_2D_World_Position=Vector2Direction(%Float_Angle,%this.Float_Magnitude);

%Sprite_Star=new Sprite()
{

Position=%Vector_2D_World_Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Star);
Image="Module_Lobby:Image_Star";
SceneLayer=16;
class="Class_Lobby_Star";
Module_ID_Parent=%this;
BlendColor="0 0.5 1 0.5";

Z=0;

Vector_2D_Position=%Vector_2D_World_Position;

};

%this.SimSet_Stars.add(%Sprite_Star);

Scene_Dots_Net_Crits.add(%Sprite_Star);

}

exec("./Schedule_Rotate_Stars.cs");

%this.Schedule_Rotate_Stars();

}
