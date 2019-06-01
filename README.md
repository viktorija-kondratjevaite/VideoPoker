# Visma Video Poker 
Repository for Video Poker C# console application homework made by [Viktorija Kondratjevaitė](https://www.linkedin.com/in/viktorija-kondratjevait%C4%97/).

## Working functionality
* User can be dealt 5 random cards.
* User can choose to discard one of those five cards and is dealt a new one in it's place.
* User can choose to have his five cards evaluated and get a prize according to the hand combination.
* After the evaluation, game state is restarted - the whole hand is discarded.

## Assumptions
* It is assumed that playing deck consists not of 52 playing cards, but of unlimited amount of decks combined into one.
* It is assumed that drawing a card does not reduce or increase a chance of another card being drawn.
* It is assumed that game state can only have one combination of five cards at one time. Otherwise, one more class for PlayingHand can be added and it can hold a List of 5 cards.

## Technical comments
* Console application was created with C# programming language and .Net Framework.
* Detection of Poker Hand combinations (PokerHandEvaluator.cs) methods are fully tested with real hand combinations taken from [this poker hand spreadsheet from Wikipedia]( https://en.wikipedia.org/wiki/List_of_poker_hands#Hand-ranking_categories )
 * PokerHandEvaluator methods can possibly be improved, because they are sending the same list accross all the checks.
 * More null checks and exception handling can be added, input is barely validated but it should be :) 

