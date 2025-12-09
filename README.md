Using the advance hologram shader as a base, i made it so that overtime, it will swap back and fourth between 2 different colours, each for the lines, and rim effect. The holograms are applied to the walls of the stage, because in the base game, they have similar features.
The hologram colour change has 2 variables to change the speed individually of the lines and rim, but it is recommend to keep them the same, as they will desync. I made the transitioning colours into colour palettes so they match each other, so having them desync could look odd, unless all 4 colours match well.

<img width="939" height="540" alt="image" src="https://github.com/user-attachments/assets/1a0934b8-5009-43a5-bf14-98ce16bfe05e" />

How it works is that to loop back and fourth, it uses a sine so that instead of looping back and cutting to the beggining, once it reaches the second colour, it transitions back to the first colour. It multiplies 0.5f, as it is the midground from 0 - 1, and it is multiplied by 6.28318530718, because it is 2pi, which is the standard speed for sin waves per second.
It then takes that variable of the sine change speed, and uses that in a lerp, so that it can lerp between the 2 colours, and output the colour transitioning.
It does the same thing for both the Lines and Rim.

<img width="1029" height="950" alt="image" src="https://github.com/user-attachments/assets/9eb7d827-7b3d-4287-a502-49919c64acac" />
<img width="963" height="963" alt="image" src="https://github.com/user-attachments/assets/fe33377d-1f7a-4b83-81d1-12550ad6c23a" />

It could also be used when Pacman picks up a powerup or goes to the next stage, a new colour palette replaces the current one to add that visual diversity.

I also made it so that as you gain score (PRESS SPACE), it will increase the speed in which the colours transition, to add a bit of exitement and panic, as in base pacman, the game gets faster as it goes on, so if the transitioning effect also wasnt changing speed, it wouldn't feel as matching to the current pace of the game.
(PRESS R TO RESET SCORE)

<img width="973" height="606" alt="image" src="https://github.com/user-attachments/assets/d8e5c7da-0cf4-4c6c-9076-cfc4f2a88fb8" />

The background also scrolls, with a gradient theme to match the walls. Idealy, it would be a seamlessly looping background, but I could not find one. The background scroll speed is also affected by the increase in score, to match the pace of the game.

(PRESS F)
When changing stages in the base game, a new level simply spawns in quickly to existance and the game continues. I wanted to add a special effect, so when the stage is loading in more pellets, it will use the water wave effect on a plane.
From the top down view of the camera, it looks pretty cool, and so that it doesn't comletely block the game, I made it so its transparent.

<img width="1807" height="1004" alt="image" src="https://github.com/user-attachments/assets/0e821363-3a27-4993-b93e-375056481390" />

The pellets use a rim shader, as there are many of them, so I want them to stand out in some way, contrasting from the darker background, but not being too distracting. The light rim glow effect works great.

<img width="364" height="288" alt="image" src="https://github.com/user-attachments/assets/5d7c5b6e-609f-494a-82f4-95d57e525912" />

The Pacman player character, along with the ghost use the basic outline, as they are the more key gameobjects, so having a more destinct outline is important. The edible ghost when Pacman picks up a powerup also have a different colour.

<img width="354" height="127" alt="image" src="https://github.com/user-attachments/assets/3b952866-7fd4-45c0-90d3-a7c5ec255787" />
