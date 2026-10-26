using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Salvar");
            Console.WriteLine("4. Carregar");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                string answer = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = answer;

                journal._entries.Add(entry);
            }
        }
    }
}
