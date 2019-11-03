using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuestionPicker : MonoBehaviour
{
    public TextMeshProUGUI Question;

    // Start is called before the first frame update
    void Start()
    {
        string[] questions = {
            "What is your favorite thing that your boyfriend or girlfriend does?",
            "Tell me about your most awkward date.",
            "Who is the sexiest person here?" ,
            "What would you do if you were the opposite sex for a month?",
            "What is the most embarrassing photo you have on your phone?" ,
            "Have you ever made out with someone here?" ,
            "Who is the person you most regret kissing?" ,
            "What is the most embarrassing thing your parents have caught you doing?" ,
            "Who here has the nicest butt?" ,
            "When was the most inappropriate time you farted?" ,
            "Have you ever let someone take the blame for something you did?" ,
            "What is the biggest thing you\'ve gotten away with?" ,
            "What is the most childish thing you still do?" ,
            "What is the most embarrassing thing in your room?" ,
            "Where is the strangest place you have peed?" ,
            "When was the last time you peed in bed?" ,
            "What do most people think is true about you, but isn\'t?",
            "What terrible thing have you done that you lied to cover up?" ,
            "What is the scariest dream you have ever had?" ,
            "What is the grossest thing you have had in your mouth?" ,
            "What do most of your friends think about you that is totally untrue?",
            "When was the last time you picked your nose without a tissue?" ,
            "What do you really hope your parents never find out about?" ,
            "What is the most embarrassing thing you have put up on social media?",
            "Tell us your most embarrassing vomit story." ,
            "Who is your crush?" ,
            "What is the most embarrassing picture of you?" ,
            "Who here would you most like to make out with?" ,
            "What was the most awkward romantic encounter you have had?" ,
            "What is the naughtiest thing you\'ve done in public?" ,
            "What was the cruelest joke you played on someone?" ,
            "What pictures or videos of you do you wish didn\'t exist?",
            "What is the biggest lie you have ever told?" ,
            "What is something that people think you would never do but you have?" ,
            "What is the most embarrassing nickname you have ever had?" ,
        };
        System.Random r = new System.Random();
        int randomNumber = r.Next(questions.Length);

        Question.text = questions[randomNumber];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
