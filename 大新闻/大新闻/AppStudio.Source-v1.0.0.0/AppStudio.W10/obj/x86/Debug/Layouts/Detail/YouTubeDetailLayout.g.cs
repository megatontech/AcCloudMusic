﻿#pragma checksum "C:\PROJECT\大新闻\大新闻\AppStudio.Source-v1.0.0.0\AppStudio.W10\Layouts\Detail\YouTubeDetailLayout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B46996EAFDEE2CC3933CB68B5056B71F"
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
    partial class YouTubeDetailLayout : 
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
                    global::Windows.UI.Xaml.Controls.WebView element2 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                    #line 16 "..\..\..\..\Layouts\Detail\YouTubeDetailLayout.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)element2).Unloaded += this.WebView_Unloaded;
                    #line default
                }
                break;
            case 3:
                {
                    this.DisableFullScreenButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.infoPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
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

