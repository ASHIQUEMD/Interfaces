using PersonRepository.CSV;
using PersonRepository.Factory;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulatePeople("Service");
        }

        private void PopulatePeople(string repositoryType)
        {
            ClearListBox();
            IPersonRepository personRepository = RepositoryFactory.GetRepository(repositoryType);
            var people = personRepository.GetPeople();

            foreach (var item in people)
            {
                PersonListBox.Items.Add(item);
            }

            ShowRepositoryType(personRepository);
        }

        private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulatePeople("CSV");
        }

        private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulatePeople("SQL");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeTextBlock.Text = repository.GetType().ToString();
        }
    }
}
