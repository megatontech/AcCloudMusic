﻿#pragma checksum "C:\PROJECT\大新闻\大新闻\AppStudio.Source-v1.0.0.0\AppStudio.W10\Layouts\Detail\PhotoDetailLayout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2E3FDD55D3F8CFD0C50CC7217520BF8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppStudio.Layouts.Detail
{
    partial class PhotoDetailLayout : 
        global::AppStudio.Layouts.Detail.BaseDetailLayout, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.root = (global::AppStudio.Layouts.Detail.BaseDetailLayout)(target);
                }
                break;
            case 2:
                {
                    this.DisableFullScreenButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.ScrollViewer element3 = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    #line 24 "..\..\..\..\Layouts\Detail\PhotoDetailLayout.xaml"
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element3).SizeChanged += this.ScrollViewer_SizeChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

