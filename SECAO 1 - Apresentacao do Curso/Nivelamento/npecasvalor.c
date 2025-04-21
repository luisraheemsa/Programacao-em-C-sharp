#include <stdio.h>
#include <stdlib.h>

int main(){

    printf("Numero da peça, qnt, valor: ");
    
    int n, q;
    float v;
    scanf("%i %i %f", &n, &q, &v);

    float vt = q * v;

    printf("Valor a pagar: %.2f R$",vt);
}