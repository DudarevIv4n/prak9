using System;
using System.Collections.Generic;
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

namespace pr_9_dudarev_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
     partial class MainWindow : Window
    {
        struct FilmLibrary
        {
            public string FilmName;
            public string FilmGenre;
            public int FilmRelease;
            public int FilmDuration;

            public FilmLibrary(string filmName, string filmGenre, int filmRelease, int filmDuration)
            {
                FilmName = filmName;
                FilmGenre = filmGenre;
                FilmRelease = filmRelease;
                FilmDuration = filmDuration;
            }
        }
        FilmLibrary film1 = new FilmLibrary("Веном", "Фантастика", 2018, 112);
        FilmLibrary film2 = new FilmLibrary("Механик. Воскрешение", "Боевик", 2016, 98);
        FilmLibrary film3 = new FilmLibrary("День курка", "боевик", 2021, 100);
        FilmLibrary film4 = new FilmLibrary("Хитмэн", "Боевик, Преступление", 2007, 89);
        FilmLibrary film5 = new FilmLibrary("Джек Ричер 2: Никогда не возвращайся", "Боевик, триллер, преступление", 2016, 118);
        FilmLibrary film6 = new FilmLibrary("Запрос в друзья", "Ужасы, триллер, детектив", 2016, 92);
        FilmLibrary film7 = new FilmLibrary("Гнев человеческий", "боевик, триллер", 2021, 119);


        public MainWindow()
        {
            InitializeComponent();

            
            filmLibraryListBox.Items.Add($"'{film1.FilmName}' | {film1.FilmGenre}, {film1.FilmRelease}г, {film1.FilmDuration} мин.");
           
            filmLibraryListBox.Items.Add($"'{film2.FilmName}' | {film2.FilmGenre}, {film2.FilmRelease}г, {film2.FilmDuration} мин.");
            
            filmLibraryListBox.Items.Add($"'{film3.FilmName}' | {film3.FilmGenre}, {film3.FilmRelease}г, {film3.FilmDuration} мин.");
            
            filmLibraryListBox.Items.Add($"'{film4.FilmName}' | {film4.FilmGenre}, {film4.FilmRelease}г, {film4.FilmDuration} мин.");
            
            filmLibraryListBox.Items.Add($"'{film5.FilmName}' | {film5.FilmGenre}, {film5.FilmRelease}г, {film5.FilmDuration} мин.");
            
            filmLibraryListBox.Items.Add($"'{film6.FilmName}' | {film6.FilmGenre}, {film6.FilmRelease}г, {film6.FilmDuration} мин.");
            
            filmLibraryListBox.Items.Add($"'{film7.FilmName}' | {film7.FilmGenre}, {film7.FilmRelease}г, {film7.FilmDuration} мин.");
        }

        private void createFilm_Click(object sender, RoutedEventArgs e)
        {
            List<FilmLibrary> films = new List<FilmLibrary>();
            films.Add(film1);
            films.Add(film2);
            films.Add(film3);
            films.Add(film4);
            films.Add(film5);
            films.Add(film6);
            films.Add(film7);

            bool isEmpty = inputGenre.Text == string.Empty;
            if (isEmpty)
            {
                MessageBox.Show("Введите жанр", "Ошибка");
            }
            else
            {
                FilmLibrary found = films.Find(item => item.FilmGenre.Contains(inputGenre.Text));
                MessageBox.Show($"{found.FilmName} | {found.FilmGenre}, {found.FilmRelease}г, {found.FilmDuration} мин.");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дударев Иван ИСП-34\n" +
                "Заполнить таблицу фильмотеки на 7 кассет с полями: фильм, жанр, год выпуска, " +
                "продолжительность просмотра.Вывести результат на экран. Вывести список фильмов заданного жанра.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
