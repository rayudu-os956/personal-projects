using System.ComponentModel;

public class Patient
{
    private string name;
    private int age;
    private string gender;
    private string medicalHistory;
    private string symptomCode;
    private string prescription;

    public string GetName()
    {
        return name;
    }

    // Public method to set the patient name and validate it. Returns a bool indicating whether the name is valid or not, and an error message if it's invalid.

    public bool SetName(string name, out string errorMessage)
    {
        bool isValid;
        // Check if name is null or empty

        if (name == null || name.Length == 0)
        {
            isValid = false;
            errorMessage = "Patient name can't be blank";
            return isValid;
        }
        // Check if name has only one character
        else if (name.Length == 1)
        {
            isValid = false;
            errorMessage = "Patient Name shoould at least contain least two or more characters";
        }
        isValid = true;
        errorMessage = "";
        this.name = name;
        return isValid;

    }
    //age
    public int GetAge()
    {
        return age;
    }
    //setting age 

    public bool SetAge(int age, out string errorMessage)
    {
        bool isValid;

        //check age is neagative 
        if (age < 0)
        {
            isValid = false;
            errorMessage = "Age should not be a negative number ";
            return isValid;
        }
        // Check if age is greater than 100
        if (age > 100)
        {
            isValid = false;
            errorMessage = "Age should not nbe more than 100";
            return isValid;
        }
        //age is valid 
        isValid = true;
        errorMessage = "";
        this.age = age;
        return isValid;
    }

    public string GetGender()
    {
        return gender;
    }

    public bool SetGender(string gender, out string errorMessage)
    {
        bool isValid;

        // Check if gender is not "Male", "Female", or "Other"
        if (gender != "Male" && gender != "Female" && gender != "Other" && gender != "male" && gender != "female" && gender != "other")
        {
            isValid = false;
            errorMessage = "Patient gender should be either Male, Female or Other";
            return isValid;
        }

        // Gender is valid, set the field and return true
        isValid = true;
        errorMessage = "";

        this.gender = gender;
        return isValid;
    }
 


    public string GetMedicalHistory()
    {
        return medicalHistory;
    }

    public void SetMedicalHistory(string medicalHistory)
    {
        this.medicalHistory = medicalHistory;
    }

    public string GetSymptoms()
    {
        string symptom;
        switch (symptomCode)
        {
            case "S1":
            case "s1": symptom = "Headache"; break;

            case "S2":
            case "s2": symptom = "Skin rashes"; break;

            case "S3":
            case "s3": symptom = "Dizziness"; break;

            default: symptom = "Unknown"; break;

        }
        return symptom;
    }

    // A method to set the patient's symptom code

    public bool SetSymptomCode(string symptomCode, out string errorMessage)
    {
        bool isValid;
        if (symptomCode != "S1" && symptomCode != "S2" && symptomCode != "S3" && symptomCode != "s1" && symptomCode != "s2" && symptomCode != "s3")
        {
            isValid = false;
            errorMessage = "Symptom Code should either be S1, S2, or S3.";
            return isValid;
        }
        isValid = true;
        errorMessage = "";
        this.symptomCode = symptomCode;
        return isValid;

    }
    public string GetPrescription()
    {
        return prescription;
    }
    public void SetPrescription(string prescription)
    {
        this.prescription = prescription;
    }
 
}

