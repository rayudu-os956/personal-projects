class Program
{
 static void Main()
 {
  Question question1 = new Question(); //Create an object of Question class and pass no arguments to the constructor
  Question question2 = new Question("In which continent is costa rica situated?"); //Create an object of Question class and pass value for questionText only to the constructor.
  Question question3 = new Question("In which continent is costa rica situated?", "Asia", "North America", "South America", "Africa", 'B'); //Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
  Question question4 = new Question() { questionText = "In which continent is costa rica situated?", optionA = "Asia", optionB = "North America", optionC = "South America", optionD = "Africa" }; //Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
 }
}