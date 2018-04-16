using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public static List<Question> AllQuestions;   
    
    // Use this for initialization
    void Start()
    {
        
        AllQuestions = new List<Question>();
        AllQuestions.Add(new Question("Come si trova l'area di un triangolo ? ", new List<string>() { " Base * Altezza / 2" }));
        AllQuestions.Add(new Question("Qunati decimetri sono 3,26 centimetri ? ", new List<string>() { " 0,326 decimetri" }));
        AllQuestions.Add(new Question("Guidando a 120km orari , quanti km percorro in 20 minuti ? ", new List<string>() { " 40 km" }));
        AllQuestions.Add(new Question("Quale di questi numeri ( 241 , 363 , 913 ) è divisibile per 3 ? ", new List<string>() { " 363" }));
        AllQuestions.Add(new Question("Con quale numero indica la cifra romana XXVIII ? ", new List<string>() { " 28" }));
        AllQuestions.Add(new Question("Quanti litri abbiamo nel 30% di un litro e mezzo d'acqua ? ", new List<string>() { " 0,3 liters" }));

        AllQuestions.Add(new Question("Find the missing possessive adjective - John drive ... car", new List<string>() { " His" }));
        AllQuestions.Add(new Question("which animal have 4 legs ? bird , dog , human ", new List<string>() { " The dog" }));
        AllQuestions.Add(new Question("What does -food- mean ? ", new List<string>() { " Something to eat" }));
        AllQuestions.Add(new Question("Which number is between eleven and thirteen ? ", new List<string>() { " Twelve" }));
        AllQuestions.Add(new Question("Which day is after tuesday ? ", new List<string>() { " Wednesday" }));
        AllQuestions.Add(new Question("What color is the snow ? ", new List<string>() { " White" }));

        AllQuestions.Add(new Question("Quale città non è in Italia ? Milano , Venezia , Tripoli ", new List<string>() { " Tripoli" }));
        AllQuestions.Add(new Question("Tokyo è la capitale di quale stato ? ", new List<string>() { " Giappone" }));
        AllQuestions.Add(new Question("Quale è l'isola più grande del mondo ? ", new List<string>() { " Groenlandia" }));
        AllQuestions.Add(new Question("Quanti stati ci sono in America ? ", new List<string>() { " 50 stati" }));
        AllQuestions.Add(new Question("Quale è il fiume più lungo dell'Africa ? ", new List<string>() { " Nilo" }));
        AllQuestions.Add(new Question("Quale è l'oceano più piccolo dei 3 che conosciamo ? ", new List<string>() { " Oceano Indiano" }));

        AllQuestions.Add(new Question("In quale stato avvenne il primo conflitto della seconda guerra mondiale ? ", new List<string>() { " Polonia" }));
        AllQuestions.Add(new Question("Quale civiltà costruì le piramidi ? ", new List<string>() { " Egiziana" }));
        AllQuestions.Add(new Question("Quando è stata scoperta l'America ? ", new List<string>() { " Nel 1942" }));
        AllQuestions.Add(new Question("Chi ha costruito la cosidetta Grande Muraglia ? ", new List<string>() { " Il popolo cinese" }));
        AllQuestions.Add(new Question("In che anno è caduto il muro di Berlino ? ", new List<string>() { " Nel 1989" }));
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
    public class Question
    {
        public string AQuestion;

        List<string> CorrectAnswers;

        public Question(string question, List<string> correctAnswer)
        {
            AQuestion = question;
            CorrectAnswers = correctAnswer;
        }

    }

    public static Question GetRandom()
    {
        return AllQuestions[Random.Range(0, AllQuestions.Count)];
    }
}
