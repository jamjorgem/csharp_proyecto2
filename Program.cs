Console.WriteLine("Escribe tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe tu apellido:");
string apellido = Console.ReadLine();
Console.WriteLine("Escribe tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabes Programar en:");
string lenguage = Console.ReadLine();

string mensaje = nombre +" "+ apellido + " Tiene:" + edad + " años y sabe programar en " + lenguage;

Console.WriteLine(mensaje);

//COCHE
int puertas = 4;
int ruedas = 4;
string marca = "mazda";
bool itv_vigente = true;
string itv = "";
if (itv_vigente == true) {
    itv = "vigente";
} 
else {
    itv = "No Vigente";
}
Console.WriteLine("Coche tiene; puertas:"+puertas+" ruedas:"+ruedas+" es de "+marca +" y tiene el ITV " + itv);

//MESA
float peso = 3.345F;
float largo = 45.3F;
string material = "madera";
string color = "negro";

Console.WriteLine("Mesa: peso:" + peso + " Largo:" + largo + " es de " + material + " y color " + color);

int num = 20;
char var = 'a';

Console.WriteLine("Un número es mayor o igual a 18: " + (num>= 18)); //true
Console.WriteLine("Un char es ‘a’ : " + (var == 'a')); //TRUE

Console.WriteLine("Se cumplen dos condiciones a la vez (ambas verdaderas) :" + (num >= 18 && (var == 'a'))); //true

Console.WriteLine("Se cumple una de dos condiciones a la vez (una true y otra false) :" + (num >= 18 && (var == 'h'))); //false

