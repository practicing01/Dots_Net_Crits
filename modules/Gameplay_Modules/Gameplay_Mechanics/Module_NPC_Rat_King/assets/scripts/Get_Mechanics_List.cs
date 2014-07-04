function Module_NPC_Rat_King::Get_Mechanics_List(%this)
{

%SimSet_Mechanics_List=new SimSet();

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Melee";

String_Mechanic="Scratch";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

return %SimSet_Mechanics_List;

}
