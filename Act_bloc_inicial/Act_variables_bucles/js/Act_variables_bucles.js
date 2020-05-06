//Fase 1:            
var nombre = "Gerard";
var apellido1 = "Ferrer";
var apellido2 = "Birbe";

console.log("FASE 1:");
console.log("Mi nombre es " + nombre + " " + apellido1 + " " + apellido2);

var dia = 23;
var mes = 11;
var ano = 1982;

console.log("Nací el " + dia + "/" + mes + "/" + ano);

//Fase 2:            
var anoBisiesto = 1948;

var tiempoEntreBisiestos = 4;

var numAnosBisiestos = Math.floor((ano - anoBisiesto) / tiempoEntreBisiestos) + 1;

console.log("FASE 2:");
console.log("Entre el año " + anoBisiesto + " y mi año de nacimiento (el " + ano +
    ") ha habido " + numAnosBisiestos + " años bisiestos");

//Fase 3:            
console.log("FASE 3:");
console.log("Listado de años bisiestos:");

for (let i = anoBisiesto; i <= ano; i+=tiempoEntreBisiestos)
{
    console.log(i);
}

var controlBisiesto = false;
var fraseCierto = "El año de mi nacimiento es bisiesto";
var fraseFalso = "El año de mi nacimiento no es bisiesto";

for (let i = anoBisiesto; i <= ano; i+=tiempoEntreBisiestos)
{
    if(i==ano)
    {
        controlBisiesto = true;
    }
}

if (controlBisiesto)
{
    console.log(fraseCierto);
}
else
{
    console.log(fraseFalso);
}

//Fase 4:
var nombreCompleto = nombre + " " + apellido1 + " " + apellido2;
var fechaCompleta = dia + "/" + mes + "/" + ano;

console.log("FASE 4:");
console.log("Mi nombre es " + nombreCompleto);
console.log("Nací el " + fechaCompleta);

if (controlBisiesto)
{
    console.log(fraseCierto);
}
else
{
    console.log(fraseFalso);

}

