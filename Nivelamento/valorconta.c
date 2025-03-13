#include <stdio.h>
#include <stdlib.h>

int main(){
    
    int cod, q;
    float v;

    printf(" 1- Cachorro quente R$ 4.00\n 2- X-Salada R$ 4.50\n 3- X-Bacon R$ 5.00\n 4- Torrada simples R$ 2.00\n 5- Refrigerante R$ 1.50\n\n");

    printf("Digite codigo e a quantidade: ");
    scanf("%i %i", &cod, &q);

    if(cod == 1){
        v = 4.00;
    }
    if(cod == 2){
        v = 4.50;
    }
    if(cod == 3){
        v = 5.00;
    }
    if(cod == 4){
        v = 2.00;
    }
    if(cod == 5){
        v = 1.50;
    }
    
    float vt = v * q;

    printf("Valor a pagar: %.2f R$\n",vt);
}
