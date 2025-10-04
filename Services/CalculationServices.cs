using FitStartWebApi.Enums;
using FitStartWebApi.Models;

namespace FitStartWebApi.Services
{
    public class CalculationServices
    {
        public double CalculateCalories(CalorieCalcModel info)
        {
            double Calories = 0;
            double multiplier = 0;

            switch (info.ActivityLevel)
            {

                case "Sedentary":
                    multiplier = 1.2;
                    break;
                case "Light":
                    multiplier = 1.375;
                    break;
                case "Moderate":
                    multiplier = 1.55;
                    break;
                case "Intense":
                    multiplier = 1.725;
                    break;
                case "Very Intense":
                    multiplier = 1.9;
                    break;
            default:
                break;
            }

            if(info.Gender == "Male")
            {
                Calories = 88.3 + (13.397 * info.Weight) + (4.799 * info.Height) - (5.677 * info.Age); 
            }
            else if (info.Gender == "Female")
            {
                Calories = 447.5 +(9.247 * info.Weight) + (3.098 * info.Height) - (4.330 * info.Age);
            }

            return Calories * multiplier;
        }
    }
}
