
# Projeto Rede Social Whisperif

## Especificação do caso de uso - Gerenciar Grupos



### 1. Resumo 

Este caso de uso permite que os usuarios possam criar, ver e editar os dados básicos dos grupos criados por ele.

### 2. Atores 

Alunos

### 3. Pré-condições

O usuário precisa estar autenticado no sistema, alem disso, para editar e ver, você tem que ter criado pelo menos um grupo.

### 4. Fluxos de evento
#### 4.1 Fluxo Principal(Criar Grupo)
|  Ator  | Sistema |
|:-------|:------- |
|1. Usuario credenciado aciona a funcionalidade de Criar Grupo.||
||2. Manda um formulario com os dados de criação do grupo(nome, descrição, privacidade e foto).|
|3.Preenche o formulario e envia||
||4.sistema redireciona para o feed|
|5.Usuario visualiza seu feed||
     
#### 4.2 Fluxo Principal(Editar Grupo)
|  Ator  | Sistema |
|:-------|:------- |
|1. Usuario credenciado administrado do grupo, apos acionar a funcionalidade Ver Grupo, aciona a funcionalidade de Editar Grupo||
||2. Disponibilizar um formulario com base nos dados editaveis do grupo para a edição((nome, descrição, privacidade e foto))|
|3. O usuario Preenche o formulario e envia ||
||4. Valida os dados e redireciona para pagida de grupos que o usuario participa|
|5. Usuario visualiza seu grupos atualizados||

#### 4.3 Fluxo Principal(Ver Grupo)
|  Ator  | Sistema |
|:-------|:------- |
|1. Usuario credenciado aciona a funcionalidade de ver seu grupo.||
||2. Disponibiliza o nome, foto, descrição e membros do grupo|
|3. O usuario visualiza os dados do grupo||

 #### 4.1 e 4.2 Fluxo de excessão (Criar Grupo e Editar Grupo)
     a) Erro na validação: nome vazio e arquivo anexado não ser uma imagem,ambos voltam pro seu respectivo passo 2
   
    

### 5.Dicionario de dados
+ Nome - caracteres(no maximo 20)
+ Bio - Descrição com caracters(no maximo 100)
+ Foto - Imagem(png e jpg)
+ Privacidade - publico ou privado(bool)


