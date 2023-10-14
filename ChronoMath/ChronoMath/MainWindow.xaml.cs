using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChronoMath
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = null;
        Stopwatch currentStopwatch = null;

        bool isstarted = false;
        OperationProvider _operationsProvider;
        IOperation _currentOperation=null;
        int operationCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            
            rand = new Random(DateTime.Now.Millisecond);
            Task t = Task.Run(() =>
            {
                var timer = new Timer()
                {
                    Interval = 10,
                    Enabled = true
                };
                timer.Elapsed += new ElapsedEventHandler(Timer_Tick);
                timer.Start();
            });
            _operationsProvider = new OperationProvider();
        }


        private void Timer_Tick(object? sender, ElapsedEventArgs e)
        {
            if (currentStopwatch != null)
            {
                Horloge.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Horloge.Content = currentStopwatch.Elapsed.TotalMilliseconds / 1000;
                }));
            }
        }



        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if(!isstarted)
            {
                isstarted = true;
                operationCount = 0;

                currentStopwatch = new Stopwatch();
                currentStopwatch.Start();
                NewOperation();
            }

        }

        private void NewOperation()
        {
            Reponse.Text = "";
            _currentOperation = _operationsProvider.Provide(rand);
            Valeur1.Content = _currentOperation.Left;
            Valeur2.Content = _currentOperation.right;
            Operation.Content = _currentOperation.operation;
        }

        private void Vadid_Click(object sender, RoutedEventArgs e)
        {
            Message.Content = "";
            if (isstarted)
            {
                if (_currentOperation.Evaluate(Reponse.Text))
                {
                    operationCount++;
                    if (operationCount >= 30)
                    {
                        operationCount = 0;
                        isstarted = false;
                        currentStopwatch.Stop();
                        Message.Content = "Le jeu est fini";
                    }
                    else
                    {
                        NewOperation();
                    }

                }
                else
                {
                    Message.Content = $"{Reponse.Text}: Mauvaise réponse";
                    Reponse.Text = "";
                }

            }
        }

        private void Saisie_GotFocus(object sender, RoutedEventArgs e)
        {
            this.Reponse.Text = "";
            Message.Content = "";
        }

        private void Reponse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Vadid_Click(null, null);
            }
        }
    }
}
