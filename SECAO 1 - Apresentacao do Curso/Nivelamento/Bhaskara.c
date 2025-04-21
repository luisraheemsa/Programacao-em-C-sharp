#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

float a, b, c, delta;

printf("digite os valores de a, b e c: ");
scanf("%f %f %f",&a, &b, &c);

// Verifica se 'a' é zero
if(a==0){

    printf("a: %f\n", a);
    printf("Impossivel Calcular: Valor de a igual a zero! A equacao eh linear\n");
    return 1; // Encerra o programa com codigo de erro
}

delta = b*b - 4*a*c;

// Verifica se o delta é negativo
if(delta<0){

    printf("Delta: %f\n",delta);
    printf("Impossivel Calcular: Delta menor que zero!\n");
    return 1; //encerra o programa com codigo de erro
}
// Se 'a' não é zero e delta é maior ou igual a zero, calcula as raízes
if(a!=0 && delta>=0){


    float x1 = (-b + sqrt(delta))/(2*a);
    float x2 = (-b - sqrt(delta))/(2*a);

    printf("X1 = %f\n",x1);
    printf("X2 = %f\n",x2);
}
return 0; // encerra o programa com sucesso

}