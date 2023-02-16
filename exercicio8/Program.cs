Console.WriteLine("Sequência de Fibonacci, pressione enter para continuar");
Console.ReadLine(); 

int aux1 = 0;
int aux2 =1; 
int fibonaci;

for(int i=0;i<20;i++){
    fibonaci = aux1 + aux2;
    Console.WriteLine(fibonaci);
    aux1 = aux2;
    aux2 = fibonaci;
}
