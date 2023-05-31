
string nomeCompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");
nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Olà, " + nomeCompleto + ", sei que tem " +  idade + " anos, seja bem-vindo ao meu primeiro programa C#");
