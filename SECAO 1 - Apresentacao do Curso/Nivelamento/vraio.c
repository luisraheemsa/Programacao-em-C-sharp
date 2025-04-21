#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#define PI 3.1415

int main(){

    printf("Valor do Raio: ");
    
    float r;
    scanf("%f", &r);

    float a = PI * pow(r,2);

    printf("A =  %.4f\n",a);
}