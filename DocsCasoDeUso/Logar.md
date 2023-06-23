# ESPECIFICAÇÂO DO CASO DE USO ACESSAR

### 1. Resumo
Acessar o dashboard do SUAP

### 2. Atores
Professores e alunos do IFRN

### 3. Pre-condições 
Estar registrado no sistema

### 4. Pós-condições
O sistema disponibilizara os caminhos principais e noticias que envolvem a instituição

## 5. Fluxos 
### 5.1 Fluxo Principal
|Usuario | Sistema |
|:--- | ---:|
|Usario entra com suas credencias(matricula do aluno, ou professor, e senha) | |
| | Valida e redirecionar para a pagina de dashboard |
|Usuario visualiza a dashboard| |


### 5.2. Fluxos alternativos
|Usuario | Sistema |
|:--- | ---:|
|Aciona a funcionalidade entrar com Gov.br | |
| | Sistema apresenta formulario do gov br |
|Usario entra com suas credencias(senha e cpf) | |
| | Valida e redirecionar para a pagina de dashboard |
|Usuario visualiza a dashboard| |

### 5.3 Flucos de exceção
  a) Erro nas credencias: Sistema indicara o que das credenciais é invalida

### 6.Dicionario de dados
+ Matricula - dados numerios de 10 caracteres
+ Senha - dados alphanumericos de pelo menos 8 caracteres

### 7.Regras de negocio
+ Senha - minimo 8 caracteres, pelo menos uma letra maiuscula, minuscula e um caracter especial
