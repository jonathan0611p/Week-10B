# Week-10B
# CS110 / Action 10B / Three Hello World Investigations

Current phase: independent study with teams and tools.

## My transfer note / saved in the same README
R1 - Game research Game: Minesweeper Goal: The goal is to create functioning buttons that randomize each time the game is restarted. And to find the mines with the given information.
Player Action: Click on the different tiles to reveal if it is a mine or if it reveals a number. Feedback: I do not understand how this game works. I always end up clicking a mine,
despite counting the squares around the numbers. I believe that luck also plays a part in this game. Source Link: https://www.google.com/search?q=minesweeper&oq=mine&gs_lcrp=EgZjaHJv
bWUqBggAEEUYOzIGCAAQRRg7Mg0IARAuGIMBGLEDGIAEMgoIAhAuGLEDGIAEMgYIAxBFGDkyCggEEAAYsQMYgAQyCggFEAAYsQMYgAQyCggGEAAYsQMYgAQyCggHEC4YsQMYgAQyEAgIEAAYgwEYsQMYgAQYigUyBwgJEAAYjwLSAQgyMjMyajB
qN6gCALACAA&sourceid=chrome&ie=UTF-8

R2 - Three engines and my choice GODOT / supports both 2d AND 3d games / the two main languages supported are C# and GDScript / a useful feature is that it uses nodes so it is more 
organized and easier to navigate, and if you create a character or scene, you can reuse the exact scene anywhere else in the project / https://godotengine.org/ UNITY / supports both 
2d AND 3d games, however, 3d is used more / C# is the main language / it is easy to create props and maintain lighting / https://unity.com/ STRIDE / supports both 3d AND 3d games, 
focused more on 3d VR games / C# / it has VR support and is more open source / https://www.stride3d.net/ I would use Godot because out of the options listed, it seemed most beginner
friendly to me. The UI is similar to Visual Studio, and because I've used it before, I would find it easiest to navigate through. R3 - Discussion and object example Object: tile Two 
data values: is_mine, is_revealed One action/method: reveal_tile() My engine choice and reason: I chose Godot because it seems the most beginner friendly to me. And, the concept of 
nodes makes the UI easier to navigate. Partner feedback: My partner said that Godot is a good choice because the node-system makes it easier to organize and manage different parts of
minesweeper. Board evidence filename: mio_boardevidence

Evidence Board photo or accessible diagram: [filename] Receipt: cs110-10a-receipt.txt GitHub: https://github.com/jonathan0611p/Week-10 Canvas:


## Lecture investigation notes

The three concepts from todays lecture are those of Console, XAML and Engine that are all intertwined when creating the project.
One question that I had was how we came up with was how/or what are we going to use to combine everything into one place.
White board | Discord evidence |
We think that using the XAML would be the easiest and allow us to create 
We predict that if we focus on sticking with the same language till the end it will be the easiest to combine all aspects.
We tried using GODOT.NET framework and saw that it was becoming difficult because of the language it uses and the time that it takes because of all of how the nodes interact.
This means that we might have to move on from using GODOT and using a UI that allows easier access to C#.

C# = extraction of binary code. C# -- Hello World -- Variables -> Functions -> Classes -> XAML -> IDE

Hello World (C)

A variable is a container -- computer identifies by switching variable name into binary / 2 variables cannot have the same name (all code goes into class) 
Container for hello world: use a string

ex. string message = "hello world"; public (scope) void Display message (){ cw (message); } (void = -1 in binary)
## Console investigation notes

Prediction: We at a certain point would have to use AI 
What We tried: We used A.I to fix the code
Results: We had errors so we could not produce what we wanted


## XAML / WPF investigation notes

XAML makes a greet the "Fishers" and ask if they are ready, if so then it tells them to start fishing.
C# code- Makes the button greet the fishers and askes if they are ready to fish.
Prediction that everything would work and the button greets the fishers and asks if they are ready.
Results was an error but easily fixed as it was a misspelling in the code.
Next step is to put everything together to make the game.

## Engine investigation notes

I investigated Hello World using Godot 4.7.2 .NET for my Sharksweeper project. I expected my Greeting 
class to create a message using the BuildMessage() method and display it in the Output panel. My C#
version worked, but my GDScript version gave me an error because it couldn't find the Greeting class. 
I learned that a class is a blueprint, an object is an instance of that class, and _Ready() is a
callback that runs when a node is ready. My next test is to fix the error, change the name from
"Player" to "Mio," and check if the greeting updates. Documentation: https://docs.godotengine.org/en/
stable/tutorials/scripting/c_sharp/c_sharp_basics.html?utm_source=chatgpt.com


## Working arrangement
Group
Lead: Jonathan
Members / contributions: Daniel- Engine
Mio- Engine
Paul-  XAML
Isaias- COSOLE
Jonathan- Note, Github
Task | Owner | Status:
Console | Paul | Complete
XAML | Isaias | Complete
Engine | Daniel | In progress
Engine | Mio | Complete
Notes / Evidence / Github | Jonathan | Complete



## My handoff
GitHub: https://github.com/jonathan0611p/Week-10B
Required: Console/, WPF/, EngineTrial/, Evidence/ and cs110-10b-receipt.txt.
Canvas: https://sbccd.instructure.com/courses/66804/assignments/1913888
This record does not verify submission or grading.
