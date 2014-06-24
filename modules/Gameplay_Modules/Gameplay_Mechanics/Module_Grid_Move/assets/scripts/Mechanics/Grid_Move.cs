function Module_Grid_Move::Grid_Move(%this,%Module_ID_Parent,%GameConnection_Handle,%Int_Index,%Vector_2D_World_Position)
{

for (%x=0;%x<%Module_ID_Parent.SimSet_Gameplay_Objects.getCount();%x++)
{

%Gameplay_Object=%Module_ID_Parent.SimSet_Gameplay_Objects.getObject(%x);

if (%Gameplay_Object.Int_Index==%Int_Index&&%Gameplay_Object.ScriptObject_Client_Parent.GameConnection_Handle==%GameConnection_Handle)
{

if (%Gameplay_Object.Int_Current_Speed>0)
{

//Call the object's animation function.

%Gameplay_Object.Animate(Vector2AngleToPoint(%Gameplay_Object.Position,%Vector_2D_World_Position),1);

%String_SpriteIDs=Module_Lobby.Module_ID_Gameplay_Module.CompositeSprite_Grid.pickPoint(%Vector_2D_World_Position);

if (getWordCount(%String_SpriteIDs)==0){return;}

%SpriteID=getWord(%String_SpriteIDs,0);

Module_Lobby.Module_ID_Gameplay_Module.CompositeSprite_Grid.selectSpriteId(%SpriteID);

%Vector_2D_Local_Position=Module_Lobby.Module_ID_Gameplay_Module.CompositeSprite_Grid.getSpriteLocalPosition();

%Vector_2D_World_Position=Module_Lobby.Module_ID_Gameplay_Module.CompositeSprite_Grid.getWorldVector(%Vector_2D_Local_Position);

%Gameplay_Object.moveTo(%Vector_2D_World_Position,%Gameplay_Object.Int_Current_Speed,true,false);

%Gameplay_Object.Bool_Is_Moving=true;

}

return;

}

}

}
