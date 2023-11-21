/*Realização de um programa para simalar um estacionamento de carros no qual poderá ocorrer a entrada,
retirada, e listagem de veículos. Programa desenvolvido durante o treinamento da DIO.
*/

using System.Collections;

decimal preco = 0, valorhora =0, opcao =0, horas = 0;
bool continuar = true;
List<string> veiculos = new List<string>();
string auxiliar = "", removido=" ";

//-------------------------------------------------FUNÇÕES AUXILIARES
void limpatela(){

    Console.WriteLine("Pressione uma tecla para continuar...");
    auxiliar=Console.ReadLine();
    Console.Clear();

}

void linha(){

    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
}


//-------------------------------------------------CABEÇALHOS

 void cabecalho0(){

    linha();
    Console.WriteLine("                                          ESTACIONAMENTO MÃO NA RODA");
    linha();

 }
  void cabecalho1(){

    linha();
    Console.WriteLine("                                          CADASTRAR VEÍCULO");
    linha();

 }
 void cabecalho2(){

    linha();
    Console.WriteLine("                                          REMOVER VEÍCULO");
    linha();

 }
  void cabecalho3(){

    linha();
    Console.WriteLine("                                          LISTAR VEÍCULO");
    linha();

 }

//-------------------------------------------------OPÇÕES DOS MENUS

void menu1(){

    cabecalho1();
    Console.WriteLine("Digite a placa do veículo para estacionar");
    veiculos.Add(Console.ReadLine());
    limpatela();

}

void menu2(){

    cabecalho2();
    Console.WriteLine("Digite a placa do veículo para retirar");
    removido=(Console.ReadLine());
    veiculos.Remove(removido);
    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado");
    horas = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"O veículo {removido} foi removido e o preço total foi de: R$ {horas * valorhora + preco}");
    limpatela();

}

void menu3(){

    cabecalho3();
    Console.WriteLine("Os veículos estacionados são:");
    foreach (string car in veiculos){

        Console.WriteLine(car);
        
    }
    limpatela();
}

//-------------------------------------------------PROGRAMA PRINCIPAL

cabecalho0();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial para estacionar: ");
preco = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora");
valorhora = Convert.ToDecimal(Console.ReadLine());

limpatela();



while (continuar){
    
    cabecalho0();
    Console.WriteLine($"Digite a sua opção:\n 1 - Cadastrar veículo\n 2 - Remover veículo\n 3 - Listar veículo\n 4 - Encerrar\n");
    opcao = Convert.ToInt32(Console.ReadLine());
    limpatela();

    switch(opcao){   
    
        case 1:
            menu1();
            
            break;
        
        case 2:
            menu2();
            break;

        case 3:
            menu3();
            break;

        case 4:
            Console.WriteLine("Digitou 4");
            continuar = false;
            break;

        default:
            cabecalho0();
            Console.WriteLine("Opção inválida");
            limpatela();
            break;
    
    }
}