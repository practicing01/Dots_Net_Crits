//Credits to  Peter Collingridge for 3d code: https://www.khanacademy.org/cs/3d-tutorial-4/1648921303
function Module_Lobby::rotateZ3D(%this,%Theta,%Vector_3D_Position)
{

%Theta_Sine=%this.SimSet_Sine_Table.getObject(%Theta).Theta_Sine;

%Theta_Cosine=%this.SimSet_Cosine_Table.getObject(%Theta).Theta_Cosine;

%Float_X=%Vector_3D_Position.X * %Theta_Cosine - %Vector_3D_Position.Y * %Theta_Sine;

%Float_Y=%Vector_3D_Position.Y * %Theta_Cosine + %Vector_3D_Position.X * %Theta_Sine;

return %Float_X SPC %Float_Y SPC %Vector_3D_Position.Z;

}

function Module_Lobby::rotateY3D(%this,%Theta,%Vector_3D_Position)
{

%Theta_Sine=%this.SimSet_Sine_Table.getObject(%Theta).Theta_Sine;

%Theta_Cosine=%this.SimSet_Cosine_Table.getObject(%Theta).Theta_Cosine;

%Float_X=%Vector_3D_Position.X * %Theta_Cosine - %Vector_3D_Position.Z * %Theta_Sine;

%Float_Z=%Vector_3D_Position.Z * %Theta_Cosine + %Vector_3D_Position.X * %Theta_Sine;

return %Float_X SPC %Vector_3D_Position.Y SPC %Float_Z;

}

function Module_Lobby::rotateX3D(%this,%Theta,%Vector_3D_Position)
{

%Theta_Sine=%this.SimSet_Sine_Table.getObject(%Theta).Theta_Sine;

%Theta_Cosine=%this.SimSet_Cosine_Table.getObject(%Theta).Theta_Cosine;

%Float_Y=%Vector_3D_Position.Y * %Theta_Cosine - %Vector_3D_Position.Z * %Theta_Sine;

%Float_Z=%Vector_3D_Position.Z * %Theta_Cosine + %Vector_3D_Position.Y * %Theta_Sine;

return %Vector_3D_Position.X SPC %Float_Y SPC %Float_Z;

}

function Module_Lobby::Schedule_Rotate_Stars(%this)
{

if (!isObject(%this)){return;}

for (%x=0;%x<%this.SimSet_Stars.getCount();%x++)
{

%Sprite_Star=%this.SimSet_Stars.getObject(%x);

%Vector_3D_Position=%Sprite_Star.Vector_2D_Position.X SPC %Sprite_Star.Vector_2D_Position.Y SPC %Sprite_Star.Z;

%Vector_3D_Position=%this.rotateZ3D(%this.Vector_3D_Rotation.Z,%Vector_3D_Position);

%Vector_3D_Position=%this.rotateY3D(%this.Vector_3D_Rotation.Y,%Vector_3D_Position);

%Vector_3D_Position=%this.rotateX3D(%this.Vector_3D_Rotation.X,%Vector_3D_Position);

%Sprite_Star.Position=%Vector_3D_Position.X SPC %Vector_3D_Position.Y;

/*//2D rotation for testing.
%Float_Angle=Vector2AngleToPoint("0 0",%Sprite_Star.Position);

%Float_Angle+=%this.Int_Rotation_Speed;

%Sprite_Star.Position=Vector2Direction(%Float_Angle,%this.Float_Magnitude);
*/

}

if (1)//getRandom(0,1))
{

%this.Vector_3D_Rotation.X+=%this.Int_Rotation_Speed;

%this.Vector_3D_Rotation.X=%this.Vector_3D_Rotation.X%360;

}

if (1)//getRandom(0,1))
{

%this.Vector_3D_Rotation.Y+=%this.Int_Rotation_Speed;

%this.Vector_3D_Rotation.Y=%this.Vector_3D_Rotation.Y%360;

}

if (1)//getRandom(0,1))
{

%this.Vector_3D_Rotation.Z+=%this.Int_Rotation_Speed;

%this.Vector_3D_Rotation.Z=%this.Vector_3D_Rotation.Z%360;

}

%this.Schedule_Rotate_Stars=schedule(40,0,"Module_Lobby::Schedule_Rotate_Stars",%this);

}
