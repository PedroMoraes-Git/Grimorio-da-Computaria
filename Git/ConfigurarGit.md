Nesse arquivo tem simplesmente o básico pra configuração inicial do Git... Curioso como eu estou documentando Git enquanto uso Git

### Configuração básica

`git config --global user.name "Nome Estiloso"` - Aqui é só configurar um nome decente pra aparecer no histórico de commits

`git config --global user.email "email@seilá.com"` - Aqui precisa colocar o e-mail certo da conta do GitHub pra não fazer kaboom

`git config --list` - Por via das dúvidas, é bom usar isso pra listar as configurações 

`git config --global credential.helper store` - Esse é um feitiço perigoso, no próximo push/pull quando pedir usuário e senha, as credenciais vão ficar salvas no disco. É bom usar com responsabilidade 