function Class_Gameplay_Mechanic_Browser_GuiTextEditCtrl::onReturn(%this)
{

%String_Key=%this.getText();

if (isObject(%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic))
{

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Binds.getCount();%x++)
{

%ScriptObject_Bind=%this.Module_ID_Parent.SimSet_Binds.getObject(%x);

if (%ScriptObject_Bind.Module_ID$=%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic)
{

%ScriptObject_Bind.String_Key=%String_Key;

%this.Module_ID_Parent.ActionMap_Binds.bindCmd(keyboard,%ScriptObject_Bind.String_Key,%this.Module_ID_Parent @ ".Bound_Execute(" @ %ScriptObject_Bind.Module_ID @ ");","");

/**/

%FileObject_Binds=new FileObject();

%FileObject_Binds.openForWrite("./../../Binds.txt");

for (%y=0;%y<%this.Module_ID_Parent.SimSet_Binds.getCount();%y++)
{

%ScriptObject_Bind=%this.Module_ID_Parent.SimSet_Binds.getObject(%y);

%FileObject_Binds.writeLine(%ScriptObject_Bind.String_Key);

%FileObject_Binds.writeLine(%ScriptObject_Bind.Module_ID);

}

%FileObject_Binds.close();

/**/

return;

}

}

%ScriptObject_Bind=new ScriptObject()
{

String_Key=%String_Key;

Module_ID=%this.Module_ID_Parent.ScriptObject_Selected_Gameplay_Mechanic.Module_ID_Gameplay_Mechanic;

};

%this.Module_ID_Parent.SimSet_Binds.add(%ScriptObject_Bind);

%this.Module_ID_Parent.ActionMap_Binds.bindCmd(keyboard,%ScriptObject_Bind.String_Key,%this.Module_ID_Parent @ ".Bound_Execute(" @ %ScriptObject_Bind.Module_ID @ ");","");

/**/

%FileObject_Binds=new FileObject();

%FileObject_Binds.openForWrite("./../../Binds.txt");

for (%y=0;%y<%this.Module_ID_Parent.SimSet_Binds.getCount();%y++)
{

%ScriptObject_Bind=%this.Module_ID_Parent.SimSet_Binds.getObject(%y);

%FileObject_Binds.writeLine(%ScriptObject_Bind.String_Key);

%FileObject_Binds.writeLine(%ScriptObject_Bind.Module_ID);

}

%FileObject_Binds.close();

/**/

}

}
