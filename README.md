<p align="center">
  <img src="https://github.com/andrebecker84/AppWebASPNETcoreTP2/assets/39974878/2c3a2ab1-5789-47d3-ade6-e300e2b8af69">
</p>
<br>

<p align="center">PROJETO DE BLOCO: DESENVOLVIMENTO BACK-END</p>
<br>
<p align="center">Teste de Performance - TP7</p>
<br>
<p align="center">Aplicativo do Console C# - ControleAcademico</p>
<br>
<p align="center">
  <img src="https://github.com/andrebecker84/ControleAcademico/assets/39974878/20a3a1a9-dd3e-4a15-8c8d-343303821a02">
</p>

---

## ENUNCIADO

A partir da descrição das funcionalidades do Sistema de Controle Acadêmico (SCA) apresentada anteriormente, realize os exercícios abaixo:

1. Descreva o caso de uso Lançar Notas considerando apenas o fluxo principal.
   
2. Implemente o diagrama de sequência que reflita o caso de uso Lançar Notas, utilizando apenas as classes envolvidas. Não se preocupe com os fluxos condicionais e de repetições.
   
3. Implemente as classes Aluno, Professor, Disciplina e Turma a partir do Diagrama de Classes (DC) abaixo, que não representa exatamente o minimundo do SCA, apresentado anteriormente. O DC omitiu os métodos get, set e toString das classes.

<p align="center">
  <img src="https://github.com/andrebecker84/ControleAcademico/assets/39974878/5d81df04-c32d-4e7d-b1d8-b3579d1e1c2f" alt="Descrição da imagem">
</p>

A classe Turma possui três métodos: addAluno, abrirTurma e gerarPauta. O método addAluno recebe um aluno e verifica se é possível adicioná-lo à turma, retornando “Aluno adicionado” ou “Turma cheia”, em função das regras de negócios. O método abrirTurma verifica se é possível abrir a turma e retorna verdadeiro ou falso, em função das regras de negócios. O método gerarPauta retorna uma string com as informações da turma para ser exibida na console do usuário. A pauta deve conter o código da turma, o nome da disciplina, o nome do professor e a lista de alunos inscritos.

Você pode implementar as classes e o programa principal em Java ou C#.

4. Teste as classes criadas a partir do programa principal, utilizando a console, e verifique o funcionamento correto dos métodos da classe Turma.
