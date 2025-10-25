public class MedicalBot
{
    public const string BotName = "Bob"; // declaring a constant string variable with the value "Bob" which represents the name of the medical bot.

    // This method prescribes medication based on the symptoms of the patient passed as an argument.
    public void PrescribeMedication(Patient patient)
    {
        if (patient.GetSymptoms() == "Headache") // If the patient's symptoms are headache
        {
            patient.SetPrescription("ibuprofen " + GetDosage("ibuprofen")); // Then prescribe ibuprofen to the patient.
        }
        else if (patient.GetSymptoms() == "Skin rashes") // If the patient's symptoms are skin rashes
        {
            patient.SetPrescription("diphenhydramine " + GetDosage("diphenhydramine")); // Then prescribe diphenhydramine to the patient.
        }
        else if (patient.GetSymptoms() == "Dizziness") // If the patient's symptoms are dizziness
        {
            if (patient.GetMedicalHistory() == "Diabetes") // If the patient has a medical history of diabetes
            {
                patient.SetPrescription("metformin " + GetDosage("metformin")); // Then prescribe metformin to the patient.
            }
            else
            {
                patient.SetPrescription("dimenhydrinate " + GetDosage("dimenhydrinate")); // Otherwise, prescribe dimenhydrinate to the patient.
            }
        }

        // This method returns the dosage of the medicine based on the patient's age and medicine name passed as an argument.
        string GetDosage(string medicineName)
        {
            if (medicineName == "ibuprofen") // If the medicine name is ibuprofen
            {
                if (patient.GetAge() < 18) // If the patient's age is less than 18
                    return "400 mg"; // Then the dosage is 400 mg.
                else
                    return "800 mg"; // Otherwise, the dosage is 800 mg.
            }
            else if (medicineName == "diphenhydramine") // If the medicine name is diphenhydramine
            {
                if (patient.GetAge() < 18) // If the patient's age is less than 18
                    return "50 mg"; // Then the dosage is 50 mg.
                else
                    return "300 mg"; // Otherwise, the dosage is 300 mg.
            }
            else if (medicineName == "dimenhydrinate") // If the medicine name is dimenhydrinate
            {
                if (patient.GetAge() < 18) // If the patient's age is less than 18
                    return "50 mg"; // Then the dosage is 50 mg.
                else
                    return "400 mg"; // Otherwise, the dosage is 400 mg.
            }
            else if (medicineName == "metformin") // If the medicine name is metformin
            {
                return "500 mg"; // Then the dosage is 500 mg.
            }
            return "Unknown";
        }
    }

    public static string GetBotName()
    {
        return MedicalBot.BotName;
    }
}
