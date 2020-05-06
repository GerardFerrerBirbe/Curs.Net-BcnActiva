//FASE 1:
console.log("FASE 1:");

var ciudad1 = "Barcelona";
var ciudad2 = "Madrid";
var ciudad3 = "Valencia";
var ciudad4 = "Málaga";
var ciudad5 = "Cádiz";
var ciudad6 = "Santander";        

console.log("Listado de las ciudades:");
console.log(ciudad1);
console.log(ciudad2);
console.log(ciudad3);
console.log(ciudad4);
console.log(ciudad5);
console.log(ciudad6);

//FASE 2:
console.log("FASE 2:");
console.log("Listado de las ciudades ordenadas alfabéticamente:");

var arrayCiudades = [ ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 ];

arrayCiudades.sort();

for (let i = 0; i < arrayCiudades.length; i++)
{
    console.log(arrayCiudades[i]);
}

//FASE 3:
console.log("FASE 3:");
console.log("Listado de las ciudades con el nombre modificado:");

var n = 6;
var arrayCiudadesModificadas = new Array();

for (let i = 0; i < n; i++)
{
    arrayCiudadesModificadas[i] = arrayCiudades[i].replace(/a/g, "4"); //Les barres amb la g, permeten substituir totes les 'a'. Si no, només es substitueix la primera. Si poses gi, substitueix tant minúscules com majúscules.
    console.log(arrayCiudadesModificadas[i]);
}

//FASE 4:
console.log("FASE 4:");
console.log("Listado de las ciudades con las letras invertidas:");

var arrayCiudad1 = new Array;
var arrayCiudad2 = new Array;
var arrayCiudad3 = new Array;
var arrayCiudad4 = new Array;
var arrayCiudad5 = new Array;
var arrayCiudad6 = new Array;

for (let i = 0; i < ciudad1.length; i++)
{
    var letra = ciudad1.substr(i, 1);
    arrayCiudad1[i] = letra;
}

arrayCiudad1.reverse();

for (let i = 0; i < ciudad1.length; i++)
{
    console.log(arrayCiudad1[i]);
}

console.log("");

for (let i = 0; i < ciudad2.length; i++)
{
    var letra = ciudad2.substr(i, 1);
    arrayCiudad2[i] = letra;
}

arrayCiudad2.reverse();

for (let i = 0; i < ciudad2.length; i++)
{
    console.log(arrayCiudad2[i]);
}

console.log("");

for (let i = 0; i < ciudad3.length; i++)
{
    var letra = ciudad3.substr(i, 1);
    arrayCiudad3[i] = letra;
}

arrayCiudad3.reverse();

for (let i = 0; i < ciudad3.length; i++)
{
    console.log(arrayCiudad3[i]);
}

console.log("");

for (let i = 0; i < ciudad4.length; i++)
{
    var letra = ciudad4.substr(i, 1);
    arrayCiudad4[i] = letra;
}

arrayCiudad4.reverse();

for (let i = 0; i < ciudad4.length; i++)
{
    console.log(arrayCiudad4[i]);
}

console.log("");

for (let i = 0; i < ciudad5.length; i++)
{
    var letra = ciudad5.substr(i, 1);
    arrayCiudad5[i] = letra;
}

arrayCiudad5.reverse();

for (let i = 0; i < ciudad5.length; i++)
{
    console.log(arrayCiudad5[i]);
}

console.log("");

for (let i = 0; i < ciudad6.length; i++)
{
    var letra = ciudad6.substr(i, 1);
    arrayCiudad6[i] = letra;
}

arrayCiudad6.reverse();

for (let i = 0; i < ciudad6.length; i++)
{
    console.log(arrayCiudad6[i]);
}
