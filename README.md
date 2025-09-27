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

- Ao clicar sem o nome da cidade a mensagem “Preencher o nome da cidade”, aparece abaixo.
- Cidade não encontrada.  
- Sem conexão com a internet.
O tratamento foi implementado com base no `HttpResponseMessage.StatusCode`.  

---

## ⚙️ Desafios Enfrentados

- Ajustar o código para utilizar corretamente os nomes dos elementos da interface
- Corrigir erros de sintaxe no tratamento de condições (`if/else`) e fechamento de blocos.  
- Tratar cenários de erro retornados pela API, como cidade inexistente  e sem conexão de internet.  
- Converter corretamente os horários de nascer e pôr do sol, que vêm como Unix Timestamp, para o formato legível em horas e minutos.  
- Exibir a temperatura mínima e máxima com símbolo de graus Celsius (ºC) de forma clara para o usuário.
  
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

## ✅ **Agenda 8 — 🌍 Desenvolvimento Mobile com Sensores móveis e geolocalização (.NET MAUI)**

Os smartphones possuem **sensores** que permitem maior interação com o ambiente e fornecem dados para aplicações móveis.  

**Sensores Comuns:**
- 📍 **GPS (Geolocalização)** → posição geográfica do dispositivo.  
- ↕️ **Acelerômetro** → detecção de movimento/inclinação.  
- 🔄 **Giroscópio** → orientação e rotação.  
- 🧭 **Magnetômetro** → usado como bússola.  
- 💡 **Sensor de Luz** → intensidade luminosa do ambiente.  
- 📶 **Proximidade** → detecta objetos próximos.  

**APIs do .NET MAUI:**
- `Geolocation` → obtém latitude e longitude.  
- `GeolocationRequest` → configura precisão e tempo limite.  
- `Geocoding` → converte coordenadas em endereços legíveis e vice-versa.  
- `WebView` → permite exibir conteúdo da web (HTML, mapas, sites interativos) dentro do app. 

---

## ⚙️ Desafios Enfrentados
- Solicitar e tratar permissões de localização no app.  
- Implementar corretamente a API de geolocalização e lidar com GPS desligado.  
- Converter coordenadas para endereços legíveis de forma precisa.  

---

## 📌 Funcionalidades Implementadas
- Uso da API `Geolocation` para capturar a posição atual do usuário.  
- Conversão de latitude/longitude em endereço com `Geocoding`.  
- Tratamento de erros e exceções comuns:  
  - `PermissionException` (permissão negada).  
  - `FeatureNotEnabledException` (GPS desativado).  
- Exibição de conteúdo da web dentro do app utilizando **WebView** (ex.: mapas interativos).  

---

## 📸 Evidências
📍 Consulta de localização via GPS (latitude/longitude).  
🗺️ Conversão de coordenadas em endereço com `Geocoding`.  
🌐 Exibição de mapa interativo com WebView.  

---

## 📝 Conclusão
Na **Agenda 8**, o app 🌦️Tempo Agora foi expandido com recursos de **sensores móveis e geolocalização**, fortalecendo a interação com o ambiente.  

---

## 🛠 Tecnologias Utilizadas
- **.NET MAUI** — Framework multiplataforma.  
- **C#** — Linguagem de programação.  
- **HttpClient** — Requisições REST.  
- **Newtonsoft.Json** — Desserialização de JSON.  
- **API de Clima (OpenWeatherMap)** — Fonte dos dados meteorológicos.  
