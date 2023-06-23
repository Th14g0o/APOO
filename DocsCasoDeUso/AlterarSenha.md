# ESPECIFICAÇÂO DO CASO DE USO ESQUECEU OU DESEJ ALTERAR SUA SENHA

### 1. Resumo
Alterar senha cadastrada no sistema

### 2. Atores
Professores, tecnicos e alunos do IFRN

### 3. Pre-condições 
Estar registrado no sistema

## 4. Fluxos 
### 4.1 Fluxo Principal
|Usuario | Sistema |
|:--- | ---:|
| 1. Aciona a funcionalidade "Esqueceu  ou deseja alterar sua senha". | |
| | 2. Redirieciona a uma pagina com captcha e formulario, contendo aa senha, cpf/passaporte. |
| 3. Aciona a funcionalidade "Enviar".| |
|  | 4. Valida os dados e envia para seu email registrado com link. exibe uma mensagem de confirmação. |
| 5. Usuario acessa sua caixa de emails e cliaca no link enviado pelo suap. |  |
| |  6. Redireciona para uma pagina com um formulario para o preenchimento de uma nova senha |
| 7.Aciona  a funcionalidade enviar |  |
| |  8. Redireciona para o login com uma mensagem "senha alterada com sucesso"|


### 4.2 Flucos de exceção
  a) Erro nos dados fornecidos: Sistema indicara o que dos dados é invalida

### 5.Dicionario de dados
+ Matricula - dados numerios de 10 caracteres
+ CPF - dados alphanumericos de pelo menos 8 caracteres (minimo 8 caracteres, pelo menos uma letra maiuscula, minuscula e um caracter especial)
+ Passaporte - dados composto por duas letras e seis digitos.
