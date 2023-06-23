# Projeto Rede Social Whisperif

## Especificação do caso de uso - Gerenciar perfil



### 1. Resumo 

Este caso de uso permite que os usuarios possam ver e editar seu perfil.

### 2. Atores 

Alunos

### 3. Pré-condições

O usuário precisa estar autenticado no sistema.

### 4. Fluxos de evento
#### 4.1 Fluxo Principal(Ver perfil)
|  Ator  | Sistema |
|:-------|:------- |
|1. Usuario credenciado aciona a funcionalidade de ver seu perfil.||
||2. Disponibiliza sua bio, nome visivel, nome identificador e suas postagens de midia e texto.|
|3. O usuario visualiza seus dados||
     
#### 4.2 Fluxo Principal(Editar perfil)
|  Ator  | Sistema |
|:-------|:------- |
|1. Usuario credenciado aciona a funcionalidade de editar seu perfil||
||2. Disponibilizar um formulario com base nos dados editaveis do usuario para a edição|
|3. O usuario podera editar sua bio, nome visivel, foto e genero, por fim, acionar a funcionalidade alterar ||
||4. Valida os dados e manda uma mensagem de confirmações |
|5. Usuario visualiza seu perfil editado e uma mensagem("Seu perfil foi atualizado com sucesso")||
 #### 4.2 Fluxo de excessão 
     a) Erro na validação: nome visivel vazio e arquivo anexado não ser uma imagem e volta para o passo numero 3
   
    

### 5.Dicionario de dados
+ Nome visivel - caracteres(no maximo 20)
+ Bio - Descrição com caracters(no maximo 100)
+ Foto - Imagem(png e jpg)
+ Genero - Masculino, feminino ou não informar


