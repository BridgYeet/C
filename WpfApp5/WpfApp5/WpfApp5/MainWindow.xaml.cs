using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shell;


namespace SOY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}" + "\\folder";
        private string _PATH;
        private BindingList<Employee> _varData = new BindingList<Employee>();
        private FileSaver _filesaver;

        public string str = "";

        public MainWindow()
        {
            InitializeComponent();

            if (!File.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }

            string newPath = $"{Environment.CurrentDirectory}\\folder";
            foreach (string x in Directory.GetFiles(newPath))
            {
                string y;
                y = System.IO.Path.GetFileName(x);
                y = y.Substring(0, y.Length - 5);
                ListBoxLists.Items.Add(y);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            bool flag = false;
            str = TextBoxNamelist.Text;

            str = str.Trim();

            foreach (string x in ListBoxLists.Items)
            {
                if (x == str)
                    flag = true;
            }


            if (TextBoxNamelist.Text != null)
            {
                if (!flag && str != "")
                {
                    ListBoxLists.Items.Add(str);
                }
            }
            TextBoxNamelist.Clear();
            flag = false;

            ListBoxLists.SelectedItem = str;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void _varData_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _filesaver.SaveData(sender);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }
        private void ListBoxLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = (string)ListBoxLists.SelectedItem;
            _PATH = PATH + "\\" + item + ".json";
            _filesaver = new FileSaver(_PATH);

            try
            {
                _varData = _filesaver.LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Close();
            }


            SOYlist.ItemsSource = _varData;
            _varData.ListChanged += _varData_ListChanged;

            ICollectionView dataView = CollectionViewSource.GetDefaultView(SOYlist.ItemsSource);

        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string s = ListBoxLists.SelectedItem.ToString();

            ListBoxLists.Items.RemoveAt(ListBoxLists.Items.IndexOf(s));

            File.Delete(PATH + "\\" + s + ".json");
            File.Delete(PATH + "\\" + ".json");
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tbx = (TextBox)sender;
                if (tbx.Text != "")
                {
                    var filteredList = _varData.Where(x => x.FIO.ToLower().Contains(tbx.Text.ToLower()));
                    SOYlist.ItemsSource = null;
                    SOYlist.ItemsSource = filteredList;
                }
                else
                {
                    SOYlist.ItemsSource = _varData;
                }
        }

        class Employee : INotifyPropertyChanged
        {
            private string _FIO;
            private string _goda;
            private string _speciality;
            private string _phone;
            private int _oklad;

            public string FIO
            {
                get { return _FIO; }
                set
                {
                    if (_FIO == value)
                        return;
                    _FIO = value;
                    OnPropertyChanget("FIO");
                }
            }

            public string Goda
            {
                get { return _goda; }
                set
                {
                    if (_goda == value)
                        return;
                    _goda = value;
                    OnPropertyChanget("Goda");
                }
            }
            public string Speciality
            {
                get { return _speciality; }
                set
                {
                    if (_speciality == value)
                        return;
                    _speciality = value;
                    OnPropertyChanget("Speciality");
                }
            }
            
            public string Phone
            {
                get { return _phone; }
                set
                {
                    if (_phone == value)
                        return;
                    _phone = value;
                    OnPropertyChanget("Phone");
                }
            }
            public int Oklad
            {
                get { return _oklad; }
                set
                {
                    if (_oklad == value)
                        return;
                    _oklad = value;
                    OnPropertyChanget("Oklad");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanget(string propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        class FileSaver
        {
            private readonly string PATH;

            public FileSaver(string path)
            {
                PATH = path;
            }

            public BindingList<Employee> LoadData()
            {
                var fileExist = File.Exists(PATH);
                if (!fileExist)
                {
                    File.CreateText(PATH).Dispose();
                    return new BindingList<Employee>();
                }
                using (var reader = File.OpenText(PATH))
                {
                    var fileText = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<BindingList<Employee>>(fileText);
                }
            }

            public void SaveData(object varData)
            {
                using (StreamWriter writer = File.CreateText(PATH))
                {
                    string output = JsonConvert.SerializeObject(varData);
                    writer.Write(output);
                }
            }
        }
        private void SOYlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
