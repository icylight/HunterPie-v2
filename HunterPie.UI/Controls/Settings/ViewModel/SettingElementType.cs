﻿using HunterPie.UI.Settings;
using System;
using System.Reflection;

namespace HunterPie.UI.Controls.Settings.ViewModel
{
    internal class SettingElementType : ISettingElementType
    {
        public object Parent { get; private set; }
        public PropertyInfo Information { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public SettingElementType(string name, string description, object parent, PropertyInfo info)
        {
            Name = name;
            Description = description;
            Parent = parent;
            Information = info;
        }
    }
}