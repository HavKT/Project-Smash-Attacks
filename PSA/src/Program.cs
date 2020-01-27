﻿/*  Smash Attacks: Super Smash Bros Brawl moveset editor.
    Copyright (C) 2009  Phantom Wings

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
    http://www.gnu.org/licenses.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmashAttacks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            FormMain fm = null;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fm = new FormMain();
            if (args.Length >= 1) { fm.FileToLoad(true, args[0]); }
            Application.Run(fm);
        }
    }
}
