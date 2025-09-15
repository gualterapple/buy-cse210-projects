using System;

public class Entry
{
    // Atributos
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // Construtor
    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    // Método para exibir a entrada
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("---------------------------------");
    }

    // Método para converter para string de arquivo
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // Método para criar Entry a partir de linha de arquivo
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        Entry entry = new Entry(parts[1], parts[2]);
        entry.Date = parts[0];
        return entry;
    }
}
