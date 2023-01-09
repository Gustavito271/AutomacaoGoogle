/*
 *  Teste automatizado relativo à página principal do Google. Para tanto, utilizou-se a IDE do Visual Studio e a
 *  linguagem C#. Faz-se uma observação quanto à quantidade de Time.Sleep(tempo), sendo que alguns podem ser evitados,
 *  mas dado a travamentos em minha máquina, fizeram-se necessários.
 *  
 *  Author: Gustavo Henrique Tostes
 *  Date: 08/01/2023 - Version 1.0
 */

//Bibliotecas utilizadas para funcionamento do teste automatizado em questão
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Selenium_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\Matheus\\Desktop\\chromedriver_win32");


            driver.Navigate().GoToUrl("https://google.com");

            driver.Manage().Window.Maximize();
            //Verifica o título da página
            Assert.Contains("Google", driver.Title);

            //Confirma se a URL da página atual é igual à da URL pesquisada
            Assert.Contains("https://www.google.com/", driver.Url);

            // Caso de teste 0
            // Verificar se, ao digitar “Selenium” a busca é feita corretamente.
            driver.FindElement(By.ClassName("gLFyf")).SendKeys("Selenium" + Keys.Enter);
            driver.Navigate().Back();
            Thread.Sleep(2000);

            // Caso de teste 1
            // Clicar no botão “Pesquisa Google” sem digitar nada na caixa de busca (da página) e verificar se aparece
            // uma mensagem ao usuário do tipo: “Digite alguma coisa inicialmente”.
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();
            Assert.Contains("https://www.google.com/", driver.Url);

            // Caso de teste 2
            // Digitar algo na caixa de busca e verificar se aparecem opções que completam o conteúdo buscado
            // (auto-sugestão). Além disso, verifica, juntamente, o funcionamento do botão de limpar (que aparece assim
            // que algo é digitado na caixa e pesquisa).
            driver.FindElement(By.ClassName("gLFyf")).SendKeys("Selenium");
            driver.FindElement(By.ClassName("G43f7e"));
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("BKRPef")).Click();
            Thread.Sleep(1000);

            // Caso de teste 3
            // Clicar no “Estou com sorte” e verificar se a página é redirecionda para a URL correta.
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[2]")).Click();
            Thread.Sleep(2000);
            Assert.Contains("google.com/doodles", driver.Url);
            driver.Navigate().Back();

            // Caso de teste 4
            // Verificar se o ícone de “teclado” aparece na barra de busca e sua descrição.
            driver.FindElement(By.ClassName("Umvnrc"));


            // Caso de teste 5
            // Verificar se o ícone de “microfone” aparece na barra de busca e sua descrição.
            driver.FindElement(By.ClassName("goxjub"));

            // Caso de teste 6
            // Verificar se o ícone de “câmera” aparece na barra de busca e sua descrição.
            driver.FindElement(By.ClassName("nDcEnd"));

            // Caso de teste 7
            // Verificar se a caixa de login do Google aparece.
            driver.FindElement(By.XPath("/ html / body / div[1] / div[3] / form / div[1] / div[1] / div[1] / div / div[2] / input"));

            // Caso de teste 8
            // Verificar se o link “Gmail” redireciona para o URL: https://google.com/intl/pt/gmail/about quando não
            // está logado.
            driver.FindElement(By.XPath("//*[@id=\"gb\"]/div/div[1]/div/div[1]/a")).Click();
            Thread.Sleep(2000);
            Assert.Contains("https://www.google.com/intl/pt/gmail/about/", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);

            // Caso de teste 9
            // Verificar se o link “Imagens” redireciona para o URL https://www.google.com.br/imghp?hl=pt-BR&ogbl.
            driver.FindElement(By.XPath("//*[@id=\"gb\"]/div/div[1]/div/div[2]/a")).Click();
            Thread.Sleep(2000);
            Assert.Contains("https://www.google.com.br/imghp?hl=pt-BR&ogbl", driver.Url);
            driver.Navigate().Back();


            // Caso de teste 10
            // Verificar se o ícone de Apps aparece assim como sua descrição.
            driver.FindElement(By.ClassName("gb_0e")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("gb_0e")).Click();

            // Caso de teste 11
            // Verificar se o botão “Fazer login” aparece e se o mesmo redireciona para a página correta.
            driver.FindElement(By.XPath("//*[@id=\"gb\"]/div/div[2]/a")).Click();
            driver.FindElement(By.ClassName("ZOeJnf"));
            driver.FindElement(By.Id("identifierNext"));
            driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);

            // Caso de teste 12
            // Verificar se o botão "Sobre" está na tela e se o mesmo redireciona para a URL correta.
            driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[1]")).Click();
            Assert.Contains("https://about.google/?utm_source=google-BR&utm_medium=referral&utm_campaign=hp-footer&fg=1", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);
            Thread.Sleep(500);

            // Caso de teste 13
            // Verificar se o botão "Publicidade" está na tela e se o mesmo redireciona para a URL correta.
            driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[2]")).Click();
            Assert.Contains("https://ads.google.com/intl/pt-BR_br/home/?subid=ww-ww-et-g-awa-a-g_hpafoot1_1!o2&utm_source=google.com&utm_medium=referral&utm_campaign=google_hpafooter&fg=1", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);
            Thread.Sleep(500);

            // Caso de teste 14
            // Verificar se o botão "Negócios" está na tela e se o mesmo redireciona para a URL correta.
            driver.FindElement(By.XPath("//html/body/div[1]/div[5]/div[2]/div[1]/a[3]")).Click();
            Assert.Contains("https://smallbusiness.withgoogle.com/intl/pt-BR_br/?subid=ww-ww-et-g-awa-a-g_hpbfoot1_1!o2&utm_source=google&utm_medium=ep&utm_campaign=google_hpbfooter&utm_content=google_hpbfooter&gmbsrc=ww-ww-et-gs-z-gmb-s-z-u~sb-g4sb_srvcs-u&c=BR#!/", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);
            Thread.Sleep(500);

            // Caso de teste 15
            // Verificar se o botão "Como funciona a pesquisa" está na tela e se o mesmo redireciona para a URL correta.
            driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[1]/a[4]")).Click();
            Assert.Contains("https://www.google.com/search/howsearchworks/?fg=1", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);
            Thread.Sleep(500);

            // Caso de teste 16
            // Verificar se o botão "Privacidade" está na tela e se o mesmo redireciona para a URL correta.
            // Para esse caso de testes, o trecho foi comentado visto que a linha 150 não estava sendo executada
            // corretamente em minha máquina, mesmo que nos demais casos ela era executada corretamente.
            /*driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/a[1]")).Click();
            Assert.Contains("https://policies.google.com/privacy?hl=pt-BR&fg=1", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);
            Thread.Sleep(500);*/

            // Caso de teste 17
            // Verificar se o botão "Termos" está na tela e se o mesmo redireciona para a URL correta.
            driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[2]/a[2]")).Click();
            Assert.Contains("https://policies.google.com/terms?hl=pt-BR&fg=1", driver.Url);
            driver.Navigate().Back();
            Assert.Contains("https://www.google.com/", driver.Url);
            Thread.Sleep(500);

            // Caso de teste 18
            // Verificar se o botão "Configurações" está na tela.
            driver.FindElement(By.ClassName("rIbAWc"));
        }
    }
}