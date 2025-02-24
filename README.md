# Calculadora de IMC (Índice de Massa Corporal)

Este é um programa simples em C# que calcula o Índice de Massa Corporal (IMC) de uma pessoa e fornece uma classificação com base na idade e sexo. O programa foi desenvolvido para atender tanto adultos quanto crianças/adolescentes, utilizando diferentes critérios de interpretação.

## Funcionalidades

- **Cálculo do IMC:** O programa calcula o IMC usando a fórmula padrão:
IMC = peso (kg) / (altura (m) * altura (m))

- **Classificação por Faixa Etária:**
- Para **adultos (20+ anos):** Usa as faixas padrão de IMC definidas pela OMS.
- Para **crianças e adolescentes (0-19 anos):** Interpreta o IMC com base em percentis específicos para idade e sexo (simulação simplificada).

- **Validação de Entradas:** Garante que o usuário insira valores válidos para peso, altura, idade e sexo.

## Como Usar

1. Clone este repositório ou copie o código para o seu ambiente de desenvolvimento.
2. Compile e execute o programa.
3. Siga as instruções no terminal para inserir os dados:
 - Nome
 - Sexo (`masculino` ou `feminino`)
 - Idade
 - Peso (em kg)
 - Altura (em metros)
4. O programa calculará o IMC e fornecerá uma classificação com base nos critérios mencionados.

## Exemplo de Saída

### Para Adultos (20+ anos):
Digite seu nome!
João
Digite o sexo (masculino/feminino):
masculino
Digite sua idade!
25
Digite seu peso (em kg)!
70
Digite sua altura (em metros)!
1.75
Olá: João
Seu IMC é: 22.86
Classificação para adultos:
Classificação: Peso normal

### Para Crianças/Adolescentes (0-19 anos):
Digite seu nome!
Maria
Digite o sexo (masculino/feminino):
feminino
Digite sua idade!
10
Digite seu peso (em kg)!
35
Digite sua altura (em metros)!
1.35
Olá: Maria
Seu IMC é: 19.20
Classificação para crianças e adolescentes:
O IMC desta menina é: 19.20
Classificação: Sobrepeso

## Estrutura do Código

O programa está organizado da seguinte forma:

1. **Função Principal (`Main`):**
   - Chama a função `CalcularIMC()` para iniciar o cálculo.

2. **Função `CalcularIMC`:**
   - Solicita os dados do usuário.
   - Calcula o IMC.
   - Classifica o IMC com base na idade e sexo.

3. **Funções Auxiliares:**
   - `InterpretarIMCAdulto`: Classifica o IMC para adultos.
   - `InterpretarIMCInfantil`: Classifica o IMC para crianças/adolescentes com base em percentis simulados.
   - `SimularPercentil`: Simula percentis para crianças/adolescentes (substituir por dados reais).

## Melhorias Futuras

- Implementar consultas reais às tabelas de percentis da OMS ou CDC para crianças/adolescentes.
- Adicionar suporte para múltiplas unidades de medida (ex.: libras e polegadas).
- Criar uma interface gráfica para facilitar a interação do usuário.
