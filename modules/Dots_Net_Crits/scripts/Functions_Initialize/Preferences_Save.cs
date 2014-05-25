function Dots_Net_Crits::Preferences_Save(%this)
{

%FileObject_File_Out=new FileObject();

%FileObject_File_Out.openForWrite("./../../../../preferences.cs");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::aabbOption =" SPC $pref::Dots_Net_Crits::aabbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::cameraMouseZoomRate =" SPC $pref::Dots_Net_Crits::cameraMouseZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::cameraTouchZoomRate =" SPC $pref::Dots_Net_Crits::cameraTouchZoomRate @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::collisionOption =" SPC $pref::Dots_Net_Crits::collisionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::defaultBackgroundColor = \"" @ $pref::Dots_Net_Crits::defaultBackgroundColor @ "\";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::fpsmetricsOption =" SPC $pref::Dots_Net_Crits::fpsmetricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::jointsOption =" SPC $pref::Dots_Net_Crits::jointsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::metricsOption =" SPC $pref::Dots_Net_Crits::metricsOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::oobbOption =" SPC $pref::Dots_Net_Crits::oobbOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::positionOption =" SPC $pref::Dots_Net_Crits::positionOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::sleepOption =" SPC $pref::Dots_Net_Crits::sleepOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::sortOption =" SPC $pref::Dots_Net_Crits::sortOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::wireframeOption =" SPC $pref::Dots_Net_Crits::wireframeOption @ ";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::Player_Name = \"" @ $pref::Dots_Net_Crits::Player_Name @ "\";");

%FileObject_File_Out.writeLine("$pref::Dots_Net_Crits::Master_IP = \"" @ $pref::Dots_Net_Crits::Master_IP @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::allowOpenGL =" SPC $pref::Video::allowOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::appliedPref =" SPC $pref::Video::appliedPref @ ";");

%FileObject_File_Out.writeLine("$pref::Video::clipHigh =" SPC $pref::Video::clipHigh @ ";");

%FileObject_File_Out.writeLine("$pref::Video::defaultResolution = \"" @ $pref::Video::defaultResolution @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsRenderer = \"" @ $pref::Video::defaultsRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::defaultsVendor = \"" @ $pref::Video::defaultsVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::deleteContext =" SPC $pref::Video::deleteContext @ ";");

%FileObject_File_Out.writeLine("$pref::Video::disableVerticalSync =" SPC $pref::Video::disableVerticalSync @ ";");

%FileObject_File_Out.writeLine("$pref::Video::displayDevice = \"" @ $pref::Video::displayDevice @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::fullScreen =" SPC $pref::Video::fullScreen @ ";");

%FileObject_File_Out.writeLine("$pref::Video::only16 =" SPC $pref::Video::only16 @ ";");

%FileObject_File_Out.writeLine("$pref::Video::preferOpenGL =" SPC $pref::Video::preferOpenGL @ ";");

%FileObject_File_Out.writeLine("$pref::Video::profiledRenderer = \"" @ $pref::Video::profiledRenderer @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::profiledVendor = \"" @ $pref::Video::profiledVendor @ "\";");

%FileObject_File_Out.writeLine("$pref::Video::safeModeOn =" SPC $pref::Video::safeModeOn @ ";");

%FileObject_File_Out.writeLine("$pref::Video::windowedRes = \"" @ $pref::Video::windowedRes @ "\";");

%FileObject_File_Out.writeLine("$pref::Audio::sfxVolume =" SPC $pref::Audio::sfxVolume @ ";");

%FileObject_File_Out.writeLine("$pref::Audio::musicVolume =" SPC $pref::Audio::musicVolume @ ";");

%FileObject_File_Out.close();

}
