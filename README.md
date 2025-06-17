

---

## 📱 Desafio de Abstração com POO - Trilha .NET

Este projeto faz parte do desafio da **trilha .NET da Digital Innovation One (DIO)**. O objetivo foi aplicar os conceitos de **Programação Orientada a Objetos (POO)** na prática, através da abstração de um sistema que simula celulares de diferentes marcas.

---

## 🛠️ Tecnologias Utilizadas

* C# (.NET)
* Programação Orientada a Objetos (POO)
* .NET SDK 6.0 ou superior
* Visual Studio Code / Visual Studio / Rider (IDE)
* Git e GitHub

---

## 🚀 Descrição do Desafio

O desafio consistiu em criar uma classe abstrata chamada `Smartphone`, que possui as seguintes propriedades:

* `Numero` (pública)
* `Modelo` (protegida)
* `Imei` (protegida)
* `Memoria` (protegida)

Além dos métodos:

* `Ligar()`
* `ReceberLigacao()`
* `InstalarAplicativo(string nome)` (abstrato — deve ser sobrescrito pelas classes filhas)

### 🏗️ Classes que herdam de `Smartphone`:

* **Nokia**
* **iPhone**

Cada uma dessas classes implementa o método abstrato `InstalarAplicativo` de forma personalizada, simulando a instalação de aplicativos em dispositivos diferentes.

---

## 📑 Diagrama de Classes

```plaintext
           Smartphone (abstract)
        ┌───────────────────────────────┐
        │ + Numero: string               │
        │ - Modelo: string                │
        │ - IMEI: string                  │
        │ - Memoria: int                  │
        │ + Ligar()                       │
        │ + ReceberLigacao()              │
        │ + InstalarAplicativo(nome) (abs)│
        └────────────┬────────────────────┘
                     │
         ┌───────────┴───────────┐
         │                       │
      Nokia                   Iphone
      (override               (override
       InstalarAplicativo)     InstalarAplicativo)
```

---

## 🎯 Funcionalidades

* Ligar o celular
* Receber ligação
* Instalar aplicativos
* Diferenciar comportamento por marca (`Nokia` e `Iphone`)

---

## ▶️ Como Executar o Projeto

1. Clone este repositório:

```bash
git clone https://github.com/seu-usuario/trilha-net-poo-desafio.git
```

2. Navegue até a pasta do projeto:

```bash
cd trilha-net-poo-desafio
```

3. Compile o projeto:

```bash
dotnet build
```

4. Execute o projeto:

```bash
dotnet run
```

---

## 💡 Aprendizados

✔️ Abstração
✔️ Herança
✔️ Encapsulamento
✔️ Polimorfismo
✔️ Estrutura de Classes no .NET
✔️ Boas práticas de desenvolvimento orientado a objetos

---

## 🤝 Contribuição

Sinta-se livre para abrir issues ou enviar pull requests com melhorias e sugestões!

---

## 🔗 Links Úteis

* [DIO - Digital Innovation One](https://www.dio.me/)
* [.NET Documentation](https://learn.microsoft.com/pt-br/dotnet/)
* [GitHub Docs](https://docs.github.com/)

---

## 🧑‍💻 Autor

**Gabriel Geovanne**

---

## 🏆 Licença

Este projeto é livre para uso e aprendizado. 🚀

---

## 🚀 Resultado

✅ Projeto funcionando com sucesso!

---


