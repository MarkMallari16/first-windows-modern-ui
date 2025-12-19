using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace FirstWinUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private string _firstLetter;

        [ObservableProperty]
        private string _birthMonthDateNumber;

        [ObservableProperty]
        private string _resultName;


        [RelayCommand]
        private void GenerateChristmasName()
        {
            if (string.IsNullOrWhiteSpace(FirstLetter))
            {
                ResultName = "Please fill your First Letter Name";
                return;
            }

            if (string.IsNullOrWhiteSpace(BirthMonthDateNumber))
            {
                ResultName = "Please fill your First Letter Name";
                return;
            }

            string randomPrefix = generateFirstLetterName(FirstLetter);
            string randomSuffix = generateBirthMonthDateNumberName(BirthMonthDateNumber);

            ResultName = $"Your Christmas Name is: {randomPrefix} {randomSuffix}";
        }

        [RelayCommand]
        private void ResetChristmasName()
        {
            FirstLetter = string.Empty;
            BirthMonthDateNumber = string.Empty;
            ResultName = string.Empty;
        }

        private string generateFirstLetterName(string firstLetterName)
        {
            switch (firstLetterName)
            {
                case "A":
                    return "Jingle";
                case "B":
                    return "Tinsel";
                case "C":
                    return "Merry";
                case "D":
                    return "Peppermint";
                case "E":
                    return "GingerBread";
                case "F":
                    return "Holly";
                case "G":
                    return "Snowflake";
                case "H":
                    return "Candy";
                case "I":
                    return "Twinkle";
                case "J":
                    return "Sparkle";
                case "K":
                    return "Jingle";
                case "L":
                    return "Elfie";
                case "M":
                    return "Frosty";
                case "N":
                    return "Jolly";
                case "O":
                    return "Velvet";
                case "P":
                    return "Mistletoe";
                case "Q":
                    return "Nutmeg";
                case "R":
                    return "Pudding";
                case "S":
                    return "Peppermint";
                case "T":
                    return "Cookie";
                case "U":
                    return "Wreath";
                case "V":
                    return "North Pole";
                case "W":
                    return "Angel";
                case "X":
                    return "Starlight";
                case "Y":
                    return "Muffin";
                case "Z":
                    return "Cinnamon";
                default:
                    return "Gina";
            }

            return null;
        }

        private string generateBirthMonthDateNumberName(String birthMonthDateNumber)
        {
            switch (birthMonthDateNumber)
            {
                case "1":
                    return "Sparklepants";
                case "2":
                    return "Frosty";
                case "3":
                    return "Twinkletoes";
                case "4":
                    return "Candycane";
                case "5":
                    return "GingerBread";
                case "6":
                    return "Holly";
                case "7":
                    return "Snowflake";
                case "8":
                    return "Jingle";
                case "9":
                    return "Sugarplum";
                case "10":
                    return "Bells";
                case "11":
                    return "Elfie";
                case "12":
                    return "Mistletoe";
                default:
                    return "Col";
            }

            return null;
        }

    }
}
