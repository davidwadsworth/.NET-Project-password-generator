﻿#ExternalChecksum("C:\Users\dwads\source\repos\Guided_Project_Learning_PW_Generater\Guided_Project_Learning_PW_Generater\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "DC31E876481662B5945B675771EC23F1")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.Guided_Project_Learning_PW_Generater

    Partial Class MainPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionid
            Case 1
                    Me.keyword_TxtBox = CType(target, Global.Windows.UI.Xaml.Controls.TextBox)
                    Exit Select
            Case 2
                    Me.keywordLabel = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 3
                    Me.submit_Btn = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 4
                    Me.keywordPassword_Label = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 5
                    Me.keywordPassword_TxtBox = CType(target, Global.Windows.UI.Xaml.Controls.TextBox)
                    Exit Select
                    Case Else
                        Exit Select
            End Select
                Me._contentLoaded = true
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetBindingConnector(connectionId As Integer, target As Object) As Global.Windows.UI.Xaml.Markup.IComponentConnector Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2.GetBindingConnector
            Dim returnValue As Global.Windows.UI.Xaml.Markup.IComponentConnector = Nothing
            Return returnValue
        End Function
    End Class

End Namespace
