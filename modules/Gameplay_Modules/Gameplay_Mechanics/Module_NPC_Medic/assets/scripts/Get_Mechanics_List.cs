function Module_NPC_Medic::Get_Mechanics_List(%this)
{

%SimSet_Mechanics_List=new SimSet();

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Melee";

String_Mechanic="Heal";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Status";

String_Mechanic="Update_Foreign_Status";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

return %SimSet_Mechanics_List;

}
