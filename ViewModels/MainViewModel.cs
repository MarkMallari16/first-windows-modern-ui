using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace FirstWinUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _inputName;

        [ObservableProperty]
        private string _resultName;

        [RelayCommand]
        private void GenerateChristmasName()
        {
            if (string.IsNullOrWhiteSpace(InputName))
            {
                ResultName = "Please enter a name.";
                return;
            }

            string[] prefixes = { "Jolly", "Sparkly", "Twinkly", "Merry", "Candy" };
            string[] suffixes = { "Sugarplum", "Snowflake", "Evergreen", "Reindeer" };

            var random = new Random();

            string randomPrefix = prefixes[random.Next(prefixes.Length)];
            string randomSuffix = suffixes[random.Next(suffixes.Length)];

            ResultName = $"{randomPrefix} {InputName} {randomSuffix}";
        }

        [RelayCommand]
        private void ResetChristmasName()
        {
            InputName = string.Empty;
            ResultName = string.Empty;
        }
       
    }
}
