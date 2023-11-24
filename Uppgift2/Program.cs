Console.WriteLine("N ?");

int N= int.Parse(Console.ReadLine()); //N<=25

int tal1=1;

int tal2=2;

int tal3=3;

int svar=0; 

while(true){


   //+ 1 hela tiden tills den går över N 
   if((tal1*tal2*tal3)<N){


    tal1 +=1;

    tal2 +=1;

    tal3 +=1;

    svar +=1; 
     

   }
   else

   break;

   Console.WriteLine($"Svar: {svar}");
}