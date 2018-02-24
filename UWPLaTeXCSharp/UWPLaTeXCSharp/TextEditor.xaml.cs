using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPLaTeXCSharp
{
    /// <summary>
    /// The text editor page, where the user can input text into a text field.
    /// </summary>
    public sealed partial class TextEditor : Page
    {
        public TextEditor()
        {
            this.InitializeComponent();
        }

        //Appends "\textbf{}" when user pushes bold button, and also changes focus back to textfield.
        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            editorBlock.SelectedText = "\\textbf{" + editorBlock.SelectedText + "}";
            editorBlock.Focus(FocusState.Programmatic);
            editorBlock.SelectionStart = editorBlock.SelectionStart + 8;
            editorBlock.SelectionLength = 0;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Displays back button in title bar.
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = Windows.UI.Core.AppViewBackButtonVisibility.Visible;
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;

            //Focus textbox.
            editorBlock.Focus(FocusState.Programmatic);
        }

        //Handles back button push.
        private void App_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }
    }
}
