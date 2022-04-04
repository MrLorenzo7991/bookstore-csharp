//dichiarazione variabili
string titolo = "Clean Code: A Handbook of Agile Software Craftsmanship";
string autore = "Robert C. Martin";
string isbn = "978-0132350884";
int numeroPagine = 431;
double pesoLibro = 0.66;
double[] dimensioni = {17.91, 23.5, 2.54};  //larghezza, lunghezza, profondità
double valutazioneMedia = 4.7;
int numeroRecensioni = 3308;
bool disponibilitaKindle = true;
bool disponibilitaCopertinaFlessibile = true;

//Stampa informazioni
//informazioni generiche
Console.WriteLine("--- IL LIBRO DI OGGI: " + titolo + " di " + autore + " ---");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " kg");
Console.WriteLine("Dimensioni del libro: " + dimensioni[0] + " cm x " + dimensioni[1] + " cm x " + dimensioni[2] + " cm");

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