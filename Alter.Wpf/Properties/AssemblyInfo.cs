﻿global using System;
global using static System.Diagnostics.DebuggerBrowsableState;
global using System.Linq;
global using Alter.Wpf.Internal;
global using Application = System.Windows.Application;
global using BF = System.Reflection.BindingFlags;
global using Binding = System.Windows.Data.Binding;
global using Brush = System.Windows.Media.Brush;
global using Brushes = System.Windows.Media.Brushes;
global using Button = System.Windows.Controls.Button;
global using Color = System.Windows.Media.Color;
global using ComboBox = System.Windows.Controls.ComboBox;
global using DataGrid = System.Windows.Controls.DataGrid;
global using DataGridColumn = System.Windows.Controls.DataGridColumn;
global using DBA = System.Diagnostics.DebuggerBrowsableAttribute;
global using HorizontalAlignment = System.Windows.HorizontalAlignment;
global using MouseEventArgs = System.Windows.Input.MouseEventArgs;
global using Panel = System.Windows.Controls.Panel;
global using Point = System.Windows.Point;
global using Size = System.Windows.Size;
global using TextBox = System.Windows.Controls.TextBox;
global using UserContorl = System.Windows.Controls.UserControl;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Markup;

[assembly: XmlnsDefinition(
    "http://schemas.microsoft.com/winfx/2006/xaml/presentation",
    "Alter.Wpf"
)]
[assembly: XmlnsDefinition("https://github.com/xtremlyred/alter", "Alter.Wpf")]
[assembly: XmlnsPrefix("Alter.Wpf", "alter")]

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}
