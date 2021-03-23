using Microsoft.Win32;
using System.IO;
//using System.Text;
//using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace VendingMachineWPF
{
    /// <summary>
    /// Interaction logic for WindowServiceNotes.xaml
    /// </summary>
    public partial class WindowServiceNotes : Window
    {
        public WindowServiceNotes()
        {
            InitializeComponent();
        }

        private TextBox createServiceNote()
        {
            TextBox textBoxServiceNote = new TextBox() { AcceptsReturn = true };
            stackPanelServiceNoteHolder.Children.Add(textBoxServiceNote);
            return textBoxServiceNote;
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            createServiceNote();
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            TextBox textBoxServiceNote = createServiceNote();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                textBoxServiceNote.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            bool noServiceNoteHasFocus = true;
            foreach (TextBox serviceNote in stackPanelServiceNoteHolder.Children)
            {
                if (serviceNote.IsFocused)
                {
                    noServiceNoteHasFocus = false;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        File.WriteAllText(saveFileDialog.FileName, serviceNote.Text);
                    }
                }
            }
            if (noServiceNoteHasFocus)
            {
                MessageBox.Show("A service note must have input focus in order to save its contents to a file.",
                    "No Note to Save",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //private void MenuItemFilenames_Click(object sender, RoutedEventArgs e)
        //{
        //    StringBuilder allNoteText = new StringBuilder();
        //    foreach (TextBox tb in stackPanelServiceNoteHolder.Children)
        //    {
        //        allNoteText.Append(tb.Text);
        //    }

        //    Regex findFilenames = new Regex(@"([a-zA-Z]:)?(\\[.a-zA-Z0-9_-]+)+\\?");

        //    string result = null;
        //    foreach (var fileMatch in findFilenames.Matches(allNoteText.ToString()))
        //    {
        //        result += fileMatch + Environment.NewLine;
        //    }

        //    MessageBox.Show(result,
        //        "All Filenames found in open Service Notes files");
        //}
    }
}
