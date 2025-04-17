using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE
{
    internal class Response
    {
        public static void ShowHelp(string name)
        {
            while (true)
            {
                Console.Write($"\n🤖 {name}, ask me a question: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠️ I didn't catch that. Can you rephrase?");
                    continue;
                }

                if (input.Contains("exit")) break;

                // Responses to user questions
                if (input.Contains("password"))
                {
                    Console.WriteLine("🔐 Use long, complex passwords with a mix of letters, numbers, and symbols. Consider using a password manager.");
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine("🎣 Be cautious of emails or messages that ask for personal information. Always verify the sender.");
                }
                else if (input.Contains("safe browsing"))
                {
                    Console.WriteLine("🛡️ Avoid clicking on unknown links and keep your browser and antivirus software updated.");
                }
                else if (input.Contains("who are you") || input.Contains("purpose"))
                {
                    Console.WriteLine("💬 I'm here to help you learn about staying safe online and becoming more aware of cybersecurity threats.");
                }
                else if (input.Contains("2fa") || input.Contains("two-factor"))
                {
                    Console.WriteLine("🔒 Two-factor authentication adds an extra layer of protection by requiring a second form of verification.");
                }
                else if (input.Contains("firewall"))
                {
                    Console.WriteLine("🚧 A firewall helps block unauthorized access to your devices and network.");
                }
                else if (input.Contains("malware"))
                {
                    Console.WriteLine("🐛 Malware includes viruses, worms, spyware, and ransomware. Keep your software updated and avoid downloading unknown files.");
                }
                else if (input.Contains("vpn"))
                {
                    Console.WriteLine("🌐 A VPN encrypts your internet connection, helping protect your data on public Wi-Fi.");
                }
                else if (input.Contains("antivirus"))
                {
                    Console.WriteLine("🧰 Antivirus software helps detect and remove malicious software from your device.");
                }
                else if (input.Contains("social engineering"))
                {
                    Console.WriteLine("🎭 Social engineering is the act of tricking people into revealing confidential information. Always verify identities.");
                }
                else if (input.Contains("public wi-fi"))
                {
                    Console.WriteLine("📶 Avoid accessing sensitive accounts over public Wi-Fi. Use a VPN for safer browsing.");
                }
                else if (input.Contains("software update") || input.Contains("update"))
                {
                    Console.WriteLine("🔄 Keep your software and operating system updated to patch security vulnerabilities.");
                }
                else if (input.Contains("data breach"))
                {
                    Console.WriteLine("📢 If your data is compromised in a breach, change your passwords immediately and monitor your accounts.");
                }
                else
                {
                    Console.WriteLine("🤔 I'm not sure how to answer that. Try asking about passwords, phishing, VPNs, or firewalls.");
                }
            }

            Console.WriteLine("\n👋 Goodbye! Stay safe out there.");
        }
    }
}
