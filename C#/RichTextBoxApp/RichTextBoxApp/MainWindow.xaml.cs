using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RichTextBoxApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void save_ButonClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
            save.Filter =
                "Файл XAML (*.xaml)|*.xaml|RTF-файл (*.rtf)|*.rtf";

            if (save.ShowDialog() == true)
            {
                // Создание контейнера TextRange для всего документа
                TextRange documentTextRange = new TextRange(
                    richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

                // Если такой файл существует, он перезаписывается, 
                using (FileStream fs = File.Create(save.FileName))
                {
                    if (System.IO.Path.GetExtension(save.FileName).ToLower() == ".rtf")
                    {
                        documentTextRange.Save(fs, DataFormats.Rtf);
                    }
                    else
                    {
                        documentTextRange.Save(fs, DataFormats.Xaml);
                    }
                }
            }
        }

        private void open_ButonClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFile =
                new Microsoft.Win32.OpenFileDialog();

            openFile.Filter = "Файл XAML (*.xaml)|*.xaml|RichText files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                TextRange tr = new TextRange(
                    richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

                using (FileStream fs = File.Open(openFile.FileName, FileMode.Open))
                {
                    if (new DirectoryInfo(openFile.FileName).Extension == ".xaml")
                    {
                        tr.Load(fs, DataFormats.Xaml);
                    }
                    else
                    {
                        tr.Load(fs, DataFormats.Rtf);
                    }
                }
            }

            // Копирование содержимого документа в MemoryStream. 
            using (MemoryStream stream = new MemoryStream())
            {
                TextRange range = new TextRange(richTextBox.Document.ContentStart,
                    richTextBox.Document.ContentEnd);
                range.Save(stream, DataFormats.Xaml);
                stream.Position = 0;

                // Чтение содержимого из потока и вывод его в текстовом поле. 
                using (StreamReader r = new StreamReader(stream))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                        txb_xaml.Text += line + "\n";
                }
            }
        }

        private void updatexaml_Click(object sender, RoutedEventArgs e)
        {
            TextRange range;

            range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

            MemoryStream stream = new MemoryStream();
            range.Save(stream, DataFormats.Xaml);
            stream.Position = 0;

            StreamReader r = new StreamReader(stream);

            txb_xaml.Text = r.ReadToEnd();
            r.Close();
            stream.Close();
        }

        private void new_ButonClick(object sender, RoutedEventArgs e)
        {
            richTextBox.Document = new FlowDocument();
        }

        private void richTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                //// Получение указателя TextPointer, ближайшего к указателю мыши
                //TextPointer location = richTextBox.GetPositionFromPoint
                //     (Mouse.GetPosition(richTextBox), true);

                //// Получение ближайшего слова с помощью этого TextPointer
                //TextRange word = WordBreaker.GetWordRange(location);

                //txb_FlowDocumentMarkup.Text = word.Text;
            }
        }
    }
}
