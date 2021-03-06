﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurriculumVitaeWebForm.aspx.cs" Inherits="CurriculumVitae.MVC.Pages.CurriculumVitaeWebForm" %>

<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!-->
<html lang="en">
<!--<![endif]-->
<head>
    <title>CV - Aisamaque Santos</title>
    <!-- Meta -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Aisamaque's CV based on Responsive HTML5 Resume/CV Template for Developers by Xiaoying Riley at 3rd Wave Media">
    <meta name="author" content="Aisamaque Santos">
    <link rel="shortcut icon" href="favicon.ico">
    <link href='https://fonts.googleapis.com/css?family=Roboto:400,500,400italic,300italic,300,500italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>
    <!-- Global CSS -->
    <link rel="stylesheet" href="assets/plugins/bootstrap/css/bootstrap.min.css">
    <!-- Plugins CSS -->
    <link rel="stylesheet" href="assets/plugins/font-awesome/css/font-awesome.css">

    <!-- Theme CSS -->
    <link id="theme-style" rel="stylesheet" href="assets/css/styles.css">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="sidebar-wrapper">
                <div class="profile-container">
                    <img class="profile img-rounded img-thumbnail" src="https://media.licdn.com/mpr/mpr/shrinknp_100_100/AAEAAQAAAAAAAAvoAAAAJDg5YmMxZjBkLTQxYWUtNDViYy04YTE2LWE1MjM4NTBlNzVhMQ.jpg" alt="" />
                    <h1 class="name" runat="server" id="headingName"></h1>
                    <h3 class="tagline" runat="server" id="headingTagLine"></h3>
                </div>
                <!--//profile-container-->

                <div class="contact-container container-block">
                    <ul class="list-unstyled contact-list">
                        <li class="email"><i class="fa fa-envelope"></i><a href="mailto: contato@aisamaque.com.br">contato@aisamaque.com.br</a></li>
                        <li class="linkedin"><i class="fa fa-linkedin"></i><a href="http://www.linkedin.com/in/aisamaque" target="_blank">linkedin.com/in/aisamaque</a></li>
                        <li class="skype"><i class="fa fa-skype"></i><a>aisamaque.santos</a></li>
                    </ul>
                </div>
                <!--//contact-container-->

                <div class="education-container container-block">
                    <h2 class="container-block-title">Formação</h2>
                    <div class="item">
                        <h4 class="degree">Tecg. Análise e Desenvolvimento de Sistemas</h4>
                        <h5 class="meta">Universidade Cruzeiro do Sul</h5>
                        <div class="time">2014 - 2015</div>
                    </div>
                    <!--//item-->
                    <div class="item">
                        <h4 class="degree">Bacharelado em Sistemas da Informação</h4>
                        <h5 class="meta">Escola Superior de Engenharia e Gestão - ESEG</h5>
                        <div class="time">2010 - 2012</div>
                    </div>
                    <!--//item-->
                </div>
                <!--//education-container-->

                <div class="languages-container container-block">
                    <h2 class="container-block-title">Idiomas</h2>
                    <ul class="list-unstyled interests-list">
                        <li>Português <span class="lang-desc">(Nativo)</span></li>
                        <li>Inglês <span class="lang-desc">(Intermediário)</span></li>
                    </ul>
                </div>
                <!--//interests-->

                <div class="interests-container container-block">
                    <h2 class="container-block-title">Interesses</h2>
                    <ul class="list-unstyled interests-list">
                        <li>Inovações Tecnológicas</li>
                        <li>Jogos &amp; Series</li>
                    </ul>
                </div>
                <!--//interests-->

            </div>
            <!--//sidebar-wrapper-->

            <div class="main-wrapper">

                <section class="section summary-section">
                    <h2 class="section-title"><i class="fa fa-user"></i>Resumo</h2>
                    <div class="summary">
                        <p>Experiência de seis anos com levantamento de requisitos, análise, desenvolvimento e suporte (técnico e de negócios) de soluções relacionadas a processos  automatizados. Soluções estas desenvolvidas com a ferramenta Ultimus BPM Suite e codificação na plataforma Microsoft .NET.</p>
                    </div>
                    <!--//summary-->
                </section>
                <!--//section-->

                <section class="section experiences-section">
                    <h2 class="section-title"><i class="fa fa-briefcase"></i>Experiência Profissional</h2>

                    <div class="item">
                        <div class="meta">
                            <div class="upper-row">
                                <h3 class="job-title">Analista Funcional</h3>
                                <div class="time">2012 - Atual</div>
                            </div>
                            <!--//upper-row-->
                            <div class="company">Grupo Trust</div>
                        </div>
                        <!--//meta-->
                        <div class="details">
                            <p>Levantamento de requisitos, mapeamento e automação de processos de negócios (BPMN) em diferentes empresas do setor público e privado.</p>
                            <p>Mapeamento de banco de dados relacionais (Microsoft SQL Server e Oracle), desenvolvimento de rotinas, VIEWS, FUNCTIONS e PROCEDURES.</p>
                            <p>
                                Desenvolvimento de formulários WEB utilizando HTML puro e plataforma ASP.NET(WebForms, MVC, Razor e Web Api).<p />
                            <p>Desenvolvimento de aplicações em camadas utilizando padrões de projeto e boas práticas (SOLID, DDD, TDD, BDD, MVC, Repository e etc) e conexões a banco de dados via ORM (Entity Framework) e ADO.NET.</p>
                            <p>Desenvolvimento de integrações via serviços (SOA) utilizando ASP.NET WebServices (XML e JSON) e WCF.</p>
                        </div>
                        <!--//details-->
                    </div>
                    <!--//item-->
                </section>
                <!--//section-->

                <section class="section projects-section">
                    <h2 class="section-title"><i class="fa fa-archive"></i>Projetos</h2>
                    <div class="item">
                        <span class="project-title">IBGE</span> - 
                   
                        <span class="project-tagline">Levantamento de requisitos, automatização, melhoria e suporte de dezenas de processos de negócios regionais e nacionais de diferentes áreas de negócios, todos estes processos foram desenvolvidos utilizando a ferramenta Ultimus BPM Suite. Desenvolvimento de Interfaces, integrações e relatórios na plataforma .NET.</span><div class="item">
                        </div>
                    </div>
                    <div class="item">
                        <span class="project-title">CAPES - PAEP</span> - 
                   
                        <span class="project-tagline">Desenvolvimento protótipos, análise do fluxo de negócios na ferramenta Ultimus BPM Suite e suporte a desenvolvdeores.</span>
                    </div>
                    <div class="item">
                        <span class="project-title">OUTBACK</span> - 
                   
                        <span class="project-tagline">Desenvolvimento de fluxos de negócios na ferramenta Ultimus BPM Suite.</span>
                    </div>
                    <div class="item">
                        <span class="project-title">SANOFI</span> - 
                   
                        <span class="project-tagline">Desenvolvimento de API's (plataforma .NET) para suporte a ferramenta Ultimus BPM Suite.</span>
                    </div>
                </section>

                <section class="skills-section section">
                    <h2 class="section-title"><i class="fa fa-rocket"></i>Conhecimentos &amp; Proficiência</h2>
                    <div class="skillset">
                        <div class="item">
                            <h3 class="level-title">C#</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="100%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">Javascript &amp; jQuery</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="98%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">ASP.NET WebForms</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="90%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">ASP.NET WebServices</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="90%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">Microsoft SQL Server</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="90%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">Entity Framework</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="90%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">ASP.NET MVC</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="80%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">.NET WCF</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="80%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">.NET CORE</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="70%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                        <div class="item">
                            <h3 class="level-title">HTML5 &amp; CSS</h3>
                            <div class="level-bar">
                                <div class="level-bar-inner" data-level="90%">
                                </div>
                            </div>
                            <!--//level-bar-->
                        </div>
                        <!--//item-->
                    </div>
                </section>
                <!--//skills-section-->

            </div>
            <!--//main-body-->
        </div>
    </form>


    <footer class="footer">
        <div class="text-center">
            <!--/* This template is released under the Creative Commons Attribution 3.0 License. Please keep the attribution link below when using for your own project. Thank you for your support. :) If you'd like to use the template without the attribution, you can check out other license options via our website: themes.3rdwavemedia.com */-->
            <small class="copyright">Designed with <i class="fa fa-heart"></i>by <a href="http://themes.3rdwavemedia.com" target="_blank">Xiaoying Riley</a> for developers</small>
        </div>
        <!--//container-->
    </footer>
    <!--//footer-->

    <!-- Javascript -->
    <script type="text/javascript" src="assets/plugins/jquery-1.11.3.min.js"></script>
    <script type="text/javascript" src="assets/plugins/bootstrap/js/bootstrap.min.js"></script>
    <!-- custom js -->
    <script type="text/javascript" src="assets/js/main.js"></script>
</body>
</html>
