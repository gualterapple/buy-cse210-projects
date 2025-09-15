using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adicionar nova entrada
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Exibir todas as entradas
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Salvar em arquivo
    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    // Carregar de arquivo
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            _entries.Add(Entry.FromFileString(line));
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
