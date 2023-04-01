# CSC579 Program 5 - Breakout!

## Introduction
A Breakout game made by Unity built with WebGL.
The player can move the paddle left and right to reflect the ball. Bricks will disappear when the ball strikes them. When all bricks disappear, the game ends.
In order to quickly achieve the end of the game, the player can enter the cheat code “iLoveCSC561” in the upper right corner.
![pj](https://user-images.githubusercontent.com/60548996/229254902-3f619e39-eff8-45e7-8f23-b3e9d146273a.JPG)

## How To Start
There are three ways to run the game.
Host the local server from the “Project5WebGL” folder and run the “index.html” in the same folder
Open terminal and go the the “Project5WebGL” folder
Type “python -m http.server --cgi 8360” in the terminal
Go to http://localhost:8360/index.html to start the game
Or
In the unity hub, Open a new project from “CSC561_Proj5_jyang31” and in the “Scenes” folder open the “MainGame” scene. Hit play to run the game in Unity.
Or
In the unity hub, Open a new project from “CSC561_Proj5_jyang31” and then build&run the game.

## Control
Control:Left arrow key/A or Right arrow key/D to move the paddle left or right. R to activate the random bouncing. Space to reset the game

## EXTRA CREDIT
Track and display score: The score is displayed in the upper left corner. The player will get one point for each eliminated brick and lose one point for falling under the screen.
Add better/different physics. The ball's bounciness will change to random by pressing “R,” and the status is displayed on the top.


## Author
Jiacheng Yang(jyang31)



