function Module_Construct::Remove_Client(%this,%ScriptObject_Client_Copy)
{

if (isObject(%ScriptObject_Client_Copy.Sprite_Player_Sprite))
{

%ScriptObject_Client_Copy.Sprite_Player_Sprite.safeDelete();

}

if (isObject(%ScriptObject_Client_Copy.ScriptObject_Player_Sprite_Data))
{

%ScriptObject_Client_Copy.ScriptObject_Player_Sprite_Data.delete();

}

}
