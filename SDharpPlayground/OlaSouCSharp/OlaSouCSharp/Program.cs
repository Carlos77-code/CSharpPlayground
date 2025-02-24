using System;

class Program
{
    static void Main(string[] args)
    {
        // Chamando a função CalcularIMC
        CalcularIMC();
    }

    static void CalcularIMC()
    {
        Console.WriteLine("Digite seu nome!");
        string name = Console.ReadLine();

        Console.WriteLine("Digite o sexo (masculino/feminino):");
        string sexo = Console.ReadLine().Trim().ToLower(); // Normaliza a entrada

        Console.WriteLine("Digite sua idade!");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Idade inválida. Por favor, digite um número positivo.");
        }

        Console.WriteLine("Digite seu peso (em kg)!");
        double weight;
        while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        {
            Console.WriteLine("Peso inválido. Por favor, digite um número positivo.");
        }

        Console.WriteLine("Digite sua altura (em metros)!");
        double height;
        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Altura inválida. Por favor, digite um número positivo.");
        }

        // Calculando o IMC
        double imc = weight / (height * height);

        // Exibindo os resultados
        Console.WriteLine("Olá: " + name);
        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

        // Classificando o IMC com base na idade e sexo
        if (age >= 0 && age <= 19)
        {
            Console.WriteLine("Classificação para crianças e adolescentes:");

            if (sexo == "masculino")
            {
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine($"O IMC deste menino é: {imc.ToString("F2")}");
                    InterpretarIMCInfantil(imc, age, sexo);
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine($"O IMC deste adolescente (masculino) é: {imc.ToString("F2")}");
                    InterpretarIMCInfantil(imc, age, sexo);
                }
            }
            else if (sexo == "feminino")
            {
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine($"O IMC desta menina é: {imc.ToString("F2")}");
                    InterpretarIMCInfantil(imc, age, sexo);
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine($"O IMC desta adolescente (feminino) é: {imc.ToString("F2")}");
                    InterpretarIMCInfantil(imc, age, sexo);
                }
            }
            else
            {
                Console.WriteLine("Sexo inválido. Digite 'masculino' ou 'feminino'.");
            }
        }
        else
        {
            Console.WriteLine("Classificação para adultos:");
            InterpretarIMCAdulto(imc);
        }
    }

    static void InterpretarIMCInfantil(double imc, int age, string sexo)
    {
        // Simulação de percentis (substitua por dados reais das tabelas da OMS ou CDC)
        double percentil = SimularPercentil(imc, age, sexo);

        if (percentil < 5)
        {
            Console.WriteLine("Classificação: Baixo peso");
        }
        else if (percentil >= 5 && percentil <= 85)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (percentil > 85 && percentil <= 95)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade");
        }
    }

    static void InterpretarIMCAdulto(double imc)
    {
        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc >= 25.0 && imc <= 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else if (imc >= 30.0 && imc <= 34.9)
        {
            Console.WriteLine("Classificação: Obesidade Grau I");
        }
        else if (imc >= 35.0 && imc <= 39.9)
        {
            Console.WriteLine("Classificação: Obesidade Grau II");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade Grau III");
        }
    }

    static double SimularPercentil(double imc, int age, string sexo)
    {
        // Simulação simples de percentil (substitua por dados reais)
        // Aqui você pode implementar a lógica para consultar tabelas da OMS ou CDC
        Random random = new Random();
        return random.NextDouble() * 100; // Retorna um valor aleatório entre 0 e 100
    }
}