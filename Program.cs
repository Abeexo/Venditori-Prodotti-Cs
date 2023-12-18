using System;
using System.Collections.Generic;

class Prodotto {
    private int codice;
    private double prezzo;

    public Prodotto() {
        this.codice = 0;
        this.prezzo = 0;
    }

    public Prodotto(int codice, double prezzo) {
        this.codice = codice;
        this.prezzo = prezzo;
    }

    public int GetCodice() {
        return this.codice;
    }

    public void SetCodice(int codice) {
        this.codice = codice;
    }

    public double GetPrezzo() {
        return this.prezzo;
    }

    public void SetPrezzo(double prezzo) {
        this.prezzo = prezzo;
    }

    public void Leggi() {
        Console.Write("Inserisci il codice del prodotto: ");
        int codice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Inserisci il prezzo del prodotto: ");
        double prezzo = Convert.ToDouble(Console.ReadLine());
        this.codice = codice;
        this.prezzo = prezzo;
    }

    public override string ToString() {
        return "Codice: " + this.codice + ", Prezzo: " + this.prezzo + " euro";
    }
}

class Venditore {
    private int codice;
    private List<Prodotto> prodotti;

    public Venditore() {
        this.codice = 0;
        this.prodotti = new List<Prodotto>();
    }

    public Venditore(int codice) {
        this.codice = codice;
        this.prodotti = new List<Prodotto>();
    }

    public Venditore(Venditore v) {
        this.codice = v.codice;
        this.prodotti = new List<Prodotto>(v.prodotti);
    }

    public void Leggi() {
        Console.Write("Inserisci il codice del venditore: ");
        int codice = Convert.ToInt32(Console.ReadLine());
        this.codice = codice;
        Console.Write("Inserisci il numero di prodotti venduti: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            Prodotto p = new Prodotto();
            p.Leggi();
            this.prodotti.Add(p);
        }
    }

    public double CalcolaPrezzoTotale() {
        double prezzoTotale = 0;
        foreach (Prodotto p in this.prodotti) {
            prezzoTotale += p.GetPrezzo();
        }
        return prezzoTotale;
    }

    public void AggiungiProdotto() {
        if (this.prodotti.Count < 10) {
            Prodotto p = new Prodotto();
            p.Leggi();
            this.prodotti.Add(p);
        }
        else {
            Console.WriteLine("Impossibile aggiungere un prodotto, l'elenco è pieno.");
        }
    }

    public override string ToString() {
        string str = "Codice venditore: " + this.codice + "\nElenco prodotti venduti:\n";
        foreach (Prodotto p in this.prodotti) {
            str += p.ToString() + "\n";
        }
        return str;
    }
}


class Program {
    static void Main(string[] args) {
        Console.Write("Inserisci il numero di venditori: ");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Venditore> venditori = new List<Venditore>();
        for (int i = 0; i < n; i++) {
            Venditore v = new Venditore();
            v.Leggi();
            venditori.Add(v);
        }
        Console.WriteLine("Elenco venditori:");
        foreach (Venditore v in venditori) {
            Console.WriteLine(v.ToString());
        }
        Console.Write("Inserisci 'crescente' per ordinare per prezzo crescente, 'decrescente' per ordinare per prezzo decrescente: ");
        string ordine = Console.ReadLine();
        if (ordine == "crescente") {
            venditori.Sort((v1, v2) => v1.CalcolaPrezzoTotale().CompareTo(v2.CalcolaPrezzoTotale()));
        }
        else if (ordine == "decrescente") {
            venditori.Sort((v1, v2) => v2.CalcolaPrezzoTotale().CompareTo(v1.CalcolaPrezzoTotale()));
        }
        Console.WriteLine("Elenco venditori ordinato per prezzo totale:");
        foreach (Venditore v in venditori) {
            Console.WriteLine("Prezzo totale: " + v.CalcolaPrezzoTotale() + " euro\n" + v.ToString());
        }
    }
}