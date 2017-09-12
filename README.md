# FlappyBird Application

## Introduction
This simple game is a clone of "legendary" Flappy Bird mobile game. Application was written in C# (windows forms) and IronPython. The "game" part of the application is coded in C#. Highscore table that is shown after the game finishes and player enters his/hers name is programmed in IronPython (extern script). IronPython module "Pickle" was used to easily import and export needed data to/from separate file. In current version there are no known bugs.

## Game Controls
A player controls the bird with "space" key. After pressing the key, the bird jumps and therefore stays in the air. Don't let the bird touch obstacles!
With "R" key the player can restart the game.
After finishing, user can enter his or hers name and make it to the highscore table!(if score is higher than other scores)

## Possible improvements in future
- Recreating a game in dedicated game engine in order to improve performance and making it easier to develop further
- Making game harder as time passes, e.g. obstacles become faster, larger or bird moves slower and jumps less
- Implementing online high score table, so players can compete with other players around the world

## Screen examples:

### -Start screen:
![start](https://user-images.githubusercontent.com/25162648/30290616-49157922-9730-11e7-9e76-7296b7a75976.jpg)

### -Game over screen:
![gameover](https://user-images.githubusercontent.com/25162648/30290693-9f1d0de4-9730-11e7-8fb6-c895fcaa15bb.jpg)

### -Screen after entering a name:
![scores](https://user-images.githubusercontent.com/25162648/30290985-9de94734-9731-11e7-9a11-37366fa37800.jpg)
