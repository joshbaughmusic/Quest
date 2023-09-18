using Quest;

// Create a few challenges for our Adventurer's quest
// The "Challenge" Constructor takes three arguments
//   the text of the challenge
//   a correct answer
//   a number of awesome points to gain or lose depending on the success of the challenge
Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
Challenge twoPlusThree = new Challenge("2 + 3?", 5, 10);
Challenge twoPlusFour = new Challenge("2 + 4?", 6, 10);
Challenge twoPlusFive = new Challenge("2 + 5?", 7, 10);
Challenge twoPlusSix = new Challenge("2 + 6?", 8, 10);
Challenge theAnswer = new Challenge(
    "What's the answer to life, the universe and everything?", 42, 25);
Challenge whatSecond = new Challenge(
    "What is the current second?", DateTime.Now.Second, 50);

int randomNumber = new Random().Next() % 10;
Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

Challenge favoriteBeatle = new Challenge(
    @"Who's your favorite Beatle?
1) John
2) Paul
3) George
4) Ringo
",
    4, 20
);

// "Awesomeness" is like our Adventurer's current "score"
// A higher Awesomeness is better

// Here we set some reasonable min and max values.
//  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
//  If an Adventurer has an Awesomeness less than the min, they are terrible
int minAwesomeness = 0;
int maxAwesomeness = 100;

List<string> robeColors = new List<string> {
    "red",
    "blue",
    "purple"
};

Robe myRobe = new Robe()
{
    Colors = robeColors,
    Length = 80
};

Hat myHat = new Hat()
{
    ShininessLevel = 7
};

Prize prize = new Prize("1 gold coin");


bool playAgain = true;

while (playAgain)
{

// Make a new "Adventurer" object using the "Adventurer" class
Console.WriteLine($"Enter your name to begin your adventure:");

string adventurerNameInput = Console.ReadLine();


Adventurer theAdventurer = new Adventurer(adventurerNameInput, myRobe, myHat);

// A list of challenges for the Adventurer to complete
// Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
List<Challenge> challenges = new List<Challenge>()
{
    twoPlusTwo,
    twoPlusThree,
    twoPlusFour,
    twoPlusFive,
    twoPlusSix,
    theAnswer,
    whatSecond,
    guessRandom,
    favoriteBeatle
};




Console.WriteLine(theAdventurer.GetDescription());

// Loop through all the challenges and subject the Adventurer to them
for (int i = 0; i < 5; i++)
{
    int randomChallengeNumber = new Random().Next() % 10 - 1;
    challenges[randomChallengeNumber].RunChallenge(theAdventurer);
}

// This code examines how Awesome the Adventurer is after completing the challenges
// And praises or humiliates them accordingly
if (theAdventurer.Awesomeness >= maxAwesomeness)
{
    Console.WriteLine("YOU DID IT! You are truly awesome!");
}
else if (theAdventurer.Awesomeness <= minAwesomeness)
{
    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
}
else
{
    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
}

Console.WriteLine($"Your reward is:");
prize.ShowPrize(theAdventurer);


Console.WriteLine($"Would you like to repeat the quest?");

string playAgainInput = Console.ReadLine();

if (playAgainInput == "no")
{
    playAgain = false;
}
}