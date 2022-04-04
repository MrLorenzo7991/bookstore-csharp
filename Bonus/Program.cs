Console.WriteLine("Inserisci titolo: ");
string titolo = Console.ReadLine();

Console.WriteLine("Inserisci autore: ");
string autore = Console.ReadLine();

Console.WriteLine("Inserisci ISBN: ");
string isbn = Console.ReadLine();

Console.WriteLine("Inserisci numero di pagine: ");
int numeroPagine = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci peso del libro in kg: ");
double pesoLibro = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci larghezza del libro in cm: ");
double larghezza = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci lunghezza del libro in cm: ");
double lunghezza = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci profondità del libro in cm: ");
double profondita = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci valutazione media del libro: ");
double valutazioneMedia = double.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il numero di recensioni del libro");
int numeroRecensioni = int.Parse(Console.ReadLine());

Console.WriteLine("Il libro è disponibile in formato Kindle? (inserisci si o no)");
string rispostaKindle = Console.ReadLine();
bool disponibilitaKindle = false;
if(rispostaKindle == "si")
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





