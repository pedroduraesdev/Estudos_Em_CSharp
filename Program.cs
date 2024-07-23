// Screen Sound

string mensagem = "Boas Vindas ao Screen Sound";

void MensagemDeBoasVindas(){
    Console.WriteLine("**********************");
    Console.WriteLine(mensagem);
    Console.WriteLine("**********************");
}

void ExibirOpcoesDeMenu (){
    Console.WriteLine ("Digite 1 para registrar uma banda:");
    Console.WriteLine ("Digite 2 para mostrar todas as bandas:");
    Console.WriteLine ("Digite 3 para avaliar uma banda:");
    Console.WriteLine ("Digite 4 para exibir a média de uma banda:");
    Console.WriteLine ( "Digite -1 para Sair: ");

    Console.Write ("\nDigite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica){
        case 1: Console.WriteLine("Você escolher a opção: " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção:" + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção:" + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção:" + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Você escolheu a opção:" + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Essa é uma opção incorreta.");
            break;
    }
    
}

MensagemDeBoasVindas();
ExibirOpcoesDeMenu();