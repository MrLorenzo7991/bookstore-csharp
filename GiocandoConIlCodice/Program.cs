Console.WriteLine("Inserisci titolo: ");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci autore: ");
string autore = Console.ReadLine();

Console.WriteLine("Inserisci ISBN: ");
string isbn = Console.ReadLine();

int numeroPagine = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci il numero di pagine");
        if (int.TryParse(Console.ReadLine(), out int outputParsato))
        {
            numeroPagine = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci il numero di pagine nel formato corretto perfavore");
        }

    } while (numeroPagine != null && !flag);
}

double pesoLibro = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci il peso del libro");
        if (double.TryParse(Console.ReadLine(), out double outputParsato))
        {
            pesoLibro = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci il peso corretto perfavore");
        }

    } while (numeroPagine != null && !flag);
}

double larghezza = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci la larghezza del libro");
        if (double.TryParse(Console.ReadLine(), out double outputParsato))
        {
            larghezza = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci la larghezza corretta perfavore");
        }

    } while (numeroPagine != null && !flag);
}

double lunghezza = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci la lunghezza del libro");
        if (double.TryParse(Console.ReadLine(), out double outputParsato))
        {
            lunghezza = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci la lunghezza corretta perfavore");
        }

    } while (numeroPagine != null && !flag);
}

double profondita = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci la profondità del libro");
        if (double.TryParse(Console.ReadLine(), out double outputParsato))
        {
            profondita = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci la profondità corretta perfavore");
        }

    } while (numeroPagine != null && !flag);
}

double valutazioneMedia = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci la valutazione media");
        if (double.TryParse(Console.ReadLine(), out double outputParsato))
        {
            valutazioneMedia = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci la valutazione media corretta perfavore");
        }

    } while (numeroPagine != null && !flag);
}

int numeroRecensioni = 0;
{
    bool flag = false;
    do
    {
        Console.WriteLine("Inserisci il numero di recensioni");
        if (int.TryParse(Console.ReadLine(), out int outputParsato))
        {
            numeroRecensioni = outputParsato;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci il numero di recensioni corretto perfavore");
        }

    } while (numeroPagine != null && !flag);
}

Console.WriteLine("Il libro è disponibile in formato Kindle? (inserisci si o no)");
string rispostaKindle = Console.ReadLine();
bool disponibilitaKindle = false;
if (rispostaKindle == "si")
{
    disponibilitaKindle = true;
}

Console.WriteLine("Il libro è disponibile in con la coperitna flessibile? (inserisci si o no)");
string rispostaCopertina = Console.ReadLine();
bool disponibilitaCopertinaFlessibile = false;
if (rispostaCopertina == "si")
{
    disponibilitaCopertinaFlessibile = true;
}




//Stampa informazioni
//informazioni generiche
Console.WriteLine("--- IL LIBRO DI OGGI: " + titolo + " di " + autore + " ---");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " kg");
Console.WriteLine("Dimensioni del libro: " + larghezza + " cm x " + lunghezza + " cm x " + profondita + " cm");

Console.WriteLine();

//informazioni Amazon
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni);
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelline");
if (disponibilitaKindle)
{
    Console.WriteLine("Kindle disponibile: si");
}
else
{
    Console.WriteLine("Kindle disponibile: no");
}
if (disponibilitaCopertinaFlessibile)
{
    Console.WriteLine("Copertina flessibile disponibile: si");
}
else
{
    Console.WriteLine("Copertina flessibile disponibile: no");
}