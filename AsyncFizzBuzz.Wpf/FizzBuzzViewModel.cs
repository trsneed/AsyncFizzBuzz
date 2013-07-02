using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;

namespace AsyncFizzBuzz.Wpf
{
    public class FizzBuzzViewModel : PropertyChangedBase
    {
        public ObservableCollection<string> Values { get; set; }

        public FizzBuzzViewModel()
        {

            Values = new ObservableCollection<string>();
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                NotifyOfPropertyChange(() => IsEnabled);
            }
        }

        private int _seconds;
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                _seconds = value;
                NotifyOfPropertyChange(() => Seconds);
                IsReadyToFizzBuzz();
            }
        }

        private int _totalFizzBuzz;
        public int TotalFizzBuzz
        {
            get { return _totalFizzBuzz; }
            set
            {
                _totalFizzBuzz = value;
                NotifyOfPropertyChange(() => TotalFizzBuzz);
                IsReadyToFizzBuzz();

            }
        }

        private void IsReadyToFizzBuzz()
        {
            if (TotalFizzBuzz > 0 && Seconds > 0)
            {
                IsEnabled = true;
            }
        }

        public async Task CalculateTheFizzBuzz()
        {
            Values.Clear();
            try
            {
                IsEnabled = false;
                for (int i = 0; i < TotalFizzBuzz; i++)
                {
                    var value = await FizzBuzzer.ReturnTheFizzBuzzValue(i, _seconds);
                    Values.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad Developer!");
            }
            finally
            {
                IsEnabled = true;
            }
        }

        private async Task<string> ReturnTheFizzBuzzValue(int i)
        {
            string s = null;
            if (i % 3 == 0)
                s = "fizz";
            if (i % 5 == 0)
                s = s + "buzz";
            if (String.IsNullOrWhiteSpace(s))
                s = i.ToString();
            await Task.Delay(Seconds * 1000);

            return s;

        }

    }
}
