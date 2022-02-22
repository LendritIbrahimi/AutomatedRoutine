﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class ControlsFinder
{
    public static List<Type> FindControls(Assembly controlsLibrary,
        string rootNamespace, bool includeNestedTypes = true)
    {
        var parent = typeof(UserControl);
        return controlsLibrary.GetTypes()
            .Where(t => (includeNestedTypes
                ? t.FullName.StartsWith(rootNamespace)
                : t.FullName.Equals($"{rootNamespace}.{t.Name}"))
                && parent.IsAssignableFrom(t))
            .ToList();
    }
}