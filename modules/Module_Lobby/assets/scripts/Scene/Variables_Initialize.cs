function Module_Lobby::Variables_Initialize(%this)
{

%this.SimSet_Stars=new SimSet();

%this.Schedule_Rotate_Stars=0;

%this.Float_Magnitude=10;

%this.Vector_3D_Rotation="0 0 0";

%this.Int_Rotation_Speed=1;

%this.SimSet_Sine_Table=new SimSet();

%this.SimSet_Cosine_Table=new SimSet();

}
