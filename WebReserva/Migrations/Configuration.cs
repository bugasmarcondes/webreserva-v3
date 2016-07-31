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
                    Descricao = "<p>O Hotel Grande Lago foi totalmente modificado e está adequado aos padrões internacionais de Hotelaria e sua capacidade foi ampliada, contando agora com 20 unidades habitacionais.</p><p>Todas as nossas suítes possuem um banheiro moderno e uma charmosa salinha, também contam com TV, frigobar, ar-condicionado, telefone com tarifador automático e camas box.</p><p>Dispomos ainda de internet wireless gratuita em todas as áreas do hotel e restaurante.</p>",
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
                    Descricao = "<p>O Beach Hotel Maresias oferece uma localização única em Maresias. Considerado pé na areia, fica de frente para o mar e tem a maioria dos apartamentos com vista para a praia. Apenas uma área gramada separa os apartamentos da areia.</p><p>Em termos de lazer, o hotel conta com piscina e sauna, de frente para o mar, playground, salão de jogos, quadra de tênis e serviço de praia completo. Ficar hospedado no Beach Hotel Maresias é como estar em um resort, muitas mordomias, praia, sol, mas a pouco mais de duas horas de São Paulo.</p><p>Outro diferencial está nos apartamentos, amplos, com varanda de frente para o mar, tanto no andar térreo quanto no primeiro andar. O hotel oferece unidades também com vista para a Serra do Mar.</p>",
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
                    Descricao = "<p>Inaugurado em Fevereiro de 1986, o Sanjaya Hotel Nova Friburgo veio de encontro a uma demanda de hóspedes exigentes que, por inúmeros motivos, preferiam ficar mais próximos do centro da cidade, sem perder o aconchego dos hotéis lazer.</p><p>Localizado no centro de Nova Friburgo, o Sanjaya Hotel dispõe de salão de convenções, sala de jogos, sauna, piscina térmica, garagem com manobrista e lavanderia. Nossos 31 apartamentos luxo dispõem de TV a cores com sinal de parabólica e a cabo, frigobar e telefone.</p>",
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
                    Descricao = "<p>Somos hotel com dimensão e rotina de fazenda. Trezentos hectares de natureza com tudo o que se tem direito; incluindo a nascente “Areia que Canta”, aqui mesmo dentro do hotel. E apesar da natureza, da tranquilidade, da boa comida e de tanta coisa pra fazer, aqui, sua experiência começa mesmo é pelo corforto: apartamentos amplos, arejados e confortáveis e toda estrutra de gastronomia e lazer para você e para as crianças.</p><p>Antes éramos apenas fazenda. O hotel veio depois, prá poder oferecer tudo isso, na sua essência, para você.</p>",
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
                    Descricao = "<p>Aqui você desfrutará de um ambiente acolhedor, com serviços de qualidade e uma equipe preparada para indicar sempre a melhor opção para a sua hospedagem, com tarifas competitivas e condições especiais para grupos que venham fazer compras na rua 25 de março, Santa Ifigênia, Brás, Feira da madrugada, Bom Retiro e Galeria Pajé. Outro diferencial é a nossa equipe, que sempre atua de forma pró-ativa, focada em um atendimento cordial e hospitaleiro, pronta a prestar serviços que proporcionam uma estadia ainda mais aconchegante.</p>",
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
                    Descricao = "<p>Aqui você desfrutará de um ambiente acolhedor, com serviços de qualidade e uma equipe preparada para indicar sempre a melhor opção para a sua hospedagem, com tarifas competitivas e condições especiais para grupos que venham fazer compras na rua 25 de março, Santa Ifigênia, Brás, Feira da madrugada, Bom Retiro e Galeria Pajé. Outro diferencial é a nossa equipe, que sempre atua de forma pró-ativa, focada em um atendimento cordial e hospitaleiro, pronta a prestar serviços que proporcionam uma estadia ainda mais aconchegante.</p>",
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
                    Descricao = "<p>Inaugurado em 2006, o Vinhedo Plaza Hotel possui 68 Aptos (4 adaptados para pessoas com necessidades especiais) e 5 Bangalôs. Localizado estrategicamente a 71 km de São Paulo e a 22 km do aeroporto de Viracopos, o Vinhedo Plaza Hotel proporciona completa infraestrutura em eventos e hospedagem. O Hotel fica localizado a 5 minutos do centro da cidade de Vinhedo e o acesso à rodovia é fácil e rápido. Recentemente foi inaugurado o segundo empreendimento da rede: Valinhos Plaza Hotel (localizado na cidade de Valinhos, a 7 Km do Vinhedo Plaza Hotel).</p>",
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
                    Descricao = "<p>O Da Vinci Hotel em Manaus oferece a máxima experiência de estar em Manaus e é localizado no bairro elegante de Adrianópolis. O hotel é próximo do Shopping Manauara, Teatro Amazonas, fica a 15 minutos do aeroporto, conta com academia, TV a Cabo, WiFi e estacionamento gratuitos e um restaurante com saborosos pratos que combinam cozinha tradicional e internacional.</p>",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Titulo = "Páscoa",
                    Descricao = "Venha curtir a Páscoa 2016 com a gente!",
                    DescricaoSlider = "Celebração cristã!",
                    Mensagem = "Mensagem do pacote de Páscoa",
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
                    Nome = "Ala Ipê",
                    Descricao = "Lembram uma casa singela de fazenda, mas sem perder em conforto. São apartamentos duplex, ideal para famílias. Seu entorno é todo arborizado com árvores nativas e frutíferas. De frente para o lago e para um majestoso Ipê rosa.",
                    DestaqueTitulo = "Apartamentos duplex",
                    DestaqueDescricao = "(2 quartos ou quarto e sala)",
                    Img01 = "/Content/areiaquecanta/img/apartamento_ipe_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_ipe_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_ipe_g03.jpg",
                    OpcionalTitulo01 = "Cama casal padrão com colchão de alta densidade e enxoval puro algodão 200 fios",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "2 TVs LED com antena parabólica",
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
                    DestaqueTitulo = "Enxoval puro algodão 200 fios",
                    DestaqueDescricao = "Cama casal padrão com colchão de alta densidade",
                    Img01 = "/Content/areiaquecanta/img/apartamento_flamboyant_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_flamboyant_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_flamboyant_g03.jpg",
                    OpcionalTitulo01 = "Ar condicionado split (silencioso)",
                    OpcionalDescricao01 = "",
                    OpcionalTitulo02 = "TV LED com antena parabólica",
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
                    Descricao = "Em frente dos apartamentos um antigo pé de cedro da fazenda deu nome a esta ala de apartamentos mais amplos, arranjados em formato de meia lua com uma praça central.",
                    DestaqueTitulo = "Cama box queen size",
                    DestaqueDescricao = "Enxoval de puro algodão 200 fios",
                    Img01 = "/Content/areiaquecanta/img/apartamento_cedro_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_cedro_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_cedro_g03.jpg",
                    OpcionalTitulo01 = "Aquecimento solar/elétrico",
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
                    Nome = "Ala Cabreúva",
                    Descricao = "Apartamentos mais amplos e cuja vista alcança longe as plantações de laranja da fazenda e as cuestas de Brotas.",
                    DestaqueTitulo = "Cama box queen size",
                    DestaqueDescricao = "Enxoval de puro algodão 200 fios",
                    Img01 = "/Content/areiaquecanta/img/apartamento_cabreuva_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_cabreuva_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_cabreuva_g03.jpg",
                    OpcionalTitulo01 = "TV LED com antena parabólica",
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
                    Nome = "Ala Jatobá",
                    Descricao = "Apartamentos mais amplos e cuja vista alcança longe as plantações de laranja da fazenda e as cuestas de Brotas.",
                    DestaqueTitulo = "Cama Box Queen size",
                    DestaqueDescricao = "Enxoval puro algodão 200 fios",
                    Img01 = "/Content/areiaquecanta/img/apartamento_cabreuva_g01.jpg",
                    Img02 = "/Content/areiaquecanta/img/apartamento_cabreuva_g02.jpg",
                    Img03 = "/Content/areiaquecanta/img/apartamento_cabreuva_g03.jpg",
                    OpcionalTitulo01 = "Aquecimento solar/gás",
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
                    Descricao = "Quarto padrão com uma cama de casal.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "Perfeito para o casal.",
                    Img01 = "/Content/uniclasscentro/img/duplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasscentro/img/duplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasscentro/img/duplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Serviço de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televisão",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 5
                },
                new WrTipoApartamento
                {
                    Id = 7,
                    Nome = "Standard com 2 camas de solteiro",
                    Descricao = "Quarto padrão com duas camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasscentro/img/solteiro_standard_g01.jpg",
                    Img02 = "/Content/uniclasscentro/img/solteiro_standard_g02.jpg",
                    Img03 = "/Content/uniclasscentro/img/solteiro_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Serviço de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televisão",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 5
                },
                new WrTipoApartamento
                {
                    Id = 8,
                    Nome = "Standard triplo",
                    Descricao = "Quarto padrão com três camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasscentro/img/triplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasscentro/img/triplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasscentro/img/triplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Serviço de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televisão",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 5
                },
                new WrTipoApartamento
                {
                    Id = 9,
                    Nome = "Duplo Standard",
                    Descricao = "Quarto padrão com uma cama de casal.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "Perfeito para o casal.",
                    Img01 = "/Content/uniclasspinheiros/img/duplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasspinheiros/img/duplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasspinheiros/img/duplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Serviço de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televisão",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 6
                },
                new WrTipoApartamento
                {
                    Id = 10,
                    Nome = "Standard com 2 camas de solteiro",
                    Descricao = "Quarto padrão com duas camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasspinheiros/img/solteiro_standard_g01.jpg",
                    Img02 = "/Content/uniclasspinheiros/img/solteiro_standard_g02.jpg",
                    Img03 = "/Content/uniclasspinheiros/img/solteiro_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Serviço de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televisão",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 6
                },
                new WrTipoApartamento
                {
                    Id = 11,
                    Nome = "Standard triplo",
                    Descricao = "Quarto padrão com três camas de solteiro.",
                    DestaqueTitulo = "Equipado com Ar-Condicionado",
                    DestaqueDescricao = "",
                    Img01 = "/Content/uniclasspinheiros/img/triplo_standard_g01.jpg",
                    Img02 = "/Content/uniclasspinheiros/img/triplo_standard_g02.jpg",
                    Img03 = "/Content/uniclasspinheiros/img/triplo_standard_g03.jpg",
                    OpcionalTitulo01 = "Banheiro",
                    OpcionalDescricao01 = "Com chuveiro",
                    OpcionalTitulo02 = "Serviço de Despertador",
                    OpcionalDescricao02 = "",
                    OpcionalTitulo03 = "Frigobar, Telefone e Televisão",
                    OpcionalDescricao03 = "",
                    IdLetoh = 0,
                    WrHotelId = 6
                }
            );
        }
    }
}
