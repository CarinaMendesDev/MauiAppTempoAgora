# 🌦️App Tempo Agora

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

- **Consumo de API RESTful** (OpenWeatherMap) utilizando `HttpClient`.  
- **Exibição de informações climáticas em tempo real**, incluindo:  
- 📍 **Latitude e Longitude**  
- 🌅 **Nascer do Sol**  
- 🌇 **Pôr do Sol**  
- 🌡️ **Temperatura mínima e máxima (ºC)**  
- 🌦️ **Descrição textual do clima (ex: nublado, ensolarado, chuva)**  
- 💨 **Velocidade do vento (m/s)**  
- 👁️ **Visibilidade (m)**  

✅ **Tratamento de erros:**  
  - Cidade não encontrada.  
  - Sem conexão com a internet.

---

## 📅 Andamento do Desenvolvimento

## ✅ **Agenda 7 —🛠️ Implementação Prática**

Expandir o aplicativo **TempoAgora**, consumindo a API **OpenWeatherMap** e aplicando melhorias de usabilidade.  

### 🔹 Parte 1 – Expansão dos Dados

Foram adicionadas as seguintes informações ao resultado exibido:  
- 🌦️ **Descrição textual do clima**  
- 💨 **Velocidade do vento** 
- 👁️ **Visibilidade**
  
### 🔹 Parte 2 – Tratamento de Erros

- Cidade não encontrada (404).  
- Sem conexão com a internet.
O tratamento foi implementado com base no `HttpResponseMessage.StatusCode`.  

---

## ⚙️ Desafios Enfrentados

- Ajustar o **modelo C#** para refletir os novos campos do JSON.  
- Garantir que erros de conexão não fechassem o app.  
- Simular cenários de erro para validar as mensagens (cidade inválida).  

---

## 📸 Evidências

<img width="275" height="389" alt="image" src="https://github.com/user-attachments/assets/e2801b5c-1322-41b9-962c-ad52a476043e" />

### 🔹 Consulta de cidade com dados completos.
<img width="271" height="389" alt="image" src="https://github.com/user-attachments/assets/37b76cda-3047-4ca3-b4ad-527f4c4904cf" />

### 🔹 Erro de cidade inexistente.
<img width="273" height="391" alt="image" src="https://github.com/user-attachments/assets/3a2feef9-175e-4c66-962a-f12b8189879c" />

### 🔹 Sem conexão com internet.
<img width="273" height="392" alt="image" src="https://github.com/user-attachments/assets/689f91e4-4818-4749-b2ce-7bc71dbedfa0" />

---

## 📝 Conclusão  
O app **🌦️Tempo Agora** foi expandido para apresentar informações meteorológicas mais ricas e passou a lidar de forma amigável com erros comuns.  
Essa atividade reforçou conceitos de **consumo de APIs REST**, **serialização JSON** e **tratamento de exceções em apps mobile** com **.NET MAUI**.  

---

## 🛠 Tecnologias Utilizadas
- **.NET MAUI** — Framework multiplataforma.  
- **C#** — Linguagem de programação.  
- **HttpClient** — Requisições REST.  
- **Newtonsoft.Json** — Desserialização de JSON.  
- **API de Clima (OpenWeatherMap)** — Fonte dos dados meteorológicos.  
