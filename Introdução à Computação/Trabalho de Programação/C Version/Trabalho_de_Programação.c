#define SUCESSO 0
#define TAM_MAX_NOME_PRODUTOS 30

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char** argv)
{
    int opcaoCliente = 0, quantProdutos, itemEscolhido = 0;
    float valorCompra = 0;
    
    printf("Seja bem vindo vendedor, iremos cadastrar seus produtos, digite quantos quer registrar: ");
    scanf("%d", &quantProdutos);

    char nomesProdutos[quantProdutos][TAM_MAX_NOME_PRODUTOS];
    float precoProduto[quantProdutos];
    int idProduto[quantProdutos];
    
    for (int i = 0; i < quantProdutos; i++){
        printf("---------------------------------------------------------");
        printf("\nNome do produto %d: ", i+1);
        scanf("%s", nomesProdutos[i]);
        printf("Preço do produto %d: ", i+1);
        scanf("%f", &precoProduto[i]);
        
        idProduto[i] = i;
    }
    
    printf("\n---------------------------------------------------------");
    printf("\nSeja bem vindo cliente, o que deseja fazer? ");
    printf("\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra \nOpção: ");
    
    scanf("%d", &opcaoCliente);
    
    do{
        printf("---------------------------------------------------------");
            if (opcaoCliente == 1)
            {
                for (int i = 0; i < quantProdutos; i++)
                {
                    printf("\n%d\t|R$ %f\t | %s", idProduto[i], precoProduto[i], nomesProdutos[i]);
                }

                printf("\n---------------------------------------------------------");
                printf("\nDigite o numero do item que deseja adicionar na sua sacola, e digite %d caso não queira comprar mais: ", quantProdutos);
    
                scanf("%d", &itemEscolhido);
                
                do
                {
                    if((itemEscolhido < 0) && (itemEscolhido > quantProdutos))
                    {
                        printf("Item invalido, não está cadastrado. Digite um novo item");
                    }
                    else
                    {
                        for (int i = 0; i < quantProdutos; i++)
                        {
                            if (itemEscolhido == idProduto[i])
                            {
                                valorCompra += precoProduto[i];
                            }
                        }
                        
                    }

                    printf("\nPróximo produto: ");
                    scanf("%d", &itemEscolhido);

                } while (itemEscolhido != quantProdutos);
            }
            else if(opcaoCliente != 0)
            {
                printf("Digite uma opção válida! ");
                scanf("%d", &opcaoCliente);
            }

        printf("\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra: ");
        scanf("%d", &opcaoCliente);

    } while (opcaoCliente != 2);

    printf("O valor da compra é: %.2f , obrigada e volte sempre! ", valorCompra);
    
    return SUCESSO;
}
