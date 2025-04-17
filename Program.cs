using static System.Net.Mime.MediaTypeNames;

namespace ProgPOE
{
    class CyberChatBot
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Play welcome voice message
            Recording.PlayVoiceGreeting();

            // Display ASCII art logo
            Image.DisplayAsciiLogo();

            // Ask user for their name
            string userName = GetUserName();

            // Display welcome message
            DisplayWelcomeMessage(userName);

            // Start chatbot help session
            Response.ShowHelp(userName);
        }


        static string GetUserName()
        {
            Console.Write("\n Please enter your nam: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }
            return name;
        }

        static void DisplayWelcomeMessage(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n Hello, {name}, I'm your Cybersecurity Awareness Bot.");
            Console.WriteLine("Ask me about passwords, phishing, or safe browsing. Type 'exit' to quit.");
            Console.ResetColor();
        }

    }
}
