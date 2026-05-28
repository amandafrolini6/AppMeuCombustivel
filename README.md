# ⛽ AppMeuCombustivel

> Aplicativo mobile desenvolvido em .NET MAUI que auxilia motoristas a tomarem a melhor decisão na hora de abastecer. Basta informar o preço do etanol e da gasolina: com base na famosa **regra dos 70%**, o app calcula automaticamente e indica, de forma simples e prática, qual combustível é mais vantajoso financeiramente.

---

## 📱 Sobre o projeto

O **AppMeuCombustivel** é um aplicativo mobile simples e direto ao ponto. Ele resolve uma dúvida muito comum entre os motoristas brasileiros: *etanol ou gasolina — qual compensa mais hoje?*

O app utiliza a **regra dos 70%**, amplamente conhecida no Brasil, que diz:

> **Se o preço do etanol for menor ou igual a 70% do preço da gasolina, o etanol compensa. Caso contrário, a gasolina é a melhor opção.**

### 🔢 Como a conta funciona?

Exemplo prático:
- Gasolina: R$ 6,00
- 70% de R$ 6,00 = R$ 4,20
- Se o etanol custar **até R$ 4,20** → abasteça com **etanol**
- Se o etanol custar **mais de R$ 4,20** → abasteça com **gasolina**

O app faz exatamente esse cálculo por você!

---

## 🛠️ Tecnologias utilizadas

| Tecnologia | Finalidade |
|---|---|
| **.NET MAUI** | Framework principal para desenvolvimento mobile multiplataforma |
| **C#** | Linguagem de programação usada na lógica do app |
| **XAML** | Linguagem de marcação usada para construir a interface visual |
| **.NET 10** | Versão do .NET usada no projeto |

---

## 📂 Estrutura do projeto

```
AppMeuCombustivel/
│
├── MainPage.xaml          # Tela principal — interface do usuário (campos e botão)
├── MainPage.xaml.cs       # Lógica do botão e cálculo do combustível
│
├── AppShell.xaml          # Define a navegação do app (qual tela aparece primeiro)
├── App.xaml               # Configurações globais de estilo e recursos do app
├── MauiProgram.cs         # Ponto de entrada — inicializa e configura o app
│
├── Resources/
│   ├── Styles/            # Cores e estilos globais
│   ├── Fonts/             # Fontes customizadas (OpenSans)
│   ├── Images/            # Imagens do projeto
│   ├── AppIcon/           # Ícone do aplicativo
│   └── Splash/            # Tela de carregamento (splash screen)
│
└── Platforms/
    ├── Android/           # Configurações específicas para Android
    ├── iOS/               # Configurações específicas para iOS
    ├── Windows/           # Configurações específicas para Windows
    └── MacCatalyst/       # Configurações específicas para macOS
```

---

## ▶️ Como executar o projeto

### Pré-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/) com a carga de trabalho **.NET MAUI** instalada
- .NET 10 SDK
- Emulador Android configurado **ou** dispositivo físico com depuração USB ativada

---

## 🎓 Contexto acadêmico

Projeto desenvolvido durante o curso de **Desenvolvimento de Software Multiplataforma**, referente a matéria de **Desenvolvimento Web II** na **FATEC Jahu**, com o objetivo de praticar os fundamentos do desenvolvimento mobile com **.NET MAUI**.

---

## 👩‍💻 Autora

Desenvolvido por **Amanda** — estudante de DSM na FATEC Jahu.
