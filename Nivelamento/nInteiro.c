#include <stdio.h>
#include <stdlib.h>

int main(){

    int n, in=0, out=0;

    //Solicita o numero de valores
    printf("Nro Inteiro positivo: ");
    scanf("%i", &n);

    //Valida se 'n' e positivo
    if(n<=0){
        printf("Erro: O numero deve ser positivo.\n");
        return 1; //Encerra o programa com código de erro
    }

    int vet[n]; //Declara o tamanho do vetor 'n'
    //Preenche o vetor e conta os valores 'in' e 'out'
    for(int i = 0; i < n; i++){

        printf("Digite o %iº valor: ",i+1);

        scanf("%i",&vet[i]);

        if (vet[i]>=10 && vet[i]<=20){

            in = in + 1;

        }

        else{

            out = out + 1;
        }

    }

    //Exibe os resultados
    printf("in %i\n", in);
    printf("out %i", out);

    return 0; //Encerra o programa com sucesso
}