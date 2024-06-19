# Gerador-de-Testes

## Requisitos Funcionais

### Módulo de Disciplinas

#### Cadastrar Novas Disciplinas

- O registro de disciplina é composto por nome
- O campo nome é obrigatório
- Não pode registrar uma disciplina com o mesmo nome
- A disciplina deve armazenar informações sobre as matérias que serão relacionadas à ela posteriormente
#### Protótipo:
![image](https://github.com/Good-of-Void/Gerador-de-Testes/assets/160282205/838a2a19-3c32-4685-94ed-ba334a724421)

#### Editar Disciplinas

- Os critérios de validação são os mesmos do Requisito do Cadastrar Novas Disciplinas
  
#### Excluir Disciplinas

- Não deve ser possível excluir disciplinas com matérias e testes relacionados.
  
#### Visualizar Todas as Disciplinas.

- Deve exibir: Id e Nome
  
### Módulo de Matérias

#### Cadastrar Matérias.

- O registro de matéria é composto por nome, disciplina e série
- Todos os campos são obrigatórios
- Não pode registrar uma matéria com o mesmo nome
#### Protótipos:
![image](https://github.com/Good-of-Void/Gerador-de-Testes/assets/160282205/2384db62-2f65-4027-b7bf-84d8ac4fae9b)

#### Editar Matérias.

- Os critérios de validação são os mesmos do Cadastrar Matérias
#### Excluir Matérias.

- Não deve ser possível excluir matérias sendo utilizadas em questões.
  
#### Visualizar Todas as Matérias.

- Deve exibir: Id, Nome, Disciplina e Série



### Módulo de Questões
#### Cadastrar Questões.

- O registro de questão é composto por matéria, enunciado e alternativas.
- Todos os campos são obrigatórios
- Cada questão deve ter um mínimo e máximo de alternativas (máximo sugerido: 4)
#### Protótipo:
![image](https://github.com/Good-of-Void/Gerador-de-Testes/assets/160282205/ea6c4097-8ce3-4390-9177-f59cbc685cd8)


#### Editar Questões.

- Os critérios de validação são os mesmos do Cadastrar Questões
####  Excluir Questões.

- Não deve ser possível excluir uma questão relacionada a um teste.
####  Visualizar Todas as Questões.

 -Deve exibir: Id, Enunciado, Matéria e Resposta Correta
####  Configurar Alternativas da Questão.

- Deve permitir adicionar alternativas à questão
- Deve permitir remover alternativas à questão
- Não permitir o cadastro de questões sem uma alternativa correta
- Não deve permitir o cadastro de mais de uma alternativa correta
- No mínimo duas alternativas devem ser configuradas

### Módulo de Testes
#### Gerar Testes.

- O registro de teste é composto por título, disciplina, matéria*, série e quantidade de questões
- Deve ser informado a quantidade de questões que deverão ser geradas
- Não pode registrar um teste com o mesmo nome
- A quantidade de questões informada deve ser menor ou igual a quantidade de questões cadastradas
- As matérias devem ser carregadas a partir da disciplina selecionada
- Não deve permitir selecionar uma matéria que não pertença a disciplina selecionada.
- Caso a disciplina seja alterada, o campo matéria deve ficar em branco
- Caso seja “Prova de Recuperação” deve considerar as questões de todas as matérias da disciplina selecionada
- Todo1s os campos são obrigatórios.
- As questões devem ser selecionadas de forma aleatória
#### Protótipo:
![image](https://github.com/Good-of-Void/Gerador-de-Testes/assets/160282205/c9ad1c99-725b-4a7a-b825-3714df81311d)


#### Duplicar Testes.

- Deve permitir duplicar testes
- Na duplicação do teste o título, disciplina, quantidade de questões, série, prova de recuperação e matéria deverão vir preenchidos
- Não pode duplicar um teste com o mesmo nome
- Na duplicação do teste, as questões devem vir em branco

#### Excluir Testes.

- Deve permitir excluir testes existentes
#### Visualizar Todos os Testes.

- Deve exibir: Id, Título, Disciplina, Matéria (ou informar se é recuperação) e Quantidade de Questões
#### Visualizar Detalhes sobre Testes.

- Deve ser possível visualizar os testes individualmente, com informações detalhadas incluindo as questões.
		Protótipo:
		

#### Gerar PDF dos Testes.

- O arquivo PDF do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas as alternativas
#### Gerar PDF do Gabarito dos Testes.

- O arquivo PDF do Gabarito do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas alternativas (com a alternativa correta assinalada)
