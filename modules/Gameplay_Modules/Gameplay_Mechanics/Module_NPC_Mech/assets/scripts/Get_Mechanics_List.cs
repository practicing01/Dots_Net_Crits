function Module_NPC_Mech::Get_Mechanics_List(%this)
{

%SimSet_Mechanics_List=new SimSet();

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Melee";

String_Mechanic="Punch";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Ranged";

String_Mechanic="Fire";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

return %SimSet_Mechanics_List;

}
