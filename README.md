# Orbital-Pacman
**Made by**: 

Lim Jun Cheng & Ong Guan Hong Malcolm

![PacMan Poster](https://i.ibb.co/CHV9tnb/2202.png)


**Motivation**:

Want to have fun and relieve stress with your friends? Play our modified version of PacMan and relive your childhood memories!

At the same time, to make PacMan more engaging, we have decided to augment the game with a pop quiz as an additional element of surprise and competition.

For players who think that PacMan is too simple of a game, we have included altered special components to the game to make it extra challenging at higher levels.


**Aim**: 

We hope that we can bring about a fresh twist to a beloved classic and more importantly, we want our users to have fun and learn something new whilst playing our game.


**User Stories & Feedback**:

Priority Legend:

1 : low (possible extension)

2 : medium (feature)

3 : high (core feature)

| Priority      | As a...   | I Want... | So I Can... |
|:-------------:|:---------:|:-----:|:-----:|
| 2 | new user | to know how the game works and how the game should be played | enjoy playing the game smoothly without any unnecessary disruptions |
| 3 | user | to select the appropriate game difficulty (easy, medium, hard) | progress and improve my skills step-by-step |
| 3 | user | to select my own pop quiz topics | utilize my specific trivia expertise |
| 2 | user | to create an account | store my personal collectibles as well as win rates and rankings amongst friends |
| 2 | administrator | to be able to access/delete an account | assist the user by fixing bugs in high-score recording or password resets |


To address the educational aspect of the Pop-Quiz components, we now clarify that this component is meant mainly for entertainment purposes and was made to emulate the fun of classic quiz games such as Quizarium and Kahoot; as such, players should not be misled into thinking that such a game would be educational, but should instead view the Pop-Quiz as a fun competitive challenge among friends.

As requested, we have also added certain elements to the game such as multiple unique levels to traverse. Also, there are plans underway to diversify the gameplay by adding more exciting game modes, which will be elaborated below in our features list.


**Scope of Project (as of Milestone 2)**:

To account for the ever-changing COVID-19 situation, we have decided to scrap the idea of local multiplayer for our PacMan game and instead focus on supporting online multiplayer so that you can play this game with your friends from the comfort of your own home! 

As such, we have decided to delay the completion of the multiplayer feature to prepare for the introduction of a much more exciting game mode… which will be described below as part of our future extensions! Let us look at our features:

*Current Features supported*:

* Single-Player Game: classic PacMan game has been implemented, complete with background music, sound effects and most importantly, enemy ghosts which work as intended in the original. Details about ghosts can be obtained here:
  * Blinky (the red ghost) will directly track and chase pacman’s current map position
  * Pinky (the pink ghost) will target 4 spaces ahead of pacman’s current map position
  * Inky (the cyan ghost) will try to corner blinky with its “random” movement pattern, targeting a tile by taking 2 spaces ahead of pacman and doubling the distance Blinky is away from it
  * Clyde (the orange ghost) moves according to how far away he is from pacman’s current map position. When he is more than 8 tiles away from pacman, his movements are identical to Blinky. When within 8 tiles from pacman, he will attempt to escape to its scatter position and “hide” there
* Pop-Quiz Section: in single-player mode, a pop-quiz section pops up when you complete a level or lose a life. Select any topic from a current pool of 4 and answer a random question; an extra powerup if you get it right, or none if you do not, and then the game resumes as per normal! Speaking of powerups:
* Powerups: We currently have 3 different powerups that PacMan can use to gain an edge (?) in the game: 
  * Reverse mode: Movement are reversed for the pacman player but it includes a huge score multiplier
  * Frozen mode: All ghosts are frozen for a specific amount of time according to the game difficulty
  * Sped up mode: Pacman’s speed is doubled
  * (Bonus) An extra life is given when the pacman image is eaten
  * (Bonus) Extra points are obtainable during the game as they will randomly spawn at different positions
* Multiple Levels: Bored of the normal PacMan level? We now have 4 more specially handmade levels you can choose from in our level select panel!
* Pre-selectable difficulty: different levels of difficulty to accommodate any player’s comfort level: from casual couch play to gruelling gameplay that will test your skills! Freely pick your difficulty when you begin the game. (as requested, this feature would be omitted from multiplayer since it would become irrelevant for our new game mode as well)
* Scoring System: this will be used to keep track of the current score; as of now we only have the local leaderboard up and running. In more detail:
  * Included an option to reset the high score under options
  * Increasing difficulty for players upon completion of a level
  * Shorter scatter time
  * Shorter frightened duration
  * Quicker ghost release duration
  * Faster ghost speed to intensify the game
  * Shorter powerup duration
  * Scale the points for players at higher levels accordingly
  * Increase points for every pellet
  * Points bonus upon hitting certain points milestones (eg 10k + 1k, coming soon!)

*Future features you can look forward to*:

* Online Multiplayer support: instead of pitting 4 ghost players against one PacMan player (since that’s unfair as hell), we have decided to make a free-for-all battleground using the PacMan maze arena as the background; the last player standing wins the game!
  * 4 players at maximum; all players will play as the PacMan character and take out the others! Beware though; all players still have 3 lives and you have to snuff them all out to completely purge a player from the game!
  * Power pellets will be consumed to allow PacMan to consume other players
  * New power ups specially created to deal with PacMan players: details will be unveiled when we release the game for Milestone 3
  * Pop-Quiz components will pop up during the game to allow players to gain an edge (pending evaluator reviews, may include an option to turn it off?)
  * Yeah this is PUBG-2D lol
* Account creation: we may use this to track the win rates and the global ranking for each individual player, as well as aesthetic collectibles for personal customisation of characters (guest accounts can be introduced to prevent the hassle of creating an account if players want to enjoy a casual game)


**Program Flow**: 



**Project Log**:

Attached in the google sheets link below:
https://docs.google.com/spreadsheets/d/1vynugZxHNRf-YQlReQH22FfF6jUho-ndIfiMQ2shWDk/edit?usp=sharing

