function Class_Module_NPC_Shield_Generator::onAnimationEnd(%this)
{

if (%this.Bool_Is_Moving)
{

%this.Animate(%this.Float_Angle,1);

}
else
{

%this.Animate(%this.Float_Angle,0);

}

for (%x=0;%x<%this.SimSet_Linked_Parents.getCount();%x++)
{

%Linked_Object=%this.SimSet_Linked_Parents.getObject(%x);

%Linked_Object.Relink_Hex_Cells();

}

%this.Relink_Hex_Cells();

}
