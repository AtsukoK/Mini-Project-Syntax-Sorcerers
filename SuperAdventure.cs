public class AdventureGame
{
    private Location _playerCurrentLocation;

    public AdventureGame()
    {
        _playerCurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
    }

    public void Launch()
    {
        while (true)
        {
            ShowLocationInfo();

            string userInput = Console.ReadLine();

            ProcessUserInput(userInput);
        }
    }

    private void ShowLocationInfo()
    {
        Console.Clear();
        Console.WriteLine($"You find yourself in {_playerCurrentLocation.Name}.");
        Console.WriteLine($"{_playerCurrentLocation.Description}");
        Console.WriteLine();
        
        if(_playerCurrentLocation.QuestAvailableHere != null)
        {
            Console.WriteLine($"[Q] Speak with {_playerCurrentLocation.Name} resident about an adventure.");
        }

        Console.WriteLine("Paths you can take:");
        if (_playerCurrentLocation.LocationToNorth != null)
        {
            Console.WriteLine("[N] Head North towards " + _playerCurrentLocation.LocationToNorth.Name);
        }
        if (_playerCurrentLocation.LocationToEast != null)
        {
            Console.WriteLine("[E] Head East towards " + _playerCurrentLocation.LocationToEast.Name);
        }
        if (_playerCurrentLocation.LocationToSouth != null)
        {
            Console.WriteLine("[S] Head South towards " + _playerCurrentLocation.LocationToSouth.Name);
        }
        if (_playerCurrentLocation.LocationToWest != null)
        {
            Console.WriteLine("[W] Head West towards " + _playerCurrentLocation.LocationToWest.Name);
        }
        Console.WriteLine("[Z] Quit the Adventure");
    }

    private void ProcessUserInput(string userInput)
    {
        switch (userInput.ToUpper())
        {
            case "N":
                if (_playerCurrentLocation.LocationToNorth != null)
                    _playerCurrentLocation = _playerCurrentLocation.LocationToNorth;
                else
                    InvalidMoveMessage();
                break;
            case "E":
                if (_playerCurrentLocation.LocationToEast != null)
                    _playerCurrentLocation = _playerCurrentLocation.LocationToEast;
                else
                    InvalidMoveMessage();
                break;
            case "S":
                if (_playerCurrentLocation.LocationToSouth != null)
                    _playerCurrentLocation = _playerCurrentLocation.LocationToSouth;
                else
                    InvalidMoveMessage();
                break;
            case "W":
                if (_playerCurrentLocation.LocationToWest != null)
                    _playerCurrentLocation = _playerCurrentLocation.LocationToWest;
                else
                    InvalidMoveMessage();
                break;
            case "Q":
                if (_playerCurrentLocation.QuestAvailableHere != null)
                {
                    Console.WriteLine($"You conversed with the resident of {_playerCurrentLocation.Name} and took up the challenge: {_playerCurrentLocation.QuestAvailableHere.Name}");
                    // Place to add quests.
                }
                break;
            case "Z":
                Console.WriteLine("Do you really wish to quit? (y/n)");
                string quitResponse = Console.ReadLine();
                if (quitResponse.ToLower() == "y")
                    Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid direction or action.");
                break;
        }
    }

    private void InvalidMoveMessage()
    {
        Console.WriteLine("Where are you going? You can't head there.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

class AdventureGameLaunch
{
    static void Main(string[] args)
    {
        AdventureGame adventureGame = new AdventureGame();
        adventureGame.Launch();
    }
}
