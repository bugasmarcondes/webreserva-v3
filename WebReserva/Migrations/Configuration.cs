namespace WebReserva.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework.WebReservaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFramework.WebReservaContext context)
        {
            context.WrHotels.AddOrUpdate(
                a => a.HostUrl,
                new WrHotel
                {
                    Id = 1,
                    Descricao = "<p>O Hotel Grande Lago foi totalmente modificado e est� adequado aos padr�es internacionais de Hotelaria e sua capacidade foi ampliada, contando agora com 20 unidades habitacionais.</p><p>Todas as nossas su�tes possuem um banheiro moderno e uma charmosa salinha, tamb�m contam com TV, frigobar, ar-condicionado, telefone com tarifador autom�tico e camas box.</p><p>Dispomos ainda de internet wireless gratuita em todas as �reas do hotel e restaurante.</p>",
                    Nome = "Hotel Grande Lago",
                    HostUrl = "hotelgrandelago",
                    ImgLogo = "/Content/hotelgrandelago/img/logo.png",
                    ImgSobre01 = "/Content/hotelgrandelago/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/hotelgrandelago/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/hotelgrandelago/img/sobre-3.jpg",
                    MaxAdultos = 1,
                    MaxCriancas = 1,
                    Tema = "/Content/hotelgrandelago/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail de Hotel Grande Lago",
                    Facebook = "https://www.facebook.com/Grande-Lago-Bar-Gastronomia-Hotel-365146203529399/",
                    Twitter = "",
                    Instagram = "",
                    Telefone = "(38) 3754-5400",
                    LatitudeLongitude = "-18.216667, -45.255869"
                },
                new WrHotel
                {
                    Id = 2,
                    Descricao = "<p>O Beach Hotel Maresias oferece uma localiza��o �nica em Maresias. Considerado p� na areia, fica de frente para o mar e tem a maioria dos apartamentos com vista para a praia. Apenas uma �rea gramada separa os apartamentos da areia.</p><p>Em termos de lazer, o hotel conta com piscina e sauna, de frente para o mar, playground, sal�o de jogos, quadra de t�nis e servi�o de praia completo. Ficar hospedado no Beach Hotel Maresias � como estar em um resort, muitas mordomias, praia, sol, mas a pouco mais de duas horas de S�o Paulo.</p><p>Outro diferencial est� nos apartamentos, amplos, com varanda de frente para o mar, tanto no andar t�rreo quanto no primeiro andar. O hotel oferece unidades tamb�m com vista para a Serra do Mar.</p>",
                    Nome = "Beach Hotel Maresias",
                    HostUrl = "maresiasbeachhotel",
                    ImgLogo = "/Content/maresiasbeachhotel/img/logo.png",
                    ImgSobre01 = "/Content/maresiasbeachhotel/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/maresiasbeachhotel/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/maresiasbeachhotel/img/sobre-3.jpg",
                    MaxAdultos = 2,
                    MaxCriancas = 2,
                    Tema = "/Content/maresiasbeachhotel/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail de Beach Hotel Maresias",
                    Facebook = "https://www.facebook.com/REDEBEACH",
                    Twitter = "https://twitter.com/redebeachhotel",
                    Instagram = "",
                    Telefone = "(11) 3361-2077 / (12) 3891-7500",
                    LatitudeLongitude = "-23.790496, -45.564187"
                },
                new WrHotel
                {
                    Id = 3,
                    Descricao = "<p>Inaugurado em Fevereiro de 1986, o Sanjaya Hotel Nova Friburgo veio de encontro a uma demanda de h�spedes exigentes que, por in�meros motivos, preferiam ficar mais pr�ximos do centro da cidade, sem perder o aconchego dos hot�is lazer.</p><p>Localizado no centro de Nova Friburgo, o Sanjaya Hotel disp�e de sal�o de conven��es, sala de jogos, sauna, piscina t�rmica, garagem com manobrista e lavanderia. Nossos 31 apartamentos luxo disp�em de TV a cores com sinal de parab�lica e a cabo, frigobar e telefone.</p>",
                    Nome = "Sanjaya Hotel",
                    HostUrl = "sanjaya",
                    ImgLogo = "/Content/sanjaya/img/logo.png",
                    ImgSobre01 = "/Content/sanjaya/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/sanjaya/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/sanjaya/img/sobre-3.jpg",
                    MaxAdultos = 3,
                    MaxCriancas = 3,
                    Tema = "/Content/sanjaya/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail de Sanjaya Hotel",
                    Facebook = "https://www.facebook.com/SanjayaHotel",
                    Twitter = "",
                    Instagram = "",
                    Telefone = "(22) 2525-6052",
                    LatitudeLongitude = "-22.283865, -42.531467"
                },
                new WrHotel
                {
                    Id = 4,
                    Descricao = "<p>Somos hotel com dimens�o e rotina de fazenda. Trezentos hectares de natureza com tudo o que se tem direito; incluindo a nascente �Areia que Canta�, aqui mesmo dentro do hotel. E apesar da natureza, da tranquilidade, da boa comida e de tanta coisa pra fazer, aqui, sua experi�ncia come�a mesmo � pelo corforto: apartamentos amplos, arejados e confort�veis e toda estrutra de gastronomia e lazer para voc� e para as crian�as.</p><p>Antes �ramos apenas fazenda. O hotel veio depois, pr� poder oferecer tudo isso, na sua ess�ncia, para voc�.</p>",
                    Nome = "Areia que Canta",
                    HostUrl = "areiaquecanta",
                    ImgLogo = "/Content/areiaquecanta/img/logo.png",
                    ImgSobre01 = "/Content/areiaquecanta/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/areiaquecanta/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/areiaquecanta/img/sobre-3.jpg",
                    MaxAdultos = 4,
                    MaxCriancas = 4,
                    Tema = "/Content/areiaquecanta/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail Areia que Canta",
                    Facebook = "https://www.facebook.com/areiaquecantabrotas/",
                    Twitter = "https://twitter.com/areiaquecanta",
                    Instagram = "https://www.instagram.com/areiaquecanta/",
                    Telefone = "(14) 3653-1382 / (14) 3653-2465",
                    LatitudeLongitude = "-22.315391, -48.050240"
                },
                new WrHotel
                {
                    Id = 5,
                    Descricao = "<p>Aqui voc� desfrutar� de um ambiente acolhedor, com servi�os de qualidade e uma equipe preparada para indicar sempre a melhor op��o para a sua hospedagem, com tarifas competitivas e condi��es especiais para grupos que venham fazer compras na rua 25 de mar�o, Santa Ifig�nia, Br�s, Feira da madrugada, Bom Retiro e Galeria Paj�. Outro diferencial � a nossa equipe, que sempre atua de forma pr�-ativa, focada em um atendimento cordial e hospitaleiro, pronta a prestar servi�os que proporcionam uma estadia ainda mais aconchegante.</p>",
                    Nome = "Uniclass Centro",
                    HostUrl = "uniclasscentro",
                    ImgLogo = "/Content/uniclasscentro/img/logo.png",
                    ImgSobre01 = "/Content/uniclasscentro/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/uniclasscentro/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/uniclasscentro/img/sobre-3.jpg",
                    MaxAdultos = 4,
                    MaxCriancas = 4,
                    Tema = "/Content/uniclasscentro/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail Uniclass Centro",
                    Facebook = "https://www.facebook.com/uniclasshotelcentro/",
                    Twitter = "",
                    Instagram = "",
                    Telefone = "(11) 3629-3690",
                    LatitudeLongitude = "-23.54059, -46.6376888"
                },
                new WrHotel
                {
                    Id = 6,
                    Descricao = "<p>Aqui voc� desfrutar� de um ambiente acolhedor, com servi�os de qualidade e uma equipe preparada para indicar sempre a melhor op��o para a sua hospedagem, com tarifas competitivas e condi��es especiais para grupos que venham fazer compras na rua 25 de mar�o, Santa Ifig�nia, Br�s, Feira da madrugada, Bom Retiro e Galeria Paj�. Outro diferencial � a nossa equipe, que sempre atua de forma pr�-ativa, focada em um atendimento cordial e hospitaleiro, pronta a prestar servi�os que proporcionam uma estadia ainda mais aconchegante.</p>",
                    Nome = "Uniclass Pinheiros",
                    HostUrl = "uniclasspinheiros",
                    ImgLogo = "/Content/uniclasspinheiros/img/logo.png",
                    ImgSobre01 = "/Content/uniclasspinheiros/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/uniclasspinheiros/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/uniclasspinheiros/img/sobre-3.jpg",
                    MaxAdultos = 4,
                    MaxCriancas = 4,
                    Tema = "/Content/uniclasspinheiros/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail Uniclass Pinheiros",
                    Facebook = "https://www.facebook.com/uniclasshotelcentro/",
                    Twitter = "",
                    Instagram = "",
                    Telefone = "(11) 3813-7744",
                    LatitudeLongitude = "-23.5648563, -46.690689"
                },
                new WrHotel
                {
                    Id = 7,
                    Descricao = "<p>Inaugurado em 2006, o Vinhedo Plaza Hotel possui 68 Aptos (4 adaptados para pessoas com necessidades especiais) e 5 Bangal�s. Localizado estrategicamente a 71 km de S�o Paulo e a 22 km do aeroporto de Viracopos, o Vinhedo Plaza Hotel proporciona completa infraestrutura em eventos e hospedagem. O Hotel fica localizado a 5 minutos do centro da cidade de Vinhedo e o acesso � rodovia � f�cil e r�pido. Recentemente foi inaugurado o segundo empreendimento da rede: Valinhos Plaza Hotel (localizado na cidade de Valinhos, a 7 Km do Vinhedo Plaza Hotel).</p>",
                    Nome = "Vinhedo Plaza Hotel",
                    HostUrl = "vinhedoplazahotel",
                    ImgLogo = "/Content/vinhedoplazahotel/img/logo.png",
                    ImgSobre01 = "/Content/vinhedoplazahotel/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/vinhedoplazahotel/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/vinhedoplazahotel/img/sobre-3.jpg",
                    MaxAdultos = 4,
                    MaxCriancas = 4,
                    Tema = "/Content/vinhedoplazahotel/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail Vinhedo Plaza Hotel",
                    Facebook = "https://www.facebook.com/Vinhedo-Plaza-Hotel-197623213598519/",
                    Twitter = "",
                    Instagram = "",
                    Telefone = "(19) 3886-6020 / (19) 3876-3867 / (19) 3826-2354",
                    LatitudeLongitude = "-23.038764, -46.975073"
                },
                new WrHotel
                {
                    Id = 8,
                    Descricao = "<p>O Da Vinci Hotel em Manaus oferece a m�xima experi�ncia de estar em Manaus e � localizado no bairro elegante de Adrian�polis. O hotel � pr�ximo do Shopping Manauara, Teatro Amazonas, fica a 15 minutos do aeroporto, conta com academia, TV a Cabo, WiFi e estacionamento gratuitos e um restaurante com saborosos pratos que combinam cozinha tradicional e internacional.</p>",
                    Nome = "Da Vinci Hotel & Conventions",
                    HostUrl = "davincihotel",
                    ImgLogo = "/Content/davincihotel/img/logo.png",
                    ImgSobre01 = "/Content/davincihotel/img/sobre-1.jpg",
                    ImgSobre02 = "/Content/davincihotel/img/sobre-2.jpg",
                    ImgSobre03 = "/Content/davincihotel/img/sobre-3.jpg",
                    MaxAdultos = 4,
                    MaxCriancas = 4,
                    Tema = "/Content/davincihotel/css/tema.css",
                    EmailAdministrador = "bugasmarcondes@gmail.com",
                    MsgCustomizadaEmail = "MsgCustomizadaEmail Da Vinci Hotel",
                    Facebook = "",
                    Twitter = "https://twitter.com/davincihotelam",
                    Instagram = "",
                    Telefone = "(92) 3663-1213",
                    LatitudeLongitude = "-3.106404, -60.011149"
                }
            );

            context.WrBloqueioDatas.AddOrUpdate(
                a => a.Id,
                new WrBloqueioData
                {
                    Id = 1,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/hotelgrandelago/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 1
                },
                new WrBloqueioData
                {
                    Id = 2,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/hotelgrandelago/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 1
                },
                new WrBloqueioData
                {
                    Id = 3,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/maresiasbeachhotel/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 2
                },
                new WrBloqueioData
                {
                    Id = 4,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/maresiasbeachhotel/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 2
                },
                new WrBloqueioData
                {
                    Id = 5,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/sanjaya/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 3
                },
                new WrBloqueioData
                {
                    Id = 6,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/sanjaya/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 3
                },
                new WrBloqueioData
                {
                    Id = 7,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/areiaquecanta/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 4
                },
                new WrBloqueioData
                {
                    Id = 8,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/areiaquecanta/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 4
                },
                new WrBloqueioData
                {
                    Id = 9,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/areiaquecanta/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 5
                },
                new WrBloqueioData
                {
                    Id = 10,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/areiaquecanta/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 5
                },
                new WrBloqueioData
                {
                    Id = 11,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/areiaquecanta/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 6
                },
                new WrBloqueioData
                {
                    Id = 12,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/areiaquecanta/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 6
                },
                new WrBloqueioData
                {
                    Id = 13,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/areiaquecanta/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 7
                },
                new WrBloqueioData
                {
                    Id = 14,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/areiaquecanta/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 7
                },
                new WrBloqueioData
                {
                    Id = 15,
                    Inicio = new DateTime(2016, 10, 06),
                    Fim = new DateTime(2016, 10, 10),
                    Pacote = true,
                    Titulo = "Carnaval",
                    Descricao = "Venha curtir o Carnaval 2016 com a gente!",
                    DescricaoSlider = "Caia na folia!",
                    Mensagem = "Mensagem do pacote de Carnaval",
                    Img01 = "/Content/areiaquecanta/img/carnaval-2016.jpg",
                    Valor = 300,
                    WrHotelId = 8
                },
                new WrBloqueioData
                {
                    Id = 16,
                    Inicio = new DateTime(2016, 11, 25),
                    Fim = new DateTime(2016, 11, 27),
                    Pacote = true,
                    Titulo = "P�scoa",
                    Descricao = "Venha curtir a P�scoa 2016 com a gente!",
                    DescricaoSlider = "Celebra��o crist�!",
                    Mensagem = "Mensagem do pacote de P�scoa",
                    Img01 = "/Content/areiaquecanta/img/pascoa-2016.jpg",
                    Valor = 400,
                    WrHotelId = 8
                }
            );

            context.WrTipoApartamentos.AddOrUpdate(
                a => a.Id,
                new WrTipoApartamento
                {
                    Id = 1,
                    Nome = "Ala Ip�",
                    Descricao = "Lembram uma casa singela de fazenda, mas sem perder em conforto. S�o apartamentos duplex, ideal para fam�lias. Seu entorno � todo arborizado com �rvores nativas e frut�feras. De frente para o lago e para um majestoso Ip� rosa.",
                    DestaqueTitulo = "Apartamentos duplex",
                    DestaqueDescricao = "(2 quartos ou quarto e sala)",
                    Img01 = "/Content/areiaquecanta/img/apartamento_ipe_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_ipe_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_ipe_g03.jpg",
                    OpcionalTitulo01 = "Cama casal padr�o com colch�o de alta densidade e enxoval puro algod�o 200 fios",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "2 TVs LED com antena parab�lica",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Ar condicionado split",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 4
                },
                new WrTipoApartamento
                {
                    Id = 2,
                    Nome = "Ala Flamboyant",
                    Descricao = "Os muitos Flamboyants vermelhos espalhados pela fazenda deram nome a esta Ala. Da varanda ou da janela, vista privilegiada do lago e do por do sol.",
                    DestaqueTitulo = "Enxoval puro algod�o 200 fios",
                    DestaqueDescricao = "Cama casal padr�o com colch�o de alta densidade",
                    Img01 = "/Content/areiaquecanta/img/apartamento_flamboyant_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_flamboyant_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_flamboyant_g03.jpg",
                    OpcionalTitulo01 = "Ar condicionado split (silencioso)",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "TV LED com antena parab�lica",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 4
                },
                new WrTipoApartamento
                {
                    Id = 3,
                    Nome = "Ala Cedro",
                    Descricao = "Em frente dos apartamentos um antigo p� de cedro da fazenda deu nome a esta ala de apartamentos mais amplos, arranjados em formato de meia lua com uma pra�a central.",
                    DestaqueTitulo = "Cama box queen size",
                    DestaqueDescricao = "Enxoval de puro algod�o 200 fios",
                    Img01 = "/Content/areiaquecanta/img/apartamento_cedro_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_cedro_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_cedro_g03.jpg",
                    OpcionalTitulo01 = "Aquecimento solar/el�trico",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "Ar condicionado split (silencioso)",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, ar condicionado",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 4
                },
                new WrTipoApartamento
                {
                    Id = 4,
                    Nome = "Ala Cabre�va",
                    Descricao = "Apartamentos mais amplos e cuja vista alcan�a longe as planta��es de laranja da fazenda e as cuestas de Brotas.",
                    DestaqueTitulo = "Cama box queen size",
                    DestaqueDescricao = "Enxoval de puro algod�o 200 fios",
                    Img01 = "/Content/areiaquecanta/img/apartamento_cabreuva_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_cabreuva_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_cabreuva_g03.jpg",
                    OpcionalTitulo01 = "TV LED com antena parab�lica",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "Telefone, Cofre digital,Internet Wifi",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Varanda com rede",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 4
                },
                new WrTipoApartamento
                {
                    Id = 5,
                    Nome = "Ala Jatob�",
                    Descricao = "Apartamentos mais amplos e cuja vista alcan�a longe as planta��es de laranja da fazenda e as cuestas de Brotas.",
                    DestaqueTitulo = "Cama Box Queen size",
                    DestaqueDescricao = "Enxoval puro algod�o 200 fios",
                    Img01 = "/Content/areiaquecanta/img/apartamento_cabreuva_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_cabreuva_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_cabreuva_g03.jpg",
                    OpcionalTitulo01 = "Aquecimento solar/g�s",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "2 apartamentos com banheira de hidromassagem",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "6 apartamentos com varanda",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 4
                },
                new WrTipoApartamento
                {
                    Id = 6,
                    Nome = "Duplo Standard",
                    Descricao = "Quarto padr�o com uma cama de casal.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "Perfeito para o casal.",
                    Img01 = "/Content/uniclasscentro/img/duplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasscentro/img/duplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasscentro/img/duplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Servi�o de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televis�o",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 5
                },
                new WrTipoApartamento
                {
                    Id = 7,
                    Nome = "Standard com 2 camas de solteiro",
                    Descricao = "Quarto padr�o com duas camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasscentro/img/solteiro_standard_g01.jpg",
                    Img02 = "/Content/uniclasscentro/img/solteiro_standard_g02.jpg",
                    Img03 = "/Content/uniclasscentro/img/solteiro_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Servi�o de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televis�o",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 5
                },
                new WrTipoApartamento
                {
                    Id = 8,
                    Nome = "Standard triplo",
                    Descricao = "Quarto padr�o com tr�s camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasscentro/img/triplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasscentro/img/triplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasscentro/img/triplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Servi�o de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televis�o",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 5
                },
                new WrTipoApartamento
                {
                    Id = 9,
                    Nome = "Duplo Standard",
                    Descricao = "Quarto padr�o com uma cama de casal.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "Perfeito para o casal.",
                    Img01 = "/Content/uniclasspinheiros/img/duplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasspinheiros/img/duplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasspinheiros/img/duplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Servi�o de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televis�o",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 6
                },
                new WrTipoApartamento
                {
                    Id = 10,
                    Nome = "Standard com 2 camas de solteiro",
                    Descricao = "Quarto padr�o com duas camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasspinheiros/img/solteiro_standard_g01.jpg",
                    Img02 = "/Content/uniclasspinheiros/img/solteiro_standard_g02.jpg",
                    Img03 = "/Content/uniclasspinheiros/img/solteiro_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Servi�o de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televis�o",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 6
                },
                new WrTipoApartamento
                {
                    Id = 11,
                    Nome = "Standard triplo",
                    Descricao = "Quarto padr�o com tr�s camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasspinheiros/img/triplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasspinheiros/img/triplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasspinheiros/img/triplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Servi�o de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televis�o",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 6
                }
            );
        }
    }
}
