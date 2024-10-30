classDiagram
    class Program {
        +Main() static$
    }

    class Game {
        -Room? currentRoom
        -Room? previousRoom
        +Game()
        -CreateRooms()
        +Play()
        -Move(string direction)
        -PrintWelcome() static$
        -PrintHelp() static$
    }

    class Room {
        +string ShortDescription
        +string LongDescription
        +Dictionary~string,Room~ Exits
        +Room(string shortDesc, string longDesc)
        +SetExits(Room? north, Room? east, Room? south, Room? west)
        +SetExit(string direction, Room? neighbor)
    }

    class Command {
        +string Name
        +string? SecondWord
        +Command(string name, string? secondWord)
    }

    class Parser {
        -CommandWords commandWords
        +Command? GetCommand(string inputLine)
    }

    class CommandWords {
        +List~string~ ValidCommands
        +IsValidCommand(string command)
    }

    Program --> Game : creates
    Game --> Room : contains
    Game --> Parser : uses
    Parser --> CommandWords : contains
    Parser --> Command : creates
    Room --> Room : references
