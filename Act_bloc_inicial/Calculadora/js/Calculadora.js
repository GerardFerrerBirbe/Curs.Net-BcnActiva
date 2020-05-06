class App
{
   constructor()
   {

   } 
   BtClick_Press(num)
   {
       TbResult.value += num;
   }
   BtClick_Suma()
   {
       let conversionResult = this.TryReadAndConvert();
       if(conversionResult.IsSuccess)
       {
           this.FirstNumber = conversionResult.Value;
           this.CurrentOperation = Operations.Suma;
       }
   }
   BtClick_Resta()
   {
       let conversionResult = this.TryReadAndConvert();
       if(conversionResult.IsSuccess)
       {
           this.FirstNumber = conversionResult.Value;
           this.CurrentOperation = Operations.Resta;
       }
   }
   BtClick_Mult()
   {
       let conversionResult = this.TryReadAndConvert();
       if(conversionResult.IsSuccess)
       {
           this.FirstNumber = conversionResult.Value;
           this.CurrentOperation = Operations.Mult;
       }
   }
   BtClick_Div()
   {
       let conversionResult = this.TryReadAndConvert();
       if(conversionResult.IsSuccess)
       {
           this.FirstNumber = conversionResult.Value;
           this.CurrentOperation = Operations.Div;
       }
   }

   BtClick_Igual()
   {
       let conversionResult = this.TryReadAndConvert();
       if(conversionResult.IsSuccess)
       {
           let secondNumber = conversionResult.Value

           switch (this.CurrentOperation)
           {
                case Operations.Suma:
                   TbResult.value = this.FirstNumber + secondNumber;
                   break;
                case Operations.Resta:
                    TbResult.value = this.FirstNumber - secondNumber;
                    break;
                case Operations.Mult:
                   TbResult.value = this.FirstNumber * secondNumber;
                   break;
                case Operations.Div:
                   TbResult.value = this.FirstNumber / secondNumber;
                   break;
           }
       }
    }

    BtClick_Borrar(emptyvalue)
    {
        TbResult.value = emptyvalue;
    }
   
   TryReadAndConvert()
   {
       let output = {IsSuccess: false, Value: null};
       output.Value = Number(TbResult.value);
       output.IsSuccess = output.Value !== NaN;

       if(output.IsSuccess)
        {
            TbResult.value = "";
        }
        else
        {
            TbResult.value = "0";
        }
        /* A continuació s'escriu el mateix que el if anterior, d'una forma més simplificada:
        TbResult.Value = output.IsSuccess ? "" : 0;
        */
       return output;
   }
}

Operations = 
{
    Suma: 1,
    Resta: 2,
    Mult: 3,
    Div: 4
}

var app = new App();