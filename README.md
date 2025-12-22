# Simulado POO

## 🏁 Sistema de Gerenciamento de Corridas

### Objetivo
Desenvolver um sistema simples para gerenciar veículos de competição, permitindo controlar participação em corridas, aplicar regras de segurança e gerar relatórios para análise.
O foco do exercício é organização de código, reutilização, flexibilidade e clareza na modelagem.

### Contexto
Uma competição esportiva trabalha com diferentes tipos de veículos:
- Carros
- Motos
- Karts

Todos os veículos compartilham algumas informações em comum, como nome, ano de fabricação e uma pontuação média obtida em corridas anteriores.
Apesar disso, cada tipo de veículo possui informações específicas e se comporta de maneira diferente quando entra na pista.

## 🛠️ Requisitos do Sistema
Você é livre para definir a estrutura do código (classes, interfaces, structs, etc.), desde que os requisitos abaixo sejam atendidos.

### 1. Estrutura dos Veículos
O sistema deve tratar todos os veículos de forma unificada, evitando código duplicado.
Todo veículo possui:
- Nome
- Ano de fabricação
- Pontuação média
- O Tempo de Prova deve ser representado por um tipo separado contendo minutos e segundos.
- Esse dado não deve ser alterado após sua criação.
- Explique brevemente sua escolha de estrutura para esse tipo.

Informações específicas:
- Carros possuem Fabricante e Categoria.
- Motos possuem Piloto e Cilindradas.
- Karts possuem Equipe e Número do Kart.

## 2. Entrada na Pista
Todo veículo pode entrar na pista.
Ao entrar na pista, uma mensagem deve ser exibida.
O conteúdo dessa mensagem varia conforme o tipo:
- Carros exibem o fabricante.
- Motos exibem o piloto.
- Karts exibem a equipe.

## 3. Regra de Segurança
Alguns veículos possuem uma exigência mínima de experiência do piloto.
Caso alguém tente colocar um veículo na pista sem atender essa exigência:
- A ação deve ser bloqueada.
- Uma notificação específica do domínio deve ser gerada.
- Quem chamou o método é obrigado a lidar com essa notificação.
- 💡 A forma de sinalizar essa situação fica a critério do desenvolvedor.

## 4. Organização da Competição
O sistema deve possuir uma estrutura chamada Grid de Largada.
Esse grid deve:
- Aceitar apenas veículos
- Ser reutilizável para qualquer tipo atual ou futuro
- Deve permitir:
- Adicionar veículos
- Remover veículos
- Listar os veículos inscritos

## 5. Relatórios da Corrida
- Utilizando LINQ com sintaxe de métodos (Lambda Expressions), implemente as seguintes consultas:
- Listar todos os veículos de uma categoria específica.
- Listar os veículos ordenados do mais novo para o mais antigo (ano de fabricação).

- Criar uma projeção contendo:
    - Nome do veículo
    - Uma string no formato:
    - "Ano: [ano]"
    - Agrupar os veículos pelo ano de fabricação
