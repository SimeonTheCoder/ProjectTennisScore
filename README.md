# Tennis Score App
By Simeon Petkov
A school project

A simple C# .NET Windows Forms application for a school project that tracks the score of tennis matches.

# Features
- Inputting new matches
- Live ranking
- Latest matches
- Look at each player individually
- Regex search
- Validations

# Adding a new match

![Alt text](home.png)

After pressing the Add New Game button, we're taken to the Add New Game Form:

![Alt text](enter_empty.png)

Let's say we make a mistake while entering the data. The error validation will point us to the issue.

![Alt text](enter_error.png)

*The data is validated using a Regex that allows multiple name formats:*

- [Name Name]
- [I. Name]
 
After entering the data correctly,
![Alt text](enter_data.png)

We can see that the match has been added to the home view and the ranking - updated:

![Alt text](after.png)

# Player Information Window

If we click on a player, we can see information about their games and matches:

![Alt text](player_view.png)

If we want to search for specific players in the home view, you can use the search feature that utilizes Regex to filter out the matches.