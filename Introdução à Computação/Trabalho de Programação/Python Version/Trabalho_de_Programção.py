
quant_produtos = int(input("Seja bem-vindo vendedor, iremos cadastrar seus produtos. Digite quantos quer registrar: "))


nomes_produtos = []
precos_produto = []
id_produtos = []


# Registrando os produtos
for i in range(quant_produtos):
    print("---------------------------------------------------------")
    nome_produto = input("Nome do produto nº {}: ".format(i))
    nomes_produtos.append(nome_produto)
    preco_produto = float(input("Preço do produto nº {}: ".format(i)))
    precos_produto.append(preco_produto)
    id_produtos.append(i)


print("---------------------------------------------------------")
print("Seja bem-vindo cliente. O que deseja fazer? ")
print("\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra")


opcao_cliente = int(input("Opção: "))


valor_compra = 0


while opcao_cliente != 2:
    print("---------------------------------------------------------")
    if opcao_cliente == 1:
        for i in range(quant_produtos):
            print("{}\t|R$ {:.2f}\t| {}".format(id_produtos[i], precos_produto[i], nomes_produtos[i]))


        print("---------------------------------------------------------")
        item_escolhido = int(input("Digite o numero do item que deseja adicionar na sua sacola, e digite {} caso não queira comprar mais: ".format(quant_produtos)))


        while item_escolhido != quant_produtos:
            if item_escolhido < 0 or item_escolhido >= quant_produtos:
                print("Item inválido, não está cadastrado. Digite um novo item")
            else:
                valor_compra += precos_produto[item_escolhido]


            print("\nPróximo produto: ")
            item_escolhido = int(input())


    else:
        opcao_cliente = int(input("Digite uma opção válida: "))


    opcao_cliente = int(input("\n1 - Listar itens do mercado \n2 - Sair ou finalizar compra: "))


print("O valor da compra é: {:.2f}. Obrigada, volte sempre!".format(valor_compra))
