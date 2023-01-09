# testeSelenium

--> PROCESSOS PARA SUBIR A APLICAÇÃO NO GITHUB
Para subir o projeto para o GitHub utilizou-se da própria ferramenta disponibilizada pelo Visual Studio, sendo que a mesma realiza a criação do repositório.

--> CRÍTICAS À PÁGINA DO GOOGLE
Quanto à página de buscas do Google, eu a considerei bastante usual, sendo que falhou em apenas um caso de testes que eu consegui pensar, sendo ele o caso de tentar fazer uma busca com o campo vazio e a página indicar ao usuário uma mensagem informando que ele deve digitar algo primeiro (dado que não é possível fazer a pesquisa dessa maneira). Nesse caso, a página não fornece tal indicação. No mais, considero a página intuitiva, objetiva (mas contendo recursos extras), boa usabilidade, acessível.

--> DETALHES DO PROJETO

Teste automatizado relativo à página principal do Google. Para tanto, utilizou-se a IDE do Visual Studio e a linguagem C#. Faz-se uma observação quanto à quantidade de Time.Sleep(tempo), sendo que alguns podem ser evitados, mas dado a travamentos em minha máquina, fizeram-se necessários.

Author: Gustavo Henrique Tostes
Date: 08/01/2023 - Version 1.0

Esses foram os casos de teste abordados na implementação do código de automatização da página de buscas do Google:
 - Caso de teste 0: Verificar se, ao digitar “Selenium” a busca é feita corretamente.
 - Caso de teste 1: Clicar no botão “Pesquisa Google” sem digitar nada na caixa de busca (da página) e verificar se aparece uma mensagem ao usuário do tipo: “Digite alguma coisa inicialmente”.
 - Caso de teste 2: Digitar algo na caixa de busca e verificar se aparecem opções que completam o conteúdo buscado (auto-sugestão). Além disso, verifica, juntamente, o funcionamento do botão de limpar (que aparece assim que algo é digitado na caixa e pesquisa).
 - Caso de teste 3: Clicar no “Estou com sorte” e verificar se a página é redirecionada para a URL correta.
 - Caso de teste 4: Verificar se o ícone de “teclado” aparece na barra de busca e sua descrição.
 - Caso de teste 5: Verificar se o ícone de “microfone” aparece na barra de busca e sua descrição.
 - Caso de teste 6: Verificar se o ícone de “câmera” aparece na barra de busca e sua descrição.
 - Caso de teste 7: Verificar se a caixa de login do Google aparece.
 - Caso de teste 8: Verificar se o link “Gmail” redireciona para o URL: https://google.com/intl/pt/gmail/about quando não está logado.
 - Caso de teste 9: Verificar se o link “Imagens” redireciona para o URL https://www.google.com.br/imghp?hl=pt-BR&ogbl .
 - Caso de teste 10: Verificar se o ícone de Apps aparece assim como sua descrição.
 - Caso de teste 11: Verificar se o botão “Fazer login” aparece e se o mesmo redireciona para a página correta.
 - Caso de teste 12: Verificar se o botão "Sobre" está na tela e se o mesmo redireciona para a URL correta.
 - Caso de teste 13: Verificar se o botão "Publicidade" está na tela e se o mesmo redireciona para a URL correta.
 - Caso de teste 14: Verificar se o botão "Negócios" está na tela e se o mesmo redireciona para a URL correta.
 - Caso de teste 15: Verificar se o botão "Como funciona a pesquisa" está na tela e se o mesmo redireciona para a URL correta.
 - Caso de teste 16: Verificar se o botão "Privacidade" está na tela e se o mesmo redireciona para a URL correta. Para esse caso de testes, o trecho foi comentado visto que a linha 150 não estava sendo executada corretamente em minha máquina, mesmo que nos demais casos ela era executada corretamente.
 - Caso de teste 17: Verificar se o botão "Termos" está na tela e se o mesmo redireciona para a URL correta.
 - Caso de teste 18: Verificar se o botão "Configurações" está na tela.
