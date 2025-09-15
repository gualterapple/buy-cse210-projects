using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string prompt, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("----------------------------");
    }

    // Método auxiliar para salvar como texto
    public string ToFileFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    // Método auxiliar para recriar um Entry a partir de uma linha do arquivo
    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            Entry entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0]; // preserva a data original
            return entry;
        }
        return null;
    }
}