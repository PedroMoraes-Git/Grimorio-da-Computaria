Esse arquivo parece ser meio redundante por enquanto, mas daqui alguns meses quando eu esquecer (e eu **vou** esquecer), sei onde encontrar o que eu preciso.

### Mexendo com repo que já existe

`git clone https://github.com/nomedeusuario/algumrepositoriodoido.git` - Sinceramente nem precisa explicar o que o clone faz, mas ok, ele clona um repositório da nuvem pra máquina pelo link

`git add .` - Adiciona no staging as mudanças no diretório atual e seus subdiretórios, também aceita como argumento arquivos, tipo `arquivoDeExemplo.txt` ou pastas e subpastas tipo `nomeDaPasta/`

`git commit -m "descrição DECENTE E CLARA do que foi feito"` - Aqui ele salva as mudanças preparadas com o git add e usa a flag `-m` pra escrever direto no terminal a mensagem do commit, pense antes de fazer e escreva mensagens boas, nosso eu do futuro agradece

`git push -u origin main` - E por fim, esse daqui, além de mandar pro GitHub, configura um negócio chamado upstream tracking (por isso o `-u`, upstream) pra branch local e a remota, deixando a gente usar git pull/push direto depois da primeira vez

### Criando um repo (diferenças)

`mkdir projeto-doido; cd projeto-doido` - Precisa criar ou ter um projeto antes de criar o repositório, obviamente

`git init` - Invoca o Git no projeto, importante não esquecer desse

`git remote add https://github.com/nomedeusuario/algumrepositoriodoido.git` - É bom copiar o link certo pra não dar ruim, aqui simplesmente conecta o repositório remoto com o local

**Sessão de bom senso:** É a mesma coisa do primeiro depois da configuração inicial, não preciso ficar repetindo os comandos