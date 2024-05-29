#include <iostream>
#include <string>
#include <vector>

int main() {
    int opcaoCliente = 0, quantProdutos, itemEscolhido = 0;
    float valorCompra = 0;

    std::cout << "Seja bem vindo vendedor, iremos cadastrar seus produtos, digite quantos quer registrar: ";
    std::cin >> quantProdutos;
    std::cin.ignore(); // Ignorar o enter após o número

    std::vector<std::string> nomesProdutos(quantProdutos);
    std::vector<float> precoProduto(quantProdutos);
    std::vector<int> idProduto(quantProdutos);

    for (int i = 0; i < quantProdutos; ++i) {
        std::cout << "---------------------------------------------------------\n";
        std::cout << "\nNome do produto nº " << i + 1 << ": ";
        std::getline(std::cin, nomesProdutos[i]);

        std::cout << "\nPreço do produto nº" << i + 1 << ": ";
        std::cin >> precoProduto[i];
        std::cin.ignore(); // Ignorar o enter após o número

        idProduto[i] = i;
    }

    std::cout << "---------------------------------------------------------\n";
    std::cout << "Seja bem vindo cliente o que deseja fazer? ";
    std::cout << "\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra \nOpção: ";
    std::cin >> opcaoCliente;

    do {
        std::cout << "---------------------------------------------------------\n";
        if (opcaoCliente == 1) {
            for (int i = 0; i < quantProdutos; ++i) {
                std::cout << idProduto[i] << "\t|R$ " << precoProduto[i] << "\t | " << nomesProdutos[i] << "\n";
            }

            std::cout << "---------------------------------------------------------\n";
            std::cout << "Digite o numero do item que deseja adicionar na sua sacola, e digite " << quantProdutos << " caso não queira comprar mais: ";
            std::cin >> itemEscolhido;

            do {
                if ((itemEscolhido < 0) || (itemEscolhido >= quantProdutos)) {
                    std::cout << "Item invalido, não está cadastrado. Digite um novo item: ";
                } else {
                    valorCompra += precoProduto[itemEscolhido];
                }

                std::cout << "\nPróximo produto: ";
                std::cin >> itemEscolhido;

            } while (itemEscolhido != quantProdutos);
        } else if (opcaoCliente != 2) {
            std::cout << "Digite uma opção válida! ";
            std::cin >> opcaoCliente;
        }

        std::cout << "\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra: ";
        std::cin >> opcaoCliente;

    } while (opcaoCliente != 2);

    std::cout << "O valor da compra é: " << valorCompra << ", obrigada e volte sempre! \n";

    return 0;
}
