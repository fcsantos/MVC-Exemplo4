# MVC-Exemplo4

MVC 5 (Razor), MongoDB 3.4.1, RoboMongo(MongoDB Manager), Bootstrap 3, jquery 1.9.1, Validação com DataAnnotations

Instalando MongoDB
https://www.mongodb.com/download-center#community

Instalando RoboMongo (Opcional)
https://robomongo.org/download

Após instalar o mongoDB

Vá até a pasta onde foi instalado o MongoDB e copie o caminho
c:\program files\MongoDB\Server\versao_atual_mongo\bin

Após copiar o caminho

Adicionar a variavel PATH do sistema

Windows 10 e Windows 8
Em Pesquisar, procure e selecione: Sistema (Painel de Controle)
Clique no link Configurações avançadas do sistema.
Clique em Variáveis de Ambiente. Na seção Variáveis do Sistema, localize a variável de ambiente PATH e selecione-a. Clique em Editar. Se a variável de ambiente PATH não existir, clique em Novo.
Na janela Editar Variável de Sistema (ou Nova Variável de Sistema), especifique o valor da variável de ambiente PATH. Clique em OK. Feche todas as janelas restantes clicando em OK.
Reabra a janela Prompt de comando e execute o comando "mongod".

Windows 7
Na área de trabalho, clique com o botão direito do mouse no ícone Computador.
Escolha Propriedades no menu de contexto.
Clique no link Configurações avançadas do sistema.
Clique em Variáveis de Ambiente. Na seção Variáveis de Sistema, localize a variável de ambiente PATH e selecione-a. Clique em Editar. Se a variável de ambiente PATH não existir, clique em Novo.
Na janela Editar Variável de Sistema (ou Nova Variável de Sistema), especifique o valor da variável de ambiente PATH. Clique em OK. Feche todas as janelas restantes clicando em OK.
Reabra a janela Prompt de comando e execute o comando "mongod".

Se der o erro no prompt que não existe o diretorio "c:\data\db", favor
criar estrutura de pasta no windows, abra o cmd, digite mkdir + espaço + \data\db
verifique se foi criado a pasta data no c:

Pronto!
