//FASE 1:         
            
var unEuro = 0;
var dosEuros = 0;
var cincoEuros = 0;
var diezEuros = 0;
var veinteEuros = 0;
var cincuentaEuros = 0;
var cienEuros = 0;
var doscientosEuros = 0;
var quinientosEuros = 0;

var precioTotal = 0;

//FASE 2 i 3:

console.log("Nombre y precio de cada plato del menú:");

var menu = new Array("Macarrones", "Sopa", "Entrecot", "Sushi", "Coulant");
var precioMenu = new Array(14, 9, 18, 26, 12);

for (let i = 0; i < menu.length; i++)
{
   console.log(menu[i] + " : " + precioMenu[i] + " euros")
}

console.log("Platos escogidos:");

var menuSelecc = new Array("Entrecot", "Pollo", "Sushi", "Coulant");


menuSelecc.forEach(element => 
{
    if (menu.includes(element))
    {
        console.log(element);

        for (let i = 0; i < menu.length; i++)
        {
            if (element==menu[i])
            {
                precioTotal += precioMenu[i]
            }                 
        }
    }
    else
    {
        console.log(element + " : Este plato no está en el menú");
    }    
});
    
console.log("Precio total de los platos escogidos: " + precioTotal);


//FASE 4:

var precioAcum = 0;

while (precioAcum != precioTotal)
{
    if (precioAcum <= precioTotal - 500 )
    {
        precioAcum += 500;
        quinientosEuros++;
    }                
    else
    {
        if (precioAcum <= precioTotal - 200)
        {
            precioAcum += 200;
            doscientosEuros++;
        }
        else
        {
            if (precioAcum <= precioTotal - 100)
            {
                precioAcum += 100;
                cienEuros++;
            }
            else
            {
                if (precioAcum <= precioTotal - 50)
                {
                    precioAcum += 50;
                    cincuentaEuros++;
                }
                else
                {
                    if (precioAcum <= precioTotal - 20)
                    {
                        precioAcum += 20;
                        veinteEuros++;
                    }
                    else
                    {
                        if (precioAcum <= precioTotal - 10)
                        {
                            precioAcum += 10;
                            diezEuros++;
                        }
                        else
                        {
                            if (precioAcum <= precioTotal - 5)
                            {
                                precioAcum += 5;
                                cincoEuros++;
                            }
                            else
                            {
                                if (precioAcum <= precioTotal - 2)
                                {
                                    precioAcum += 2;
                                    dosEuros++;
                                }
                                else
                                {
                                    precioAcum += 1;
                                    unEuro++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}

console.log("Número de billetes y monedas que necesitas para pagar la comida:");

if(quinientosEuros > 0)
{
    console.log("500 euros: " + quinientosEuros);
}
if (doscientosEuros > 0)
{
    console.log("200 euros: " + doscientosEuros);
}
if (cienEuros > 0)
{
    console.log("100 euros: " + cienEuros);
}
if (cincuentaEuros > 0)
{
    console.log("50 euros: " + cincuentaEuros);
}
if (veinteEuros > 0)
{
    console.log("20 euros: " + veinteEuros);
}
if (diezEuros > 0)
{
    console.log("10 euros: " + diezEuros);
}
if (cincoEuros > 0)
{
    console.log("5 euros: " + cincoEuros);
}
if (dosEuros > 0)
{
    console.log("2 euros: " + dosEuros);
}
if (unEuro > 0)
{
    console.log("1 euro: " + unEuro);
}
