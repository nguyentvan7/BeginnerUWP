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

        //Appends "\textbf{}" when user pushes bold button. Adapts to selected text.
        private void boldButton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            if (editorBlock.SelectionLength != 0)
            {
                num = editorBlock.SelectionLength;
            }
            editorBlock.SelectedText = "\\textbf{" + editorBlock.SelectedText + "}";
            editorBlock.SelectionStart = editorBlock.SelectionStart + 8 + num;
            editorBlock.SelectionLength = 0;
        }

        //Appends "\textit{}" when user pushes italic button. Adapts to selected text.
        private void italicButton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            if (editorBlock.SelectionLength != 0)
            {
                num = editorBlock.SelectionLength;
            }
            editorBlock.SelectedText = "\\textit{" + editorBlock.SelectedText + "}";
            editorBlock.SelectionStart = editorBlock.SelectionStart + 8 + num;
            editorBlock.SelectionLength = 0;
        }

        //Appends "\underline{}" when user pushes underline button. Adapts to selected text.
        private void underlineButton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            if (editorBlock.SelectionLength != 0)
            {
                num = editorBlock.SelectionLength;
            }
            editorBlock.SelectedText = "\\underline{" + editorBlock.SelectedText + "}";
            editorBlock.SelectionStart = editorBlock.SelectionStart + 11 + num;
            editorBlock.SelectionLength = 0;
        }

        //Appends "\begin{flushleft}..." when user pushes left align button. Adapts to selected text.
        private void leftAlignButton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            if (editorBlock.SelectionLength != 0)
            {
                num = editorBlock.SelectionLength;
            }
            editorBlock.SelectedText = "\\begin{flushleft}\n\t" + editorBlock.SelectedText + "\n\\end{flushleft}";
            editorBlock.SelectionStart = editorBlock.SelectionStart + 19 + num;
            editorBlock.SelectionLength = 0;
        }
    }
}
