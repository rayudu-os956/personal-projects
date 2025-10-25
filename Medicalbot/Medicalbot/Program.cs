class Program
{
 static void Main()
 {
  // Welcome message
  System.Console.WriteLine("Hi, I'm " + MedicalBot.GetBotName() + ". I'm here to help you in your medication.");
  System.Console.WriteLine("Enter your (patient) details:");

  // Create a new patient
  Patient patient = new Patient();

  // Read patient details and validate them
  System.Console.Write("Enter Patient Name: ");
  while (!patient.SetName(System.Console.ReadLine(), out string errorMessage))
  {
   Console.WriteLine(errorMessage);
   System.Console.Write("Enter Patient Name: ");
  }

  System.Console.Write("Enter Patient Age: ");
  while (!patient.SetAge(Convert.ToInt32(System.Console.ReadLine()), out string errorMessage))
  {
   Console.WriteLine(errorMessage);
   System.Console.Write("Enter Patient Age: ");
  }

  System.Console.Write("Enter Patient Gender: ");
  while (!patient.SetGender(System.Console.ReadLine(), out string errorMessage))
  {
   Console.WriteLine(errorMessage);
   System.Console.Write("Enter Patient Gender: ");
  }

  System.Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
  patient.SetMedicalHistory(System.Console.ReadLine());

  // Display patient details
  System.Console.WriteLine($"\nWelcome, " + patient.GetName() + ", " + patient.GetAge() + ".");
  System.Console.WriteLine("Which of the following symptoms do you have:");
  System.Console.WriteLine("S1. Headache");
  System.Console.WriteLine("S2. Skin rashes");
  System.Console.WriteLine("S3. Dizziness");

  // Read patient's symptom code and validate it
  System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
  while (!patient.SetSymptomCode(System.Console.ReadLine(), out string errorMessage))
  {
   Console.WriteLine(errorMessage);
   System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
  }

  // Create a new MedicalBot and prescribe medication for the patient
  MedicalBot doctorBot = new MedicalBot();
  doctorBot.PrescribeMedication(patient);

  // Display the prescription for the patient
  System.Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:");
  System.Console.WriteLine(patient.GetPrescription());

  // Goodbye message
  System.Console.WriteLine("\nThank you for coming.");
  System.Console.ReadKey();
 }
}