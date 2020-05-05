//FASE 1:

    console.log("FASE 1:");

    var caracteresNombre = [ 'G', 'E', 'R', 'A', 'R', 'D' ];
    
    for (let i = 0; i < caracteresNombre.length; i++)
    {
        console.log(caracteresNombre[i]);
    }
    
//FASE 2:            

    console.log("");
    console.log("FASE 2:");
                        
    var nameList = new Array();
                
    nameList[0] = 'G';
    nameList[1] = 'e';
    nameList[2] = 'r';
    nameList[3] = 'a';
    nameList[4] = 'r';
    nameList[5] = 'd';

    for (let index = 0; index < nameList.length; index++)
    {
        const letra = nameList[index];
        
            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U'
                || letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                console.log(nameList[index] + ": Vocal");
            }
            else
            {
                console.log(nameList[index] + ": Consonante");
            }        
    }

//FASE 3:            

    console.log("");
    console.log("FASE 3:");

    var midiccionario = new Map();

    for (let index = 0; index < nameList.length; index++)
    {
        const letra = nameList[index].toUpperCase();
                
        if (!midiccionario.has(letra))
        {
            midiccionario.set(letra, 1);           
        }
        else
        {
            midiccionario.set(letra, midiccionario.get(letra) + 1);           
        }
        
    }      

    console.log("Veces que se repiten las letras de tu nombre:");
    
    midiccionario.forEach((value, key, map) => 
    {
      console.log(key + ' = ' + value);
    })  
    
//FASE 4:

    console.log("");
    console.log("FASE 4:");

    var surnameList = new Array();
                
    surnameList[0] = 'F';
    surnameList[1] = 'e';
    surnameList[2] = 'r';
    surnameList[3] = 'r';
    surnameList[4] = 'e';
    surnameList[5] = 'r';

    var fullnameList = new Array();
    fullnameList.push.apply(fullnameList, nameList);
    fullnameList.push(' ');
    fullnameList.push.apply(fullnameList, surnameList);
    
    for (let i = 0; i < fullnameList.length; i++)
    {
        console.log(fullnameList[i]);
    }
