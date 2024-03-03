using System;

using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();//criando uma istancia/deixando na mémoria do computador

             /*func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M;
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("===============");
            Console.WriteLine(mensagem);
            Console.WriteLine("==============="); */

             /*ReajustarSalario();
             ExibirPeriodoExperiencia();
             CalcularDescontoVT(decimal percentual);
             ContarCaracteres(string dado);
             ValidarCpf(); */
           
             Console.WriteLine(" 1 - Digite o Id do funcionário:");
             func.Id = int.Parse(Console.ReadLine());

             Console.WriteLine(" Digite o nome do funcionário:");
             func.Nome = Console.ReadLine();

             Console.WriteLine(" Digite o Cpf:");
             func.Cpf = Console.ReadLine();

             Console.WriteLine(" Digite a data de admissão:");
             func.DataAdmissao = DateTime.Parse(Console.ReadLine());

             Console.WriteLine(" Digite o Salário:");
             func.Salario = decimal.Parse(Console.ReadLine());

             Console.WriteLine(" Escolha o tipo de Funcionário (1 - CLT / 2 - Aprendiz):");
             int opcao = int.Parse(Console.ReadLine());

             /*Console.WriteLine(" Observe o menu abaixo e digite o número referente a opção desejada: ");
                        Console.WriteLine("1- Reajustar Salario");
                        Console.WriteLine("2-  ExibirPeriodo Experiencia");
                        Console.WriteLine("3- Calcular Desconto VT");
                        Console.WriteLine("4- ContarCaracteres");
                         Console.WriteLine("5- Validar Cpf");

                        int opcaoEscolhida = int.Parse(Console.ReadLine());
                            switch (opcaoEscolhida)
                            {
                              case 1:
                                ReajustarSalario();
                                break;
                              case 2:
                                 ExibirPeriodoExperiencia();
                                break;
                              case 3:
                                CalcularDescontoVT();
                                break;    
                              case 4:
                                ContarCaracteres();
                                break;
                              case 5:
                                Validar Cpf();
                                break;
                              default:
                              Console.WriteLine("Opção inválida!!!");     
                            } */
                            
                 
                  

             /*Console.WriteLine("Esperiencia: ");
             func.periodoExperiencia = Console.ReadLine(); */

             /*Operação Ternário - Interpretação: Se a condição do parenteses for verdadeira,
             escolha o que está depois da "?", Caso contrário, escolha o que está depois dos ":" */

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;
            
             func.ReajustarSalario();
             decimal valorDescontoVT = func.CalcularDescontoVT(6);

             //fun.ExibirPeriodoExperiencia();

             /*func.ExibirPeriodoExperiencia();
             string periodoExperiencia=
             string.Format("Periodo de experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
             return periodoExperiencia;

             func.ContarCaracteres();
               return dado.Length;

             func. ValidarCpf();
              if(ContarCaracteres(Cpf) == 11)
                return true;
            else
               return false; */  

             
             
             Console.WriteLine("=====================");
             Console.WriteLine($"O salário reajustado do é {func.Salario}. \n");
             Console.WriteLine($"O Desconto do VT é {valorDescontoVT}. \n");
             Console.WriteLine("===================== ");
             Console.WriteLine($"O nome do funcionário é: {func.Nome}. \n");
             Console.WriteLine("===================== ");
             Console.WriteLine($"O id do funcionário é:{func.Id}. \n");
             Console.WriteLine("===================== ");
             Console.WriteLine($"O Cpf do funcionário é:{func.Cpf}. \n");
             Console.WriteLine("===================== ");
             Console.WriteLine($"A data de admissão do funcionário é:{func.DataAdmissao}. \n");
             Console.WriteLine("===================== ");
           

           
      
             //Console.WriteLine($"O periodo de experiência é: {func.periodoExperiencia}. \n");
             /*Console.WriteLine("=====================");
             Console.WriteLine($"O número de caracteres é: {func.ContarCaracteres}");
             Console.WriteLine($"Validação do Cpf:{func.ValidarCpf}.\n");*/

             // Console.WriteLine($" Periodo de experiência: {0} até {1} ");

            // ReajustarSalario();
            // CalcularDescontoVT();
            // ExibirPeriodoExperiencia();
             //ContarCaracteres(); 

           

            
        }   

    }
}

