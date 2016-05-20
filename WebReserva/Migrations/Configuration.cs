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
                }
            );

            context.WrBloqueioDatas.AddOrUpdate(
                a => a.Id,
                new WrBloqueioData
                {
                    Id = 1,
                    Inicio = new DateTime(2016, 02, 06),
                    Fim = new DateTime(2016, 02, 10),
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
                    Inicio = new DateTime(2016, 03, 25),
                    Fim = new DateTime(2016, 03, 27),
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
                    Inicio = new DateTime(2016, 04, 21),
                    Fim = new DateTime(2016, 04, 24),
                    Pacote = true,
                    Titulo = "Tiradentes",
                    Descricao = "Venha curtir o Tiradentes 2016 com a gente!",
                    DescricaoSlider = "Joaquim José da Silva Xavier!",
                    Mensagem = "Mensagem do pacote de Tiradentes",
                    Img01 = "/Content/hotelgrandelago/img/tiradentes-2016.jpg",
                    Valor = 500,
                    WrHotelId = 1
                },
                new WrBloqueioData
                {
                    Id = 4,
                    Inicio = new DateTime(2016, 05, 26),
                    Fim = new DateTime(2016, 05, 29),
                    Pacote = true,
                    Titulo = "Corpus Christi",
                    Descricao = "Venha curtir o Corpus Christi 2016 com a gente!",
                    DescricaoSlider = "Domini!",
                    Mensagem = "Mensagem do pacote de Corpus Christi",
                    Img01 = "/Content/hotelgrandelago/img/corpus-christi-2016.jpg",
                    Valor = 600,
                    WrHotelId = 1
                },
                new WrBloqueioData
                {
                    Id = 5,
                    Inicio = new DateTime(2016, 11, 12),
                    Fim = new DateTime(2016, 11, 15),
                    Pacote = true,
                    Titulo = "Proclamação da República",
                    Descricao = "Venha curtir a Proclamação da República 2016 com a gente!",
                    DescricaoSlider = "Deodoro Fonseca!",
                    Mensagem = "Mensagem do pacote da República",
                    Img01 = "/Content/hotelgrandelago/img/republica-2016.jpg",
                    Valor = 700,
                    WrHotelId = 1
                },
                new WrBloqueioData
                {
                    Id = 6,
                    Inicio = new DateTime(2016, 02, 06),
                    Fim = new DateTime(2016, 02, 10),
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
                    Id = 7,
                    Inicio = new DateTime(2016, 03, 25),
                    Fim = new DateTime(2016, 03, 27),
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
                    Id = 8,
                    Inicio = new DateTime(2016, 04, 21),
                    Fim = new DateTime(2016, 04, 24),
                    Pacote = true,
                    Titulo = "Tiradentes",
                    Descricao = "Venha curtir o Tiradentes 2016 com a gente!",
                    DescricaoSlider = "Joaquim José da Silva Xavier!",
                    Mensagem = "Mensagem do pacote de Tiradentes",
                    Img01 = "/Content/maresiasbeachhotel/img/tiradentes-2016.jpg",
                    Valor = 500,
                    WrHotelId = 2
                },
                new WrBloqueioData
                {
                    Id = 9,
                    Inicio = new DateTime(2016, 05, 26),
                    Fim = new DateTime(2016, 05, 29),
                    Pacote = true,
                    Titulo = "Corpus Christi",
                    Descricao = "Venha curtir o Corpus Christi 2016 com a gente!",
                    DescricaoSlider = "Domini!",
                    Mensagem = "Mensagem do pacote de Corpus Christi",
                    Img01 = "/Content/maresiasbeachhotel/img/corpus-christi-2016.jpg",
                    Valor = 600,
                    WrHotelId = 2
                },
                new WrBloqueioData
                {
                    Id = 10,
                    Inicio = new DateTime(2016, 11, 12),
                    Fim = new DateTime(2016, 11, 15),
                    Pacote = true,
                    Titulo = "Proclamação da República",
                    Descricao = "Venha curtir a Proclamação da República 2016 com a gente!",
                    DescricaoSlider = "Deodoro Fonseca!",
                    Mensagem = "Mensagem do pacote da República",
                    Img01 = "/Content/maresiasbeachhotel/img/republica-2016.jpg",
                    Valor = 700,
                    WrHotelId = 2
                },
                new WrBloqueioData
                {
                    Id = 11,
                    Inicio = new DateTime(2016, 02, 06),
                    Fim = new DateTime(2016, 02, 10),
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
                    Id = 12,
                    Inicio = new DateTime(2016, 03, 25),
                    Fim = new DateTime(2016, 03, 27),
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
                    Id = 13,
                    Inicio = new DateTime(2016, 04, 21),
                    Fim = new DateTime(2016, 04, 24),
                    Pacote = true,
                    Titulo = "Tiradentes",
                    Descricao = "Venha curtir o Tiradentes 2016 com a gente!",
                    DescricaoSlider = "Joaquim José da Silva Xavier!",
                    Mensagem = "Mensagem do pacote de Tiradentes",
                    Img01 = "/Content/sanjaya/img/tiradentes-2016.jpg",
                    Valor = 500,
                    WrHotelId = 3
                },
                new WrBloqueioData
                {
                    Id = 14,
                    Inicio = new DateTime(2016, 05, 26),
                    Fim = new DateTime(2016, 05, 29),
                    Pacote = true,
                    Titulo = "Corpus Christi",
                    Descricao = "Venha curtir o Corpus Christi 2016 com a gente!",
                    DescricaoSlider = "Domini!",
                    Mensagem = "Mensagem do pacote de Corpus Christi",
                    Img01 = "/Content/sanjaya/img/corpus-christi-2016.jpg",
                    Valor = 600,
                    WrHotelId = 3
                },
                new WrBloqueioData
                {
                    Id = 15,
                    Inicio = new DateTime(2016, 11, 12),
                    Fim = new DateTime(2016, 11, 15),
                    Pacote = true,
                    Titulo = "Proclamação da República",
                    Descricao = "Venha curtir a Proclamação da República 2016 com a gente!",
                    DescricaoSlider = "Deodoro Fonseca!",
                    Mensagem = "Mensagem do pacote da República",
                    Img01 = "/Content/sanjaya/img/republica-2016.jpg",
                    Valor = 700,
                    WrHotelId = 3
                },
                new WrBloqueioData
                {
                    Id = 16,
                    Inicio = new DateTime(2016, 02, 06),
                    Fim = new DateTime(2016, 02, 10),
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
                    Id = 17,
                    Inicio = new DateTime(2016, 03, 25),
                    Fim = new DateTime(2016, 03, 27),
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
                    Id = 18,
                    Inicio = new DateTime(2016, 04, 21),
                    Fim = new DateTime(2016, 04, 24),
                    Pacote = true,
                    Titulo = "Tiradentes",
                    Descricao = "Venha curtir o Tiradentes 2016 com a gente!",
                    DescricaoSlider = "Joaquim José da Silva Xavier!",
                    Mensagem = "Mensagem do pacote de Tiradentes",
                    Img01 = "/Content/areiaquecanta/img/tiradentes-2016.jpg",
                    Valor = 500,
                    WrHotelId = 4
                },
                new WrBloqueioData
                {
                    Id = 19,
                    Inicio = new DateTime(2016, 05, 26),
                    Fim = new DateTime(2016, 05, 29),
                    Pacote = true,
                    Titulo = "Corpus Christi",
                    Descricao = "Venha curtir o Corpus Christi 2016 com a gente!",
                    DescricaoSlider = "Domini!",
                    Mensagem = "Mensagem do pacote de Corpus Christi",
                    Img01 = "/Content/areiaquecanta/img/corpus-christi-2016.jpg",
                    Valor = 600,
                    WrHotelId = 4
                },
                new WrBloqueioData
                {
                    Id = 20,
                    Inicio = new DateTime(2016, 11, 12),
                    Fim = new DateTime(2016, 11, 15),
                    Pacote = true,
                    Titulo = "Proclamação da República",
                    Descricao = "Venha curtir a Proclamação da República 2016 com a gente!",
                    DescricaoSlider = "Deodoro Fonseca!",
                    Mensagem = "Mensagem do pacote da República",
                    Img01 = "/Content/areiaquecanta/img/republica-2016.jpg",
                    Valor = 700,
                    WrHotelId = 4
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
                }
            );

            context.WrDisponibilidades.AddOrUpdate(
                a => a.Id,
                new WrDisponibilidade
                {
                    Id = 1,
                    Data = new DateTime(2016, 05, 01),
                    Quantidade = 1,
                    WrTipoApartamentoId = 1,
                    ValorDiaria = 20.00M,
                    DiariaAdulto01 = 100.00M,
                    DiariaAdulto02 = 90.00M,
                    DiariaAdulto03 = 80.00M,
                    DiariaAdulto04 = 70.00M,
                    DiariaAdulto05 = 60.00M,
                    DiariaAdulto06 = 50.00M,
                    DiariaAdulto07 = 40.00M,
                    DiariaAdulto08 = 30.00M,
                    DiariaAdulto09 = 20.00M,
                    DiariaAdulto10 = 10.00M,
                    DiariaCrianca00 = 180.00M,
                    DiariaCrianca01 = 170.00M,
                    DiariaCrianca02 = 160.00M,
                    DiariaCrianca03 = 150.00M,
                    DiariaCrianca04 = 140.00M,
                    DiariaCrianca05 = 130.00M,
                    DiariaCrianca06 = 120.00M,
                    DiariaCrianca07 = 110.00M,
                    DiariaCrianca08 = 100.00M,
                    DiariaCrianca09 = 90.00M,
                    DiariaCrianca10 = 80.00M,
                    DiariaCrianca11 = 70.00M,
                    DiariaCrianca12 = 60.00M,
                    DiariaCrianca13 = 50.00M,
                    DiariaCrianca14 = 40.00M,
                    DiariaCrianca15 = 30.00M,
                    DiariaCrianca16 = 20.00M,
                    DiariaCrianca17 = 10.00M
                });
        }
    }
}
