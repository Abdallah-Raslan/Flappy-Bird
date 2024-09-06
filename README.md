# Flappy Bird Game

This is a simple Flappy Bird clone created as a practice project using Unity. The game features a parallax background, automated pipe generation, and basic player movement mechanics. The gameplay includes starting the game, navigating through obstacles, and handling game-over scenarios.

## Features

- **Parallax Background**: A smooth scrolling background effect to give a sense of depth.
- **Automated Pipe Generator**: Pipes appear at random heights with a fixed vertical gap, moving across the screen.
- **Player Movement**: Control the bird with simple input (spacebar or mouse click) to make it fly.
- **Gameplay Mechanics**: Start the game, avoid obstacles, score points, and respawn after a game over.

## How to Play

1. **Start the Game**: Press the play button to begin.
2. **Controls**: Press the `Space` key or left mouse button to make the bird fly upwards.
3. **Avoid Obstacles**: Navigate the bird through the gaps between the pipes.
4. **Scoring**: Pass through the pipes to increase your score.
5. **Game Over**: Colliding with the pipes ends the game. Press the play button to restart.

## Scripts Overview

- **Player.cs**: Manages player movement, gravity, and collision detection.
- **Spawner.cs**: Automatically generates and positions pairs of pipes at regular intervals.
- **Pipes.cs**: Controls the movement of pipes and handles their destruction when they exit the screen.
- **Parallax.cs**: Implements the smooth scrolling effect for the background.
- **GameManager.cs**: Manages the game state, including starting, pausing, game over, and score tracking.

## License
This project is for educational purposes and is distributed under the MIT License.

