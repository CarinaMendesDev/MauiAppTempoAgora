# 🌦️App TempoAgora App TempoAgora - Agenda 7

Este projeto faz parte da disciplina **Desenvolvimento de Sistemas III - Programação Mobile II**  
O foco é a **integração com APIs externas** utilizando **.NET MAUI** e o consumo de dados via **Web Services**.  

📌 **Objetivo:** Aprender a consumir uma API de clima em tempo real, exibir informações adicionais ao usuário e aplicar **tratamento de erros** para garantir robustez ao aplicativo.  
Utilizando Microsoft MAUI para Desenvolvimento Mobile.

---

## 📖 Conceitos Principais  

### 🔹 API e Web Services  
- **API:** Ponte que permite que diferentes sistemas conversem entre si (analogia: API = garçom).  
- **Web Services:** Padrão de comunicação pela internet entre sistemas.  
  - **SOAP:** Baseado em XML, mais rígido, usado em ambientes corporativos.  
  - **REST:** Mais flexível, usa métodos HTTP (GET, POST, PUT, DELETE).  

### 🔹 HttpClient no .NET  
- Classe para realizar chamadas HTTP e consumir APIs RESTful.  
- Suporta operações assíncronas e tratamento de cabeçalhos.  
- Ideal para integração em aplicativos móveis.  

### 🔹 Manipulação de Respostas  
- `HttpResponseMessage` → contém **StatusCode**, **ReasonPhrase**, **Content**.  
- Deve ser utilizado com `using` para evitar vazamento de memória.  

### 🔹 JSON  
- Formato leve de **chave-valor**, ideal para troca de dados.  
- Biblioteca **Newtonsoft.Json** utilizada no .NET para serializar/desserializar objetos.  

---

## 📌 Funcionalidades Implementadas

- **Consumo de API RESTful** (OpenWeatherMap ou similar) utilizando `HttpClient`.  
- **Exibição de informações climáticas em tempo real**, incluindo:  
  - 🌡️ Temperatura  
  - 🌦️ Descrição textual do clima (`description`)  
  - 💨 Velocidade do vento (`speed`)  
  - 👁️ Visibilidade (`visibility`)  

- **Tratamento de erros aprimorado**:  
  - Mensagem específica quando a cidade não for encontrada (`404 Not Found`).  
  - Alerta quando não houver conexão com a internet.  

- **Resposta em JSON convertida para objetos C#** utilizando **Newtonsoft.Json**.  
- **Interface simples e intuitiva** para consulta do clima em qualquer cidade.  

---

## 🛠️ Implementação Prática – App **TempoAgora**  

A atividade prática da Agenda 07 consistiu em expandir o aplicativo **TempoAgora**, consumindo a API **OpenWeatherMap** e aplicando melhorias de usabilidade.  

### ✅ Parte 1 – Expansão dos Dados  
Foram adicionadas as seguintes informações ao resultado exibido:  
- Descrição do clima (**description**).  
- Velocidade do vento (**speed**).  
- Visibilidade (**visibility**).  

Esses campos já estavam presentes no JSON da API e foram mapeados no modelo `Tempo`.  

### ✅ Parte 2 – Tratamento de Erros  
- Exibição de mensagem específica quando o nome da cidade não for encontrado (**404 Not Found**).  
- Exibição de alerta quando o usuário estiver sem internet.  

O tratamento foi implementado com base no `HttpResponseMessage.StatusCode`.  

---

## ⚙️ Desafios Enfrentados  
- Ajustar o **modelo C#** para refletir os novos campos do JSON.  
- Garantir que erros de conexão não fechassem o app.  
- Simular cenários de erro para validar as mensagens (cidade inválida, offline, etc.).  

---

## 📸 Evidências  
*(prints de tela )*  

- Consulta de cidade com dados completos.  
- Erro de cidade inexistente.  
- Alerta de falta de conexão.  

---

## 📝 Conclusão  
O app **TempoAgora** foi expandido para apresentar informações meteorológicas mais ricas e passou a lidar de forma amigável com erros comuns.  
Essa atividade reforçou conceitos de **consumo de APIs REST**, **serialização JSON** e **tratamento de exceções em apps mobile** com **.NET MAUI**.  

---

## 🛠 Tecnologias Utilizadas
- **.NET MAUI** — Framework multiplataforma.  
- **C#** — Linguagem de programação.  
- **HttpClient** — Requisições REST.  
- **Newtonsoft.Json** — Desserialização de JSON.  
- **API de Clima (OpenWeatherMap)** — Fonte dos dados meteorológicos.  
