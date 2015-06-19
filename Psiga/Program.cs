﻿/// <summary>
/// Copyright (C) 2015 Matthew Ready.
/// </summary>
using System;
using Gtk;
using PsigaPkgLib;

namespace Psiga
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			PackageManager.SetTransistorRoot("/home/matthew/.steam/steam/steamapps/common/Transistor/Content/Win/Packages");

			Application.Init();
			PackageViewerWindow win = new PackageViewerWindow();
			win.Show();
			Application.Run();
		}
	}
}