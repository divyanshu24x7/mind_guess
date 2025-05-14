# 🧠 Mind Guess

An interactive console game in C# where **the computer** uses binary search to guess a number **you’ve** secretly chosen from a sorted list.

## Features

- ✅ Reads a sorted list of integers from your input  
- 🤫 You pick one of them _in secret_  
- 🤖 Computer narrows down the search space with **higher**, **lower**, or **correct** feedback  
- 🎨 Simple ASCII/colored CLI for a more playful experience  

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download) or higher

## Getting Started

1. **Clone** this repo  
   ```bash
   git clone https://github.com/yourusername/mind_guess.git
   cd MindGuess
2.Build the project
  dotnet build
3.Play the game
  dotnet run
  
How to Play
Enter a sorted sequence of integers (e.g. 1 4 7 8 10)

Secretly choose one of them in your mind

When prompted, reply with:

higher if your number is larger

lower if your number is smaller

correct when the computer guesses it

Enjoy watching the computer “think” in real time!
