function Module_NPC_Zombie::Get_Mechanics_List(%this)
{

%SimSet_Mechanics_List=new SimSet();

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Melee";

String_Mechanic="Bite";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Statistics";

String_Mechanic="Update_Foreign_Statistics";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

return %SimSet_Mechanics_List;

}
