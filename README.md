# Olio_harjoitusVIII

1. Tehtävä: Kirjaston kirjat

Ohjelmassa on tarkoitus hallita kirjaston kirjakokoelmaa. Käyttäjä voi lisätä uusia kirjoja,
poistaa niitä ja nähdä kaikki tallennetut kirjat. Jokaisella kirjalla on tiedot, kuten kirjan
nimi, kirjoittaja ja ISBN-numero.

Vaihe 1: Luo Kirja-luokka

Kirja-luokka sisältää seuraavat ominaisuudet:
• Ominaisuudet: Nimi, Kirjoittaja, ISBN.
• Metodit: Konstruktorin avulla luodaan uusia kirjoja.

Vaihe 2: Luo Kirjasto-luokka

Kirjasto-luokka vastaa kirjakokoelman hallinnasta. Tähän luokkaan kuuluu lista
Kirja-olioista ja metodeja kirjojen lisäämiseen, poistamiseen ja listaamiseen.

Vaihe 3: Pääohjelman toteutus
Pääohjelmassa käyttäjä voi lisätä kirjoja, poistaa kirjoja ISBN-numeron perusteella ja
listata kaikki kirjat.

Ohjelman toiminta
Kun ohjelma suoritetaan, käyttäjä voi:
 - Lisätä kirjan - antaa kirjan nimen, kirjoittajan ja ISBN-numeron.
 - Poistaa kirjan - antaa ISBN-numeron ja poistaa sen kirjan, jolla on kyseinen ISBN.
 - Näyttää kaikki kirjat - luettelee kaikki kirjastoon lisätyt kirjat.
 - Lopettaa ohjelman.

Tietoja ei tarvitse tallentaa tiedostoon, tai tietokantaan.

2. Tehtävä: Opiskelijat ja kurssien arvosanat

Tässä ohjelmassa mallinnetaan opiskelijoita ja heidän suorittamiaan kursseja.
Opiskelijoilla voi olla useita kursseja, ja jokaisella kurssilla on arvosana. Ohjelma voi
laskea opiskelijan keskiarvon kaikista suoritetuista kursseista ja listata tiedot.

Vaihe 1: Luo Kurssi-luokka

Kurssi-luokka edustaa yksittäistä kurssia. Siinä on seuraavat ominaisuudet:
- Ominaisuudet: Nimi ja Arvosana.
- Metodit: Konstruktorin avulla luodaan uusia kursseja.
- Vaihe 2: Luo Opiskelija-luokka
    Opiskelija-luokka edustaa yksittäistä opiskelijaa, jolla on lista kursseista ja toimintoja
    kurssien lisäämiseen ja keskiarvon laskemiseen.

Vaihe 3: Pääohjelman toteutus

Pääohjelmassa käyttäjä voi lisätä opiskelijoita, lisätä kursseja opiskelijoille, tarkastella
opiskelijan kursseja ja laskea opiskelijan keskiarvon.

Ohjelman toiminta
Kun ohjelma suoritetaan, käyttäjällä on seuraavat vaihtoehdot:
- Lisätä opiskelija – luo uuden opiskelijan nimellä.
- Lisätä kurssi opiskelijalle – lisää opiskelijan kurssilistaan uuden kurssin ja arvosanan.
- Näyttää opiskelijan kurssit – listaa kaikki opiskelijan kurssit ja arvosanat.
- Laskea opiskelijan keskiarvo – laskee opiskelijan kurssien keskiarvon ja näyttää sen.
- Lopettaa ohjelma – lopettaa ohjelman