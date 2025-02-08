# 🏗 LeetCode Solution - Detect Capital (520)

Este projeto contém uma **implementação profissional** para o problema **520 - Detectar Capital** do LeetCode, desenvolvida em **C# e .NET 8**, utilizando **Clean Architecture** e princípios do **Domain-Driven Design (DDD)**.

## 📌 Sobre o Problema

O problema define que o uso de maiúsculas em uma palavra é correto se atender a um dos seguintes critérios:

1. Todas as letras são maiúsculas (ex: `"USA"`) ✅  
2. Nenhuma das letras é maiúscula (ex: `"leetcode"`) ✅  
3. Apenas a primeira letra é maiúscula (ex: `"Google"`) ✅  

Caso contrário, o uso de maiúsculas é incorreto.

🔗 **Link do problema no LeetCode**: [520. Detect Capital](https://leetcode.com/problems/detect-capital/)

---

## 🏗 Arquitetura do Projeto

O projeto segue a **Clean Architecture**, baseada nos princípios do **DDD**, organizando as responsabilidades em camadas bem definidas.


---

## 🛠 Tecnologias Utilizadas

- **.NET 8** 🚀  
- **C#  🔥  
- **Clean Architecture** 🏗  
- **DDD (Domain-Driven Design)** 🎯  
- **GitHub Actions** *(Opcional - para CI/CD)*  

---

📌 Padrões de Código e Arquitetura
✅ 1. Separação de Responsabilidades (SRP)
Cada camada tem uma única responsabilidade:
Application Layer: Contém os Casos de Uso e regras de negócio.
Core Layer: Ponto de entrada da aplicação.

✅ 2. Interface e Implementação (ISP)
Utilizamos Interfaces (ISolutionDetectCapital) para definir contratos de implementação, garantindo baixo acoplamento e facilidade de manutenção.

✅ 3. Injeção de Dependência (DIP)
A classe SolutionDetectCapital é injetada no programa, seguindo o princípio da Injeção de Dependência.


## 🚀 Como Rodar o Projeto

### 🔹 1. Clonar o Repositório e Rodar o a solução

```sh
git clone https://github.com/seu-usuario/LeetCodeSolution.git
cd LeetCodeSolution
dotnet run --project src/LeetCodeSolution.Core



🔗 Contato
Caso tenha dúvidas ou sugestões, entre em contato! 🚀

📧 Email: jvictorportela30@outlook.com
💼 LinkedIn: [Meu Perfil](https://www.linkedin.com/in/jo%C3%A3o-victor-portela-146a71248/)
