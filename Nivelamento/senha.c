#include <stdio.h>
#include <stdlib.h>

int main() {
    int senha;

    printf("Digite a senha de 4 digitos: ");
    scanf("%i", &senha);

    // Valida se a senha tem exatamente 4 dígitos
    if (senha < 1000 || senha > 9999) {
        printf("Erro: A senha deve ter exatamente 4 digitos.\n");
        return 1; // Encerra o programa com código de erro
    }

    // Loop enquanto a senha estiver incorreta
    while (senha != 2002) {
        printf("Senha Invalida: Acesso negado!\n");
        printf("Digite a senha novamente: ");
        scanf("%i", &senha);

        // Valida novamente se a nova senha tem 4 dígitos
        if (senha < 1000 || senha > 9999) {
            printf("Erro: A senha deve ter exatamente 4 digitos.\n");
            return 1; // Encerra o programa com código de erro
        }
    }

    // Senha correta
    printf("Senha correta, Acesso permitido!\n");

    return 0; // Indica que o programa terminou com sucesso
}