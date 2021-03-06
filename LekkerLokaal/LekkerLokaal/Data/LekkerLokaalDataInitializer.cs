﻿using Microsoft.AspNetCore.Identity;
using LekkerLokaal.Models.Domain;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using LekkerLokaal.Models;

namespace LekkerLokaal.Data
{
    public class LekkerLokaalDataInitializer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public LekkerLokaalDataInitializer(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task InitializeData()
        {
            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                Categorie eten_drinken = new Categorie("Eten & drinken", "fa-utensils");
                Categorie fitness = new Categorie("Fitness", "fa-heartbeat");
                Categorie uitstappen = new Categorie("Uitstappen", "fa-plane");
                Categorie huis_tuin = new Categorie("Huis & Tuin", "fa-home");
                Categorie events = new Categorie("Events", "fa-calendar");
                Categorie beauty = new Categorie("Beauty", "fa-female");
                Categorie interieur = new Categorie("Interieur", "fa-image");
                Categorie kledij = new Categorie("Kledij", "fa-umbrella");
                Categorie multimedia = new Categorie("Multimedia", "fa-laptop");
                Categorie generiek = new Categorie("Generiek", "fa-gift");

                var categories = new List<Categorie>
                {
                    eten_drinken, events, beauty, fitness, interieur, kledij, multimedia, uitstappen, huis_tuin, generiek
                };
                _dbContext.Categorieen.AddRange(categories);


                Handelaar Handelaar01 = new Handelaar("Restaurant Lekker", "lekker@gmail.com", "Met deze bon kan u lekker komen eten in ons restaurant genaamd Restaurant Lekker.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar02 = new Handelaar("Bontinck", "bontinck@gmail.com", "Met deze bon kan u onze met passie gemaakte dessertjes komen proeven.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar03 = new Handelaar("Schets", "schets@gmail.com", "Alle lokale bieren zijn hier te vinden! Er kan ook plaatselijk geproefd worden.", "BE0123456789", "Ravensteinstraat", "50", "1000", "Brussel", true);
                Handelaar Handelaar04 = new Handelaar("De Coninck's", "coninck@gmail.com", "De lekkerste cocktails zijn hier te vinden. Alleen hier te vinden tegen een goed prijs!", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar05 = new Handelaar("Wijnproeverij BraLenBre", "Handelaar01@gmail.com", "Met deze bon kan je bij wijnproeverij BraLenBre genieten van een gezellige avond. Je zal er meer uitleg krijgen over de verschillende soorten wijnen en van elke soort mogen proeven, allen vergezeld met een passend hapje. Eens de sessie over is kan met de bon, wijn gekocht worden. Enkele merken die je hier kan verwachten zijn: Francis Ford Coppola, Franschhoek Cellar, Fushs Reinhardt, Gran Sasso, Grande Provence, Guadalupe, Guillamen I Muri, ..."
                    , "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar06 = new Handelaar("'t Sandwichke", "sandwich@gmail.com", "Voor al uw vegatarische noden kan u bij ons terecht.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar07 = new Handelaar("McDonalds", "mc@gmail.com", "Voor een snelle hap moet u bij ons zijn!", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar08 = new Handelaar("SOS Piet", "sospiet@gmail.com", "Het echte restaurant van SOS Piet. Altijd de beste maatlijd voor een gezonde prijs!", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar09 = new Handelaar("CoBoSh", "cobosh@gmail.com", "Voor de beste wijnen moet je bij ons zijn! Hierbij kan altijd een hapje geserveerd worden.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);

                Handelaar Handelaar11 = new Handelaar("Sanitas", "sanitas@gmail.com", "Bekenste fitness van Wichelen.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar12 = new Handelaar("Fitness Basic-Fit", "basicfit@gmail.com", "Bekenste fitness van België met vestigingen over het hele land.", "BE0123456789", "Ravensteinstraat", "50", "1000", "Brussel", true);

                Handelaar Handelaar21 = new Handelaar("Aalst", "aalst@gmail.com", "De recreatiedienst van Aalst staat in voor tal van speciale activiteiten.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar22 = new Handelaar("Walibi", "walibi@gmail.com", "Een pretpark voor klein en groot.", "BE0123456789", "Mechelsesteenweg ", "138", "9200", "Dendermonde", true);
                Handelaar Handelaar23 = new Handelaar("NMBS", "trein@gmail.com", "De spoorwegdienst van België. Staakt liever dan te werken.", "BE0123456789", "Torhoutsesteenweg", "611", "8400", "Oostende", true);
                Handelaar Handelaar24 = new Handelaar("Disneyland Paris", "parijs@gmail.com", "Een van de grootste pretparken in Frankrijk.", "BE0123456789", "Leopoldlaan", "1", "1930", "Zaventem", true);
                Handelaar Handelaar25 = new Handelaar("Hamme", "hamme@gmail.com", "Stad Hamme", "BE0123456789", "Rue Joseph Lamotte", "2", "5580", "Han-sur-Lesse", true);
                Handelaar Handelaar26 = new Handelaar("Breemdonk", "breemdonk@gmail.com", "Gemeente Breemdonk", "BE0123456789", "Brandstraat", "57", "2830", "Willebroek", true);

                Handelaar Handelaar31 = new Handelaar("Brenk", "brenk@gmail.com", "Stel zelf uw setje bloemen samen met deze bon.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar32 = new Handelaar("De Mol", "molleken@gmail.com", "Heb je grond nodig voor in een pot", "BE0123456789", "Kasteeldreef", "15", "9340", "Lede", true);
                Handelaar Handelaar33 = new Handelaar("Schelfhout", "schelfhout@gmail.com", "Schelfhout, waar moet je andes zijn!", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar34 = new Handelaar("Liesje", "lies@gmail.com", "Lies, verkoopt ook wel een madelief", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar35 = new Handelaar("Funa Lima", "funa_lima@gmail.com", "Vissen, fonteinen, dieraccesoire...", "BE0123456789", "Kasteeldreef", "15", "9340", "Lede", true);
                Handelaar Handelaar36 = new Handelaar("Blub", "blub@gmail.com", "Blub, de winkel voor vis enthousiasten", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar37 = new Handelaar("G-Bont", "grasb@gmail.com", "Jaren ervaring in het snoeien van alle gazons", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar38 = new Handelaar("Aveve", "aveve@gmail.com", "Bij de boerenbond vind je altijd wat je zoekt", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar39 = new Handelaar("Groener Gras", "groengras@gmail.com", "Gazon voorzieningen voor iedereen die een groen gazon wil!", "BE0123456789", "Cooppallaan ", "40", "9230", "Wetteren", true);

                Handelaar Handelaar41 = new Handelaar("Pukkelpop", "ppk@gmail.com", "Tickets of coupons voor pukkelpok.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar42 = new Handelaar("Bierfeesten", "bierfeesten@gmail.com", "De veste feesten in Lokeren: De Lokerse Bierfeesten!", "BE0123456789", "Kleine Dam", "1", "9160", "Lokeren", true);
                Handelaar Handelaar43 = new Handelaar("Gentse Feesten", "feesten-gent@gmail.com", "Het grootste feest in Gent!", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar44 = new Handelaar("Gameforce", "games@gmail.com", "Grootste game beurs in België. Nu ook kortingsbonnen verkrijgbaar!", "BE0123456789", "Ravensteinstraat", "50", "1000", "Brussel", true);
                Handelaar Handelaar45 = new Handelaar("Garage Ferrari", "ferfer@gmail.com", "Beste cadeau voor een Ferrari liefhebber!", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar46 = new Handelaar("Facts", "facts@gmail.com", "Een van de grootste cosplay beurzen van België.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);

                Handelaar Handelaar51 = new Handelaar("Nude", "nude@gmail.com", "Het bekendste merk voor beauty producten!", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar52 = new Handelaar("Restaurant Lekker", "lekker@gmail.com", "korte beschrijving", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar53 = new Handelaar("Ici Paris", "ici-paris@gmail.com", "Voor een parfum moet je bij ons zijn!", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);

                Handelaar Handelaar61 = new Handelaar("Sofa & Co", "sofaco@gmail.com", "Vind de gepaste sofa bij ons!", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar62 = new Handelaar("Deba", "deba@gmail.com", "Voor elk interieur stuk kan u bij ons terecht!", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar63 = new Handelaar("Ikea", "ikea@gmail.com", "Hebt u iets nodig tegen een lage prijs dan kan u altijd bij ons terecht.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar64 = new Handelaar("Leen Bakker", "leen-bakker@gmail.com", "Iets kopen dan bent u op de juiste plaats.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar65 = new Handelaar("Salon Ballon", "salon-ballon@gmail.com", "De speciaal zaak die u zocht.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar66 = new Handelaar("Donald", "donald-keukens@gmail.com", "Keuken nodig kom dan bij ons!", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar67 = new Handelaar("Modern Gent", "gent-modern@gmail.com", "Modern interieur tegen een prijsje.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar68 = new Handelaar("Kunst & Kitch", "kunst-kitch@gmail.com", "Kunst hoeft niet altijd lelijk te zijn.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar69 = new Handelaar("Gill", "gill@gmail.com", "Interieur tegen een prijsje.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);

                Handelaar Handelaar71 = new Handelaar("C&A", "cena@gmail.com", "De Kleding winkel van Aalst.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar72 = new Handelaar("AS Adventure", "as-adventure@gmail.com", "Outdoor kleding en alles voor je outdoor ervaring.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar73 = new Handelaar("Ultra Wet", "ultra-wet@gmail.com", "De kldeingspecialist voor droog en nat.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar74 = new Handelaar("Holiday", "holiday@gmail.com", "Voor al uw feestkledij.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar75 = new Handelaar("Bram's Fashion", "bram@gmail.com", "Voor ieder wat wilds.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar76 = new Handelaar("Bontinck Panther's", "panther@gmail.com", "Pants from Bontinck are dreams for legs.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar77 = new Handelaar("Bre Bra", "bre-bra@gmail.com", "Van A tot Z  u vindt het bij ons.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar78 = new Handelaar("Pikantje", "pikant@gmail.com", "Eroiek u vindt het bij ons.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);

                Handelaar Handelaar81 = new Handelaar("Fnac", "fnac@gmail.com", "De multimedia specialist in Europa.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar82 = new Handelaar("Mediamarkt", "mediamarkt@gmail.com", "Electronica tegen een spot prijs.", "BE0123456789", "Mechelsesteenweg", "138", "9200", "Dendermonde", true);
                Handelaar Handelaar83 = new Handelaar("Van Den Borre", "vandenborre@gmail.com", "Koffiezets voor 12€.", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar84 = new Handelaar("Bontinck IT", "bontinck-it@gmail.com", "Een probleempje groot of klein, dan moet je bij IT Lennert zijn.", "BE0123456789", "Maalse Steenweg", "50", "8310", "Brugge", true);
                Handelaar Handelaar85 = new Handelaar("Schets Apple Premium", "schets-apple@gmail.com", "Alle laatste Apple producten moet u bij ons zijn.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar86 = new Handelaar("Lab9", "lab-9@gmail.com", "Officiele Apple reseller.", "BE0123456789", "Arbeidstraat", "14", "9300", "Aalst", true);
                Handelaar Handelaar87 = new Handelaar("De Conincks Screen Repair", "screenrepair@gmail.com", "Een ongelukje is snel gebeurd.", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);
                Handelaar Handelaar88 = new Handelaar("Medion Custom", "medion@gmail.com", "Medion laptop op maat gemaakt", "BE0123456789", "Sint-Pietersnieuwstraat", "124", "9000", "Gent", true);
                Handelaar Handelaar89 = new Handelaar("Dell Dinosaur", "dell@gmail.com", "MS Dos specialist", "BE0123456789", "Paepestraat", "178", "9260", "Wichelen", true);


                Handelaar Handelaar91 = new Handelaar("Generiek", "generiek@gmail.com", "generiek", "BE0123456789", "Ravensteinstraat", "50", "1000", "Brussel", true);

                Handelaar Handelaar10 = new Handelaar("ChaCha", "chacha@gmail.com", "Voor de beste wijnen moet je bij ons zijn! Hierbij kan altijd een hapje geserveerd worden.", "BE0123456789", "Ravensteinstraat", "50", "1000", "Brussel", true);
                var handelaars = new List<Handelaar>
                {
                    Handelaar01, Handelaar02, Handelaar03, Handelaar04, Handelaar05, Handelaar06, Handelaar07, Handelaar08, Handelaar09, Handelaar10, Handelaar11, Handelaar21, Handelaar22, Handelaar23, Handelaar24, Handelaar25, Handelaar26, Handelaar31, Handelaar32, Handelaar33, Handelaar34, Handelaar35, Handelaar36, Handelaar37, Handelaar38, Handelaar39, Handelaar41, Handelaar42, Handelaar43, Handelaar44, Handelaar45, Handelaar46, Handelaar51, Handelaar52, Handelaar53, Handelaar61, Handelaar62, Handelaar63, Handelaar64, Handelaar65, Handelaar66, Handelaar67, Handelaar68, Handelaar69, Handelaar71, Handelaar72, Handelaar73, Handelaar74, Handelaar75, Handelaar76, Handelaar77, Handelaar78, Handelaar81, Handelaar82, Handelaar83, Handelaar84, Handelaar85, Handelaar86, Handelaar87, Handelaar88, Handelaar89, Handelaar91
                };

                _dbContext.Handelaars.AddRange(handelaars);

                Bon bon01 = new Bon("Restaurant lekker", 25, 50, "3 sterren resaurant in het centrum van Aalst.", 17, @"images\bon\1\", eten_drinken, "Arbeidstraat", "14", "9300", "Aalst", Handelaar01, Aanbieding.Geen, true);
                Bon bon02 = new Bon("Dessertbar chez Bontinck", 5, 30, "Met passie gemaakte dessertjes in het mooie Schellebelle.", 242, @"images\bon\2\", eten_drinken, "Paepestraat", "178", "9260", "Wichelen", Handelaar02, Aanbieding.Slider, true);
                Bon bon03 = new Bon("Bierspecialist Schets", 10, 20, "Meer dan 70 Belgische bieren in een gezellige kroeg.", 42, @"images\bon\3\", eten_drinken, "Ravensteinstraat", "50", "1000", "Brussel", Handelaar03, Aanbieding.Geen, true);
                Bon bon04 = new Bon("De Coninck's cocktail", 5, 15, "Een VIP cocktailbar met live optredens van lokale muzikanten.", 24, @"images\bon\4\", eten_drinken, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar04, Aanbieding.Geen, true);
                Bon bon05 = new Bon("Wijnproeverij BraLenBre", 45, 75, "Keuze uit verschillende wijnen vergezeld met een hapje.", 124, @"images\bon\5\", eten_drinken, "Arbeidstraat", "14", "9300", "Aalst", Handelaar05, Aanbieding.Slider, true);
                Bon bon06 = new Bon("Veggiebar 't Sandwichke", 15, 30, "Het bewijs dat vegetarisch eten lekker kan zijn.", 45, @"images\bon\6\", eten_drinken, "Arbeidstraat", "14", "9300", "Aalst", Handelaar06, Aanbieding.Geen, true);
                Bon bon07 = new Bon("Fastfood McDonalds", 1, 5, "De keten met keuzes voor iedereen.", 98, @"images\bon\7\", eten_drinken, "Arbeidstraat", "14", "9300", "Aalst", Handelaar07, Aanbieding.Geen, true);
                Bon bon08 = new Bon("Restaurant SOS Piet", 75, 150, "5 sterren restaurant met de enige echte SOS Piet als kok.", 21, @"images\bon\8\", eten_drinken, "Paepestraat", "178", "9260", "Wichelen", Handelaar08, Aanbieding.Geen, true);
                Bon bon09 = new Bon("Wijnproeverij CoBoSh", 25, 75, "Keuze uit verschillende wijnen vergezeld met een hapje.", 47, @"images\bon\9\", eten_drinken, "Arbeidstraat", "14", "9300", "Aalst", Handelaar09, Aanbieding.Geen, true);
                Bon bon10 = new Bon("Wijnproeverij chacha", 22, 75, "Hapje drankje favoriet muziekje.", 22, @"images\bon\10\", eten_drinken, "Ravensteinstraat", "50", "1000", "Brussel", Handelaar10, Aanbieding.Geen, true);


                Bon bon11 = new Bon("Sanitas Wichelen", 5, 30, "Ideale fitness voor oud en jong", 83, @"images\bon\11\", fitness, "Paepestraat", "178", "9260", "Wichelen", Handelaar11, Aanbieding.Geen, true);
                Bon bon12 = new Bon("Fitness Basic-Fit Aalst", 5, 30, "Bekenste fitness van België met vestigingen over het hele land.", 75, @"images\bon\12\", fitness, "Arbeidstraat", "14", "9300", "Aalst", Handelaar12, Aanbieding.Geen, true);
                Bon bon13 = new Bon("Fitness Basic-Fit Gent", 4, 30, "Bekenste fitness van België met vestigingen over het hele land.", 8, @"images\bon\13\", fitness, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar12, Aanbieding.Geen, true);
                Bon bon14 = new Bon("Fitness Basic-Fit Brussel", 6, 30, "Bekenste fitness van België met vestigingen over het hele land.", 53, @"images\bon\14\", fitness, "Ravensteinstraat", "50", "1000", "Brussel", Handelaar12, Aanbieding.Geen, true);
                Bon bon15 = new Bon("Fitness Basic-Fit Brugge", 8, 30, "Bekenste fitness van België met vestigingen over het hele land.", 53, @"images\bon\15\", fitness, "Maalse Steenweg", "50", "8310", "Brugge", Handelaar12, Aanbieding.Geen, true);
                Bon bon16 = new Bon("Fitness Basic-Fit Sint-Truiden", 5, 30, "Bekenste fitness van België met vestigingen over het hele land.", 72, @"images\bon\16\", fitness, "Luikersteenweg ", "40", "3800", "Sint-Truiden", Handelaar12, Aanbieding.Geen, true);
                Bon bon17 = new Bon("Fitness Basic-Fit Wetteren", 6, 30, "Bekenste fitness van België met vestigingen over het hele land.", 65, @"images\bon\17\", fitness, "Cooppallaan ", "40", "9230", "Wetteren", Handelaar12, Aanbieding.Geen, true);
                Bon bon18 = new Bon("Fitness Basic-Fit Wichelen", 4, 30, "Bekenste fitness van België met vestigingen over het hele land.", 22, @"images\bon\18\", fitness, "Paepestraat", "178", "9260", "Wichelen", Handelaar12, Aanbieding.Geen, true);
                Bon bon19 = new Bon("Fitness Basic-Fit Lede", 8, 30, "Bekenste fitness van België met vestigingen over het hele land.", 75, @"images\bon\19\", fitness, "Kasteeldreef", "15", "9340", "Lede", Handelaar12, Aanbieding.Geen, true);


                Bon bon20 = new Bon("Nachtwandeling Aalst at night", 5, 10, "Geniet van de sterrenhemel in de mooie streken van Aalst (met gids).", 63, @"images\bon\20\", uitstappen, "Arbeidstraat", "14", "9300", "Aalst", Handelaar21, Aanbieding.Geen, true);
                Bon bon21 = new Bon("Dagje wallibi in Dendermonde", 25, 142, "Wat is er nu leuker dan een dagje wallibi met vrienden", 34, @"images\bon\21\", uitstappen, "Mechelsesteenweg ", "138", "9200", "Dendermonde", Handelaar22, Aanbieding.Geen, true);
                Bon bon22 = new Bon("Met de trein naar Oostende", 36, 159, "Spring zong er al over dus wat houd je tegen het te doen", 45, @"images\bon\22\", uitstappen, "Torhoutsesteenweg", "611", "8400", "Oostende", Handelaar23, Aanbieding.Geen, true);
                Bon bon23 = new Bon("Weekendje disneyland parijs", 29, 251, "Disneyland de bestemming voor groot en klein", 35, @"images\bon\23\", uitstappen, "Leopoldlaan", "1", "1930", "Zaventem", Handelaar24, Aanbieding.Geen, true);
                Bon bon24 = new Bon("De grotten van Han", 50, 264, "Het liedje zit ongetwijfeld al in je hoofd dus ga nu gewoon", 86, @"images\bon\24\", uitstappen, "Rue Joseph Lamotte", "2", "5580", "Han-sur-Lesse", Handelaar25, Aanbieding.Geen, true);
                Bon bon25 = new Bon("Historisch bezoek Breemdonk", 6, 185, "Voor de oorlog fanaten een must", 35, @"images\bon\25\", uitstappen, "Brandstraat", "57", "2830", "Willebroek", Handelaar26, Aanbieding.Geen, true);


                Bon bon26 = new Bon("Bloemencenter Brenk", 1, 35, "Stel zelf uw setje bloemen samen met deze bon.", 43, @"images\bon\26\", huis_tuin, "Arbeidstraat", "14", "9300", "Aalst", Handelaar31, Aanbieding.Geen, true);
                Bon bon27 = new Bon("Potgrond De Mol in Lede", 22, 233, "Heb je grond nodig voor in een pot", 68, @"images\bon\27\", huis_tuin, "Kasteeldreef", "15", "9340", "Lede", Handelaar32, Aanbieding.Geen, true);
                Bon bon28 = new Bon("Schelfhout Ten Aalst", 36, 345, "Schelfhout, waar moet je andes zijn!", 75, @"images\bon\28\", huis_tuin, "Arbeidstraat", "14", "9300", "Aalst", Handelaar33, Aanbieding.Geen, true);
                Bon bon29 = new Bon("Bloemetje liesje in Gent", 13, 468, "Lies, verkoopt ook wel een madelief ", 25, @"images\bon\29\", huis_tuin, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar34, Aanbieding.Geen, true);
                Bon bon30 = new Bon("Funa Lima tuincentrum Lede", 26, 232, "Vissen, fonteinen, dieraccesoire...", 14, @"images\bon\30\", huis_tuin, "Kasteeldreef", "15", "9340", "Lede", Handelaar35, Aanbieding.Geen, true);
                Bon bon31 = new Bon("Vijvervoorziening Blub", 30, 404, "Blub, de winkel voor vis enthousiasten", 35, @"images\bon\31\", huis_tuin, "Arbeidstraat", "14", "9300", "Aalst", Handelaar36, Aanbieding.Geen, true);
                Bon bon32 = new Bon("Grasmaaiers Bontinck", 25, 89, "Jaren ervaring in het snoeien", 76, @"images\bon\32\", huis_tuin, "Paepestraat", "178", "9260", "Wichelen", Handelaar37, Aanbieding.Geen, true);
                Bon bon33 = new Bon("Aveve boerenbond te Aalst", 31, 416, "Bij de boerenbond vind je altijd wat je zoekt", 75, @"images\bon\33\", huis_tuin, "Arbeidstraat", "14", "9300", "Aalst", Handelaar38, Aanbieding.Geen, true);
                Bon bon34 = new Bon("Groener Gras In Wetteren", 12, 526, "Gazon voorzieningen", 14, @"images\bon\34\", huis_tuin, "Cooppallaan ", "40", "9230", "Wetteren", Handelaar39, Aanbieding.Geen, true);

                Bon bon35 = new Bon("Pukkelpop weekend tickets", 21, 513, "Pukkelpop, dat moet je gedaan hebben", 57, @"images\bon\35\", events, "Paepestraat", "178", "9260", "Wichelen", Handelaar41, Aanbieding.Geen, true);
                Bon bon36 = new Bon("Lokerse bierfeesten", 44, 393, "Bierfanaten kunnen dit niet missen", 75, @"images\bon\36\", events, "Kleine Dam", "1", "9160", "Lokeren", Handelaar42, Aanbieding.Geen, true);
                Bon bon37 = new Bon("Gentse feesten eetfestijn", 42, 464, "Drinken en eten, meer moet dat niet zijn", 25, @"images\bon\37\", events, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar43, Aanbieding.Geen, true);
                Bon bon38 = new Bon("Gameforce in de Nekkerhalle", 38, 179, "Voor elke nerd wat wils", 14, @"images\bon\38\", events, "Ravensteinstraat", "50", "1000", "Brussel", Handelaar44, Aanbieding.Geen, true);
                Bon bon39 = new Bon("Drive A Ferrari Day", 8, 318, "Ideal geshenk voor een autofanaat", 38, @"images\bon\39\", events, "Paepestraat", "178", "9260", "Wichelen", Handelaar45, Aanbieding.Geen, true);
                Bon bon40 = new Bon("Facts: trein en eten", 34, 197, "Cosplay, eten en vervoer", 18, @"images\bon\40\", events, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar46, Aanbieding.Geen, true);

                Bon bon41 = new Bon("Makeup pallete Nude", 29, 374, "Het bekendste merk zijn palette", 67, @"images\bon\41\", beauty, "Paepestraat", "178", "9260", "Wichelen", Handelaar51, Aanbieding.Geen, true);
                Bon bon42 = new Bon("Ici Paris verwenbon", 15, 500, "Een parfum kan je nooit mee misdoen", 17, @"images\bon\42\", beauty, "Arbeidstraat", "14", "9300", "Aalst", Handelaar52, Aanbieding.Geen, true);
                Bon bon43 = new Bon("Lipstick Lover Aalst", 8, 404, "Voor de lippen lovers", 86, @"images\bon\43\", beauty, "Arbeidstraat", "14", "9300", "Aalst", Handelaar53, Aanbieding.Geen, true);

                Bon bon44 = new Bon("Sofa en Co", 18, 389, "Relax in een sofa van sofa en co", 71, @"images\bon\44\", interieur, "Arbeidstraat", "14", "9300", "Aalst", Handelaar61, Aanbieding.Geen, true);
                Bon bon45 = new Bon("Deba meubelen", 36, 202, "Verkoopt al uw interieur", 37, @"images\bon\45\", interieur, "Arbeidstraat", "14", "9300", "Aalst", Handelaar62, Aanbieding.Geen, true);
                Bon bon46 = new Bon("Ikea huisvoorzieningen", 40, 375, "Meubelspiaclist sinds 74", 71, @"images\bon\46\", interieur, "Paepestraat", "178", "9260", "Wichelen", Handelaar63, Aanbieding.Geen, true);
                Bon bon47 = new Bon("Leenbakker", 34, 335, "Om te kopen, niet te lenen", 37, @"images\bon\47\", interieur, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar64, Aanbieding.Geen, true);
                Bon bon48 = new Bon("Salon Ballon Gent", 13, 352, "Sallon Ballon is een speciaalzaak te Gent", 76, @"images\bon\48\", interieur, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar65, Aanbieding.Geen, true);
                Bon bon49 = new Bon("Keukens Donald", 45, 244, "Al 8 jaar maak ik keukens alsof ze voor mezelf zijn", 46, @"images\bon\49\", interieur, "Arbeidstraat", "14", "9300", "Aalst", Handelaar66, Aanbieding.Geen, true);
                Bon bon50 = new Bon("Modern Gent", 31, 510, "Modern interieur hoeft niet duur te zijn", 75, @"images\bon\50\", interieur, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar67, Aanbieding.Geen, true);
                Bon bon51 = new Bon("Kunst & Kitch", 18, 186, "Een beetje kunst, een beetje kitch", 46, @"images\bon\51\", interieur, "Paepestraat", "178", "9260", "Wichelen", Handelaar68, Aanbieding.Geen, true);
                Bon bon52 = new Bon("Moderne interieur Gill", 5, 60, "Op maat gemaakt interieur tegen een zacht prijsje", 45, @"images\bon\52\", interieur, "Arbeidstraat", "14", "9300", "Aalst", Handelaar69, Aanbieding.Geen, true);

                Bon bon53 = new Bon("C&A Aalst", 24, 480, "De kledingwinkel in Aalst en omstreken", 42, @"images\bon\53\", kledij, "Arbeidstraat", "14", "9300", "Aalst", Handelaar71, Aanbieding.Geen, true);
                Bon bon54 = new Bon("AS Advantures", 48, 373, "Kledie om een avontuur mee aan te gaan", 47, @"images\bon\54\", kledij, "Paepestraat", "178", "9260", "Wichelen", Handelaar72, Aanbieding.Geen, true);
                Bon bon55 = new Bon("Ultra Wet", 41, 413, "De kledingspecialist voor droog en nat", 71, @"images\bon\55\", kledij, "Arbeidstraat", "14", "9300", "Aalst", Handelaar73, Aanbieding.Geen, true);
                Bon bon56 = new Bon("Holiday", 24, 489, "Voor al uw feestkledij", 17, @"images\bon\56\", kledij, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar74, Aanbieding.Geen, true);
                Bon bon57 = new Bon("Bram's Fashion", 23, 86, "Voor ieder wat wilds", 73, @"images\bon\57\", kledij, "Paepestraat", "178", "9260", "Wichelen", Handelaar75, Aanbieding.Standaard, true);
                Bon bon58 = new Bon("Bontinck's Panthers", 30, 453, "Pants from Bontinck are dreams for legs", 72, @"images\bon\58\", kledij, "Arbeidstraat", "14", "9300", "Aalst", Handelaar76, Aanbieding.Geen, true);
                Bon bon59 = new Bon("Bre Bra", 29, 478, "Van A tot Z, u vindt het bij ons", 92, @"images\bon\59\", kledij, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar77, Aanbieding.Standaard, true);
                Bon bon69 = new Bon("Pikantje", 34, 402, "Erotische kledingwinkel", 9, @"images\bon\69\", kledij, "Arbeidstraat", "14", "9300", "Aalst", Handelaar78 , Aanbieding.Geen, true);

                Bon bon61 = new Bon("Fnac Aalst", 3, 377, "De multimedia specialist in Europa", 54, @"images\bon\61\", multimedia, "Arbeidstraat", "14", "9300", "Aalst", Handelaar81, Aanbieding.Geen, true);
                Bon bon62 = new Bon("Mediamarkt Dendermonde", 46, 433, "Electronica tegen een spot prijs", 45, @"images\bon\62\", multimedia, "Mechelsesteenweg", "138", "9200", "Dendermonde", Handelaar82, Aanbieding.Geen, true);
                Bon bon63 = new Bon("Van Den Borre Gent", 31, 181, "Koffiezets voor 12€", 15, @"images\bon\63\", multimedia, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar83, Aanbieding.Geen, true);
                Bon bon64 = new Bon("Bontinck IT brugge", 36, 539, "Een probleempje groot of klein, dan moet je bij IT Lennert zijn", 67, @"images\bon\64\", multimedia, "Maalse Steenweg", "50", "8310", "Brugge", Handelaar84, Aanbieding.Standaard, true);
                Bon bon65 = new Bon("Schets Apple Premium", 49, 124, "U vindt alle laatste Apple producten hier", 78, @"images\bon\65\", multimedia, "Paepestraat", "178", "9260", "Wichelen", Handelaar85, Aanbieding.Geen, true);
                Bon bon66 = new Bon("Lab9 Aalst", 7, 340, "Officiele Apple reseller", 64, @"images\bon\66\", multimedia, "Arbeidstraat", "14", "9300", "Aalst", Handelaar86, Aanbieding.Geen, true);
                Bon bon67 = new Bon("De Conincks Screen Repair", 38, 536, "Een ongelukje is rap gebeurd", 75, @"images\bon\67\", multimedia, "Paepestraat", "178", "9260", "Wichelen", Handelaar87, Aanbieding.Geen, true);
                Bon bon68 = new Bon("Medion Custom", 40, 316, "Medion laptop op maat gemaakt", 24, @"images\bon\68\", multimedia, "Sint-Pietersnieuwstraat", "124", "9000", "Gent", Handelaar88, Aanbieding.Geen, true);
                Bon bon60 = new Bon("Dell Dinosaur", 27, 311, "MS Dos specialist", 30, @"images\bon\60\", multimedia, "Paepestraat", "178", "9260", "Wichelen", Handelaar89, Aanbieding.Geen, true);


                Bon bon70 = new Bon("Generieke cadeaubon", 1, 50, "Niet zeker welke bon u juist wilt, dan is deze generieke bon iets voor u!", 457, @"images\bon\70\", generiek, "Arbeidstraat", "14", "9300", "Aalst", Handelaar91, Aanbieding.Slider, true);
                var bonnen = new List<Bon>
                {
                   bon01, bon02, bon03, bon04, bon05, bon06, bon07, bon08, bon09, bon10, bon11, bon12, bon13, bon14, bon15, bon16, bon17, bon18, bon19, bon20, bon21, bon22, bon23, bon24, bon25, bon26, bon27, bon28, bon29, bon30, bon31, bon32, bon33, bon34, bon35, bon36, bon37, bon38, bon39, bon40, bon41, bon42, bon43, bon44, bon45, bon46, bon47, bon48, bon49, bon50, bon51, bon52, bon53, bon54, bon55, bon56, bon57, bon58, bon59, bon60, bon61, bon62, bon63, bon64, bon65, bon66, bon67, bon68, bon69, bon70
                };

                _dbContext.Bonnen.AddRange(bonnen);

                Gebruiker user00 = new Gebruiker { Voornaam = "John", Familienaam = "Doe", Geslacht = Geslacht.Anders, Emailadres = "lekkerlokaal" };
                Gebruiker user01 = new Gebruiker { Voornaam = "Brent", Familienaam = "Schets", Geslacht = Geslacht.Man, Emailadres = "brent@schets.com" };
                Gebruiker user02 = new Gebruiker { Voornaam = "Bram", Familienaam = "De Coninck", Geslacht = Geslacht.Man, Emailadres = "bram@bramdeconinck.com" };
                Gebruiker user03 = new Gebruiker { Voornaam = "Lennert", Familienaam = "Bontinck", Geslacht = Geslacht.Man, Emailadres = "lennert@lennertbontinck.com" };

                var personen = new List<Gebruiker>
                {
                    user00, user01, user02, user03
                };

                _dbContext.Gebruikers.AddRange(personen);

                _dbContext.SaveChanges();

                //admin voorbeeld
                await CreateUser("lekkerlokaalst@gmail.com", "lekkerlokaalst@gmail.com", "BraLenBreAdmin", "admin");
                await CreateUser("admin@lekkerlokaal.be", "admin@lekkerlokaal.be", "BraLenBreProductions", "admin");
                await CreateUser("klant@gmail.com", "klant@gmail.com", "klantje", "klant");
                _dbContext.Gebruikers.Add(new Gebruiker
                {
                    Emailadres = "lekkerlokaalst@gmail.com",
                    Voornaam = "BraLenBre",
                    Familienaam = "Groep één",
                    Geslacht = Geslacht.Man
                });
                _dbContext.Gebruikers.Add(new Gebruiker
                {
                    Emailadres = "admin@lekkerlokaal.be",
                    Voornaam = "Joachim",
                    Familienaam = "Rummens",
                    Geslacht = Geslacht.Man
                });
                _dbContext.Gebruikers.Add(new Gebruiker
                {
                    Emailadres = "klant@gmail.com",
                    Voornaam = "Klant",
                    Familienaam = "Janssens",
                    Geslacht = Geslacht.Man
                });

                _dbContext.SaveChanges();

                //handelaar voorbeeld
                var user = new ApplicationUser { UserName = "info@lokaalmarkt.be", Email = "info@lokaalmarkt.be", EmailConfirmed = true };
                var wachtwoord = "BraLenBreProductions";
                var result = await _userManager.CreateAsync(user, wachtwoord);
                await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "handelaar"));

                Handelaar lokaalmarkt = new Handelaar("Lokaal", "info@lokaalmarkt.be", "Lokaal is een overdekte boerenmarkt met bar en kinderatelier.", "BE7748556081", "Denderstraat", "22", "9300", "Aalst", true);
                _dbContext.Handelaars.Add(lokaalmarkt);

                Bon lokaalmarktBon = new Bon("Lokaalmarkt Aalst", 15, 300, "De beste markt van aalst!", 27, @"images\bon\71\", eten_drinken, "Denderstraat", "22", "9300", "Aalst", lokaalmarkt, Aanbieding.Geen, true);
                _dbContext.Bonnen.Add(lokaalmarktBon);

                _dbContext.SaveChanges();
            }
        }

        private async Task CreateUser(string userName, string email, string password, string role)
        {
            var user = new ApplicationUser { UserName = userName, Email = email, EmailConfirmed = true };
            await _userManager.CreateAsync(user, password);
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, role));
        }
    }
}
