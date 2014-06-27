function Module_NPC_Shield_Generator::Get_Mechanics_List(%this)
{

%SimSet_Mechanics_List=new SimSet();

%ScriptObject_Mechanic=new ScriptObject()
{

String_Group="Shield";

String_Mechanic="Link";

};

%SimSet_Mechanics_List.add(%ScriptObject_Mechanic);

return %SimSet_Mechanics_List;

}
