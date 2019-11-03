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
            "Imitate a celebrity every time you talk for three minutes." ,
            "Kiss the person to your left.",
            "What would you do if you were the opposite sex for a month?",
            "What is the most embarrassing photo you have on your phone?" ,
            "Sit in a spinning chair and have the group spin you for 30 seconds. Might help to hold a trash can just in case.",
            "Have you ever made out with someone here?" ,
            "Transfer an ice cube from your mouth to the person\'s mouth on your right." ,
            "Sell a piece trash to someone in the group. Use your best salesmanship." ,
            "Beg and plead the person to your right not to leave you for that other boy or girl. Weeping, gnashing of teeth, and wailing is encouraged.",
            "Bend at the waist so that you are looking behind you between your legs. Now run backwards until you can tag someone with your butt." ,
            "Who is the person you most regret kissing?" ,
            "What is the most embarrassing thing your parents have caught you doing?" ,
            "Who here has the nicest butt?" ,
            "Dance to a song of the group\'s choosing." ,
            "Do push ups until you can\'t do any more, wait 5 seconds, and then do one more." ,
            "Make every person in the group smile, keep going until everyone has cracked a smiled." ,
            "Spin an imaginary hula hoop around your waist for 3 minutes while the game continues." ,
            "Stick your arm into the trash can past your elbow." ,
            "Do your best impression of a baby being born." ,
            "When was the most inappropriate time you farted?" ,
            "Tell me about your first kiss." ,
            "Try to juggle 2 or 3 items of the group\'s choosing." ,
            "Gargle something that shouldn\'92t be gargled, but won\'92t hurt you." ,
            "Act like whatever animal someone yells out for the next 1 minute." ,
            "Compose a poem on the spot based on something the group comes up with." ,
            "Have you ever let someone take the blame for something you did?" ,
            "Call the 7th contact in your phone and sing them 30 seconds of a song that the group chooses." ,
            "Let the group pose you in an embarrassing position and take a picture." ,
            "What is the biggest thing you\'ve gotten away with?" ,
            "Get slapped on the face by the person of your choosing." ,
            "Curse like sailor for 20 seconds straight." ,
            "No talking. Pretend to be a food. Don\'t pretend to eat the food, pretend to be the food. Keep pretending until someone in the group guesses the food you are." ,
            "What is the most childish thing you still do?" ,
            "What is the most embarrassing thing in your room?" ,
            "Where is the strangest place you have peed?" ,
            "Give someone your phone and let them send one text to anyone in your contacts." ,
            "Switch clothes with someone of the opposite sex in the group for three rounds." ,
            "Let the group give you a new hairstyle." ,
            "When was the last time you peed in bed?" ,
            "Sniff the armpits of everyone in the room." ,
            "What do most people think is true about you, but isn\'t?",
            "Post an extremely unflattering picture of yourself to the social media outlet of your choosing." ,
            "What terrible thing have you done that you lied to cover up?" ,
            "After the group chooses one rude word, sing a song and insert that rude word once into every line of the song." ,
            "Choose someone from the group to give you a spanking." ,
            "What is the scariest dream you have ever had?" ,
            "What is the grossest thing you have had in your mouth?" ,
            "Walk on your hands from one side of the room to the other." ,
            "You can ask someone to hold your legs if necessary." ,
            "Play a song on by slapping your butt cheeks till someone guesses the song.",
            "What do most of your friends think about you that is totally untrue?",
            "When was the last time you picked your nose without a tissue?" ,
            "What do you really hope your parents never find out about?" ,
            "What is the most embarrassing thing you have put up on social media?",
            "Tell us your most embarrassing vomit story." ,
            "Who is your crush?" ,
            "What is the most embarrassing picture of you?" ,
            "Jump up and down as high as you can go for a full minute." ,
            "Who here would you most like to make out with?" ,
            "Sing a praise song about a person of the groups choosing." ,
            "Make up a 30 second opera about a person or people in the group and perform it." ,
            "What was the most awkward romantic encounter you have had?" ,
            "Seduce a member of the same gender in the group." ,
            "Make a funny face and keep making it for 2 minutes while the game continues." ,
            "Poll dance for 1 minute with an imaginary pole." ,
            "What is the naughtiest thing you\'ve done in public?" ,
            "Attempt to do a magic trick." ,
            "What was the cruelest joke you played on someone?" ,
            "What pictures or videos of you do you wish didn\'t exist?",
            "Imitate popular YouTube videos until someone can guess the video you are imitating." ,
            "What is the biggest lie you have ever told?" ,
            "Belly dance like your life depended on it." ,
            "Dance with no music for 1 minute." ,
            "Attempt to break dance for 30 seconds." ,
            "Let the group look through your phone for 2 minutes." ,
            "What is something that people think you would never do but you have?" ,
            "What is the most embarrassing nickname you have ever had?" ,
            "Find the person whose first name has the same letter as your first name or whoever\'s first name\'s first letter is closest to yours. Now lick their face."
        };
        System.Random r = new System.Random();
        int randomNumber = r.Next(questions.Length);

        Question.text = questions[randomNumber];

        Debug.Log(
            "$Truth: {questions[randomNumber]}"
        );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
